using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Runtime.InteropServices;

namespace ShanbayWordListToolKit
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        //相关参数配置--------------------------------------
        //文本框警告背景色
        private Color WarningColor = Color.Red;

        //导入Win32API
        [DllImport("user32")]
        public static extern bool GetCaretPos(out Point lpPoint);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetFocus();
        [DllImport("user32.dll")]
        private static extern IntPtr AttachThreadInput(IntPtr idAttach, IntPtr idAttachTo, int fAttach);
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentThreadId();
        [DllImport("user32.dll")]
        private static extern void ClientToScreen(IntPtr hWnd, ref Point p);

        //定义一些通用方法便于在后续直接进行调用-----------------------------------
        //对List乱序
        private List<string> RandomList(List<string> beforeList)
        {
            List<string> afterList = new List<string>();
            Random random = new Random();
            foreach (string word in beforeList)
            {
                afterList.Insert(random.Next(afterList.Count), word);
            }
            return afterList;
        }
 
        //List去重复元素
        private List<string> DistinctList(List<string> beforeList)
        {
            return beforeList.Distinct().ToList();
        }

        //提取单词List
        private List<string> ExtractList(string paths)
        {
            List<string> extractedList = new List<string>();
            try
            {
                //提取路径
                string[] pathArray = paths.Split(Environment.NewLine.ToCharArray());
                foreach (string singlePath in pathArray)
                {
                    if (!Regex.IsMatch(singlePath, @"^\s*$"))
                    {
                        //逐行读取文件内容
                        StreamReader sr = new StreamReader(singlePath);
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            //提取单词。规定：每行第一个单词为待提取单词
                            Match match = Regex.Match(line, @"^\s*([a-zA-Z]+)");
                            if (match.Value.ToString() != "")
                            {
                                extractedList.Add(match.Value.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //抛出异常
                throw e;
            }
            //注意：未对提取的List进行去重
            return extractedList;
        }

        //获取光标位于屏幕的位置
        private Point CaretPos()
        {
            IntPtr ptr = GetForegroundWindow();
            Point p = new Point();

            //得到Caret在屏幕上的位置   
            if (ptr.ToInt32() != 0)
            {
                IntPtr targetThreadID = GetWindowThreadProcessId(ptr, IntPtr.Zero);
                IntPtr localThreadID = GetCurrentThreadId();

                if (localThreadID != targetThreadID)
                {
                    AttachThreadInput(localThreadID, targetThreadID, 1);
                    ptr = GetFocus();
                    if (ptr.ToInt32() != 0)
                    {
                        GetCaretPos(out   p);
                        ClientToScreen(ptr, ref   p);
                    }
                    AttachThreadInput(localThreadID, targetThreadID, 0);
                }
            }
            return p;
        }

        //单词来源浏览按钮单击事件
        private void viewsource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "请选择单词来源";
            ofd.Filter = "文本文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    sourcepaths.Text += filename + Environment.NewLine;
                }
            }
            ofd.Dispose();
        }

        //大纲词汇路径文本变更事件
        private void allpath_TextChanged(object sender, EventArgs e)
        {
            allpath.BackColor = SystemColors.Window;
            /*
             * 废弃：自动修正选项已被去除，将默认进行自动修正
            //当大纲词汇不为空时，自动修正默认勾选
            if (!Regex.IsMatch(allpath.Text, @"^\s*$"))
            {
                autofix.CheckState = CheckState.Checked;
            }
            else
            {
                //当大纲词汇为空时，自动修正默认不勾选
                autofix.CheckState = CheckState.Unchecked;
            }
             * */
        }

        //大纲词汇浏览按钮单击事件
        private void viewall_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "请选择大纲词汇";
            ofd.Filter = "文本文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    allpath.Text += filename + Environment.NewLine;
                }
            }
            ofd.Dispose();
        }

        //过滤词表浏览按钮单击事件
        private void vieweasy_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "请选择过滤词表";
            ofd.Filter = "文本文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    easypath.Text += filename + Environment.NewLine;
                }
            }
            ofd.Dispose();
        }

        //单词来源路径文本变更事件
        private void sourcepath_TextChanged(object sender, EventArgs e)
        {
            sourcepaths.BackColor = SystemColors.Window;
        }
        
        //我的扇贝空间链接
        private void myzone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.shanbay.com/bdc/review/progress/18242374");
        }

        //词表创建标签下，一键创建按钮的单击事件
        private void onekeycreate_Click(object sender, EventArgs e)
        {
            listcreatebar.Value = 0;
            //输入合法性检查------------------------------------------------
            //单词来源输入非空检查
            if (Regex.IsMatch(sourcepaths.Text, @"^\s*$"))
            {
                sourcepaths.BackColor = WarningColor;
                return;
            }
            //检测长度过滤输入合法性
            if (!Regex.IsMatch(leastlen.Text, @"^\d+$"))
            {
                leastlen.BackColor = WarningColor;
                return;
            }
            //检查词频过滤输入合法性
            if (!Regex.IsMatch(leasttimes.Text, @"^\d+$"))
            {
                leasttimes.BackColor = WarningColor;
                return;
            }
            listcreatebar.Value = 3;
            //先提取大纲词汇和过滤词表，进行计算，然后根据长度筛选
            //提取大纲词汇-------------------------------------------------
            List<string> allWordsList = new List<string>();
            if (!Regex.IsMatch(allpath.Text, @"^\s*$"))
            {
                try
                {
                    allWordsList = DistinctList(ExtractList(allpath.Text));
                }
                catch (Exception)
                {
                    allpath.BackColor = WarningColor;
                    return;
                }
            }
            listcreatebar.Value += 1;   //4
            //提取过滤词表-----------------------------------------------------
            List<string> easyWordsList = new List<string>();
            if (!Regex.IsMatch(easypath.Text, @"^\s*$"))
            {
                try
                {
                    easyWordsList = DistinctList(ExtractList(easypath.Text));
                }
                catch (Exception)
                {
                    easypath.BackColor = WarningColor;
                    return;
                }
            }
            listcreatebar.Value += 1;   //5
            //allWordList与easyList进行计算
            if (allWordsList.Count > 0)
            {
                allWordsList = allWordsList.Except(easyWordsList).ToList<string>();
                easyWordsList.Clear();
            }
            listcreatebar.Value += 1;   //6
            //长度过滤-------------------------------------------------
            for (int i = allWordsList.Count - 1; i >= 0; i--)
            {
                if (allWordsList[i].Length < int.Parse(leastlen.Text))
                {
                    allWordsList.RemoveAt(i);
                }
            }
            listcreatebar.Value += 1;   //7

            //用于保存从单词来源提取的单词
            //该List的元素可能非常多！循环遍历时留意算法复杂度
            List<string> sourceList = new List<string>();
            //提取单词-----------------------------------------------
            try
            {
                string[] sourcepathArray = sourcepaths.Text.Split(Environment.NewLine.ToCharArray());
                foreach (string sourcepath in sourcepathArray)
                {
                    if (!Regex.IsMatch(sourcepath, @"^\s*$"))
                    {
                        StreamReader sr = new StreamReader(sourcepath);
                        string line;
                        //逐行读取单词来源中的数据
                        while ((line = sr.ReadLine()) != null)
                        {
                            //匹配单词
                            //若自动修正未勾选，在此处即完成长度过滤
                            //即使要进行自动修正，在此处可完成长度的预过滤
                            MatchCollection mc = Regex.Matches(line, @"\b[a-zA-Z]{" + leastlen.Text + @",}\b");
                            //将单词匹配结果存储在List中
                            foreach (Match m in mc)
                            {
                                //单词来源中所有单词转成小写
                                sourceList.Add(m.ToString().ToLower());
                            }
                        }
                    }
                }
            }
            //读取失败时，单词来源示意警告
            catch (IOException)
            {
                sourcepaths.BackColor = WarningColor;
                return;
            }
            listcreatebar.Value = 40;
            //重要算法设计：
            //因为sourceList的元素可能非常多，所以要先进行词频统计，
            //再去重，再做自动修正，同时修正词频统计结果，大大降低算法复杂度。
            //统计词频-------------------------------------------------
            //用于存储词频统计结果
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string word in sourceList)
            {
                if (dic.ContainsKey(word))
                {
                    dic[word] += 1;
                }
                else
                {
                    dic.Add(word, 1);
                }
            }
            listcreatebar.Value = 50;
            //对sourceList去重
            sourceList = DistinctList(sourceList);
            listcreatebar.Value += 1;
            //自动修正-------------------------------------------------
            //默认小写比较，由于前面对sourceList中的单词已转小写，故不重复转小写
            //修正的算法需要不断改进
            //辅音字母
            string consonant = "bcdfghjklmnpqrstvwxz";
            //元音字母
            string vowel = "aeiou";
            //当指定大纲词汇时，对其进行修正-------------------------------
            if (allWordsList.Count > 0)
            {
                List<string> tmpList = new List<string>();
                //修正大小写
                foreach (string word in allWordsList)
                {
                    if (Regex.IsMatch(word, @"^[A-Z]"))
                    {
                        if (sourceList.Contains(word.ToLower()))
                        {
                            //将需大写的单词暂存
                            tmpList.Add(word);
                            dic.Add(word, dic[word.ToLower()]);
                            sourceList.Remove(word.ToLower());
                        }
                    }
                }

                for (int i = 0; i < sourceList.Count; i++)
                {
                    string origin;
                    string word = sourceList[i];
                    //若在大纲词汇中没有会进行修正
                    if (!allWordsList.Contains(word))
                    {
                        //名词复数还原
                        //名词复数逆变换0：s$，去s再匹配
                        if (Regex.IsMatch(word, @"s$"))
                        {
                            origin = word.Remove(word.Length - 1, 1);
                            if (allWordsList.Contains(origin))
                            {
                                if (dic.ContainsKey(origin))
                                {
                                    dic[origin] += dic[word];
                                }
                                else
                                {
                                    dic.Add(origin, dic[word]);
                                }
                                sourceList[i] = origin;
                            }
                            else
                            {
                                //匹配s$且在该条件下继续匹配，提高效率
                                //名词复数逆变换1：oes$|ses$|shes$|ches$|xes$，去es后匹配
                                if (Regex.IsMatch(word, @"oes$|ses$|shes$|ches$|xes$"))
                                {
                                    origin = word.Remove(word.Length - 2, 2);
                                    if (allWordsList.Contains(origin))
                                    {
                                        if (dic.ContainsKey(origin))
                                        {
                                            dic[origin] += dic[word];
                                        }
                                        else
                                        {
                                            dic.Add(origin, dic[word]);
                                        }
                                        sourceList[i] = origin;
                                    }
                                }
                                else
                                {
                                    //名词复数逆变换2：[辅音字母]ies$，变y再匹配
                                    if (Regex.IsMatch(word, @"[" + consonant + @"]ies$"))
                                    {
                                        origin = word.Remove(word.Length - 3, 3) + "y";
                                        if (allWordsList.Contains(origin))
                                        {
                                            if (dic.ContainsKey(origin))
                                            {
                                                dic[origin] += dic[word];
                                            }
                                            else
                                            {
                                                dic.Add(origin, dic[word]);
                                            }
                                            sourceList[i] = origin;
                                        }
                                    }
                                    else
                                    {
                                        //名词复数逆变换3：ves$，变f匹配再变fe匹配
                                        if (Regex.IsMatch(word, @"ves$"))
                                        {
                                            origin = word.Remove(word.Length - 3, 3) + "f";
                                            if (dic.ContainsKey(origin))
                                            {
                                                if (dic.ContainsKey(origin))
                                                {
                                                    dic[origin] += dic[word];
                                                }
                                                else
                                                {
                                                    dic.Add(origin, dic[word]);
                                                }
                                                sourceList[i] = origin;
                                            }
                                            else
                                            {
                                                origin = word.Remove(word.Length - 3, 3) + "fe";
                                                if (dic.ContainsKey(origin))
                                                {
                                                    if (dic.ContainsKey(origin))
                                                    {
                                                        dic[origin] += dic[word];
                                                    }
                                                    else
                                                    {
                                                        dic.Add(origin, dic[word]);
                                                    }
                                                    sourceList[i] = origin;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            //动词时态还原
                            //不是s$
                            //过去分词逆变换0：ed$，去ed后匹配
                            if (Regex.IsMatch(word, @"ed$"))
                            {
                                origin = word.Remove(word.Length - 2, 2);
                                if (allWordsList.Contains(origin))
                                {
                                    if (dic.ContainsKey(origin))
                                    {
                                        dic[origin] += dic[word];
                                    }
                                    else
                                    {
                                        dic.Add(origin, dic[word]);
                                    }
                                    sourceList[i] = origin;
                                }
                                else
                                {
                                    origin = word.Remove(word.Length - 1, 1);
                                    //过去分词逆变换1：去d后匹配
                                    if (allWordsList.Contains(origin))
                                    {
                                        if (dic.ContainsKey(origin))
                                        {
                                            dic[origin] += dic[word];
                                        }
                                        else
                                        {
                                            dic.Add(origin, dic[word]);
                                        }
                                        sourceList[i] = origin;
                                    }
                                    else
                                    {
                                        //过去分词逆变换2：ied$，变y后匹配
                                        if (Regex.IsMatch(word, @"ied$"))
                                        {
                                            origin = word.Remove(word.Length - 3, 3) + "y";
                                            if (allWordsList.Contains(origin))
                                            {
                                                if (dic.ContainsKey(origin))
                                                {
                                                    dic[origin] += dic[word];
                                                }
                                                else
                                                {
                                                    dic.Add(origin, dic[word]);
                                                }
                                                sourceList[i] = origin;
                                            }
                                        }
                                        else
                                        {
                                            //过去分词逆变换3：元辅辅ed$（且后两辅相同），去辅ed$后匹配
                                            //优化：简化重读闭音音节的判定
                                            if (Regex.IsMatch(word, @"[" + vowel + @"]([" + consonant + @"])\1ed$"))
                                            {
                                                origin = word.Remove(word.Length - 3, 3);
                                                if (allWordsList.Contains(origin))
                                                {
                                                    if (dic.ContainsKey(origin))
                                                    {
                                                        dic[origin] += dic[word];
                                                    }
                                                    else
                                                    {
                                                        dic.Add(origin, dic[word]);
                                                    }
                                                    sourceList[i] = origin;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //不是s$，也不是ed$
                                //现在分词逆变换0：ing$，去ing后匹配
                                if (Regex.IsMatch(word, @"ing$"))
                                {
                                    origin = word.Remove(word.Length - 3, 3);
                                    if (allWordsList.Contains(origin))
                                    {
                                        if (dic.ContainsKey(origin))
                                        {
                                            dic[origin] += dic[word];
                                        }
                                        else
                                        {
                                            dic.Add(origin, dic[word]);
                                        }
                                        sourceList[i] = origin;
                                    }
                                    else
                                    {
                                        //现在分词逆变换1：变e后匹配
                                        origin = word.Remove(word.Length - 3, 3) + "e";
                                        if (allWordsList.Contains(origin))
                                        {
                                            if (dic.ContainsKey(origin))
                                            {
                                                dic[origin] += dic[word];
                                            }
                                            else
                                            {
                                                dic.Add(origin, dic[word]);
                                            }
                                            sourceList[i] = origin;
                                        }
                                        else
                                        {
                                            //现在分词逆变换2：元辅辅ing$（且后两辅相同），去辅ing$后匹配
                                            if (Regex.IsMatch(word, @"[" + vowel + @"]([" + consonant + @"])\1ing$"))
                                            {
                                                origin = word.Remove(word.Length - 4, 4);
                                                if (allWordsList.Contains(origin))
                                                {
                                                    if (dic.ContainsKey(origin))
                                                    {
                                                        dic[origin] += dic[word];
                                                    }
                                                    else
                                                    {
                                                        dic.Add(origin, dic[word]);
                                                    }
                                                    sourceList[i] = origin;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                //sourceList在修正后进行去重
                sourceList = DistinctList(sourceList);
                //将tmpList并入sourceList
                sourceList = sourceList.Union(tmpList).ToList<string>();
            }
            //当没指定大纲词汇而指定过滤词表时，对其进行修正----------------------------
            //修正后的单词需要被过滤，因此不需要对词频统计进行修正
            if (allWordsList.Count == 0 && easyWordsList.Count > 0)
            {
                //过滤需大写的单词
                foreach (string word in easyWordsList)
                {
                    if (Regex.IsMatch(word, @"^[A-Z]"))
                    {
                        if (sourceList.Contains(word.ToLower()))
                        {
                            sourceList.Remove(word);
                        }
                    }
                }
                //修正后进行过滤
                for (int i = 0; i < sourceList.Count; i++)
                {
                    string word = sourceList[i];
                    //名词复数修正
                    if (Regex.IsMatch(word, @"s$"))
                    {
                        //名词复数逆变换0:s$，去s后匹配
                        if (easyWordsList.Contains(word.Remove(word.Length - 1, 1)))
                        {
                            sourceList.RemoveAt(i);
                        }
                        else
                        {
                            //名词复数逆变换1：oes$|ses$|shes$|ches$|xes$，去es后匹配
                            if (Regex.IsMatch(word, @"oes$|ses$|shes$|ches$|xes$"))
                            {
                                if (easyWordsList.Contains(word.Remove(word.Length - 2, 2)))
                                {
                                    sourceList.RemoveAt(i);
                                }
                            }
                            else
                            {
                                //名词复数逆变换2：[辅音字母]ies$，变y再匹配
                                if (Regex.IsMatch(word, @"[" + consonant + @"]ies$"))
                                {
                                    if (easyWordsList.Contains(word.Remove(word.Length - 3, 3) + "y"))
                                    {
                                        sourceList.RemoveAt(i);
                                    }
                                }
                                else
                                {
                                    //名词复数逆变换3：ves$，变f匹配再变fe匹配
                                    if (Regex.IsMatch(word, @"ves$"))
                                    {
                                        if (easyWordsList.Contains(word.Remove(word.Length - 3, 3) + "f"))
                                        {
                                            sourceList.RemoveAt(i);
                                        }
                                        else
                                        {
                                            if (easyWordsList.Contains(word.Remove(word.Length - 3, 3) + "fe"))
                                            {
                                                sourceList.RemoveAt(i);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        //动词时态还原
                        //不是s$
                        //过去分词逆变换0：ed$，去ed后匹配
                        if (Regex.IsMatch(word, @"ed$"))
                        {
                            if (easyWordsList.Contains(word.Remove(word.Length - 2, 2)))
                            {
                                sourceList.RemoveAt(i);
                            }
                            else
                            {
                                //过去分词逆变换1：去d后匹配
                                if (easyWordsList.Contains(word.Remove(word.Length - 1, 1)))
                                {
                                    sourceList.RemoveAt(i);
                                }
                                else
                                {
                                    //过去分词逆变换2：ied$，变y后匹配
                                    if (Regex.IsMatch(word, @"ied$"))
                                    {
                                        if (easyWordsList.Contains(word.Remove(word.Length - 3, 3) + "y"))
                                        {
                                            sourceList.RemoveAt(i);
                                        }
                                    }
                                    else
                                    {
                                        //过去分词逆变换3：元辅辅ed$（且后两辅相同），去辅ed$后匹配
                                        //优化：简化重读闭音音节的判定
                                        if (Regex.IsMatch(word, @"[" + vowel + @"]([" + consonant + @"])\1ed$"))
                                        {
                                            if (easyWordsList.Contains(word.Remove(word.Length - 3, 3)))
                                            {
                                                sourceList.RemoveAt(i);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            //不是s$，也不是ed$
                            //现在分词逆变换0：ing$，去ing后匹配
                            if (Regex.IsMatch(word, @"ing$"))
                            {
                                if (easyWordsList.Contains(word.Remove(word.Length - 3, 3)))
                                {
                                    sourceList.RemoveAt(i);
                                }
                                else
                                {
                                    //现在分词逆变换1：变e后匹配
                                    if (easyWordsList.Contains(word.Remove(word.Length - 3, 3) + "e"))
                                    {
                                        sourceList.RemoveAt(i);
                                    }
                                    else
                                    {
                                        //现在分词逆变换2：元辅辅ing$（且后两辅相同），去辅ing$后匹配
                                        if (Regex.IsMatch(word, @"[" + vowel + @"]([" + consonant + @"])\1ing$"))
                                        {
                                            if (easyWordsList.Contains(word.Remove(word.Length - 4, 4)))
                                            {
                                                sourceList.RemoveAt(i);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            listcreatebar.Value = 97;
            //修正后过滤、筛选处理--------------------------
            if (allWordsList.Count > 0)
            {
                //通过计算后的allWordsList进行过滤
                sourceList = sourceList.Intersect(allWordsList).ToList<string>();
            }
            listcreatebar.Value += 1;   //98
            if (easyWordsList.Count > 0)
            {
                //通过过滤词表过滤
                sourceList = sourceList.Except(easyWordsList).ToList<string>();
            }

            //依词频筛选------------------------------------
            else
            {
                for (int i = sourceList.Count - 1; i >= 0; i--)
                {
                    if (dic[sourceList[i]] < int.Parse(leasttimes.Text))
                    {
                        sourceList.RemoveAt(i);
                    }
                }
            }
            listcreatebar.Value = 100;
            /*
             * 废弃：因用户选择生成csv格式后，可自行根据词频或长度进行排序
            //生成最终词表-----------------------------------------------
            //按词频、长度、出现顺序排序
            for (int i = 0; i < sourceList.Count - 1; i++)
            {
                for (int j = i + 1; j < sourceList.Count; j++)
                {
                    if (dic[sourceList[i]] < dic[sourceList[j]])
                    {
                        string tmp = sourceList[i];
                        sourceList[i] = sourceList[j];
                        sourceList[j] = tmp;
                    }
                    else
                    {
                        if (dic[sourceList[i]] == dic[sourceList[j]])
                        {
                            if (sourceList[i].Length > sourceList[j].Length)
                            {
                                string tmp = sourceList[i];
                                sourceList[i] = sourceList[j];
                                sourceList[j] = tmp;
                            }
                        }
                    }
                }
            }
             * */
            //创建词表----------------------------------------------
            //保存文件对话框
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存词表";
            sfd.Filter = "文本文件|*.txt|逗号分隔值文件|*.csv";
            sfd.AddExtension = true;
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    //如果选择生成csv文件，则额外显示词频、长度
                    if (Regex.IsMatch(sfd.FileName, @"\.csv$"))
                    {
                        sw.WriteLine("word,frequency,length");
                        foreach (string word in sourceList)
                        {
                            sw.WriteLine(word + "," + dic[word] + "," + word.Length);
                        }
                    }
                    else
                    {
                        //否则仅显示单词
                        foreach (string word in sourceList)
                        {
                            sw.WriteLine(word);
                        }
                    }
                    sw.Close();
                    //打开所在文件夹
                    System.Diagnostics.Process.Start(Regex.Match(sfd.FileName, @"(.+)\\.+\.(?:txt)?(?:csv)?").Groups[1].ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("创建失败！");
                    return;
                }
                finally
                {
                    sfd.Dispose();
                }
            }
            listcreatebar.Value = 0;
        }

        private void easypath_TextChanged(object sender, EventArgs e)
        {
            easypath.BackColor = SystemColors.Window;
        }

        /*
         * 废弃：若指定了大纲词汇、过滤词表，将自动进行修正
        private void autofix_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(allpath.Text, @"^\s*$") && autofix.CheckState == CheckState.Checked)
            {
                MessageBox.Show("使用自动修正需指定大纲词汇！", "自动修正不可用", MessageBoxButtons.OK, MessageBoxIcon.Information);
                autofix.CheckState = CheckState.Unchecked;
            }
        }
         * */

        private void inputlistview_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择词表";
            ofd.Filter = "文本文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputlistpath.Text = ofd.FileName;
            }
            ofd.Dispose();
        }

        private void startinput_Click(object sender, EventArgs e)
        {
            //自动输入配置参数检查
            if (!Regex.IsMatch(readydelay.Text, @"^\d+$"))
            {
                readydelay.BackColor = WarningColor;
                return;
            }
            if (!Regex.IsMatch(inputwait.Text, @"^\d+$"))
            {
                inputwait.BackColor = WarningColor;
                return;
            }
            if (!Regex.IsMatch(clickspan.Text, @"^\d+$"))
            {
                clickspan.BackColor = WarningColor;
                return;
            }
            //弹出提示窗口，确认继续操作
            DialogResult dr = MessageBox.Show("自动输入过程中需保持浏览器窗口置于最前，并让单词输入框获得焦点，将输入法切换为英文半角输入。您将有"+readydelay.Text+"秒钟的时间来完成该准备过程，然后等待输入完毕。输入过程中切换程序将导致本程序未响应。", "确认继续？", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr.Equals(DialogResult.Cancel))
            {
                //操作被取消
                return;
            }
            //窗口最小化
            this.WindowState = FormWindowState.Minimized;
            //读取词表
            List<string> inputList = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(inputlistpath.Text);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    inputList.Add(line);
                }

            }
            catch (Exception)
            {
                inputlistpath.BackColor = WarningColor;
                return;
            }
            try
            {
                //等待片刻，准备输入
                Thread.Sleep(int.Parse(readydelay.Text) * 1000);
                Point p0 = CaretPos();
                foreach (string word in inputList)
                {
                    //获取光标位置
                    Point p = CaretPos();
                    if (p.X == p0.X)
                    {
                        //输入单词
                        SendKeys.Send(word);
                        Thread.Sleep(int.Parse(clickspan.Text));
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(int.Parse(inputwait.Text));
                        p = CaretPos();
                    }
                    if (p.X > p0.X)
                    {
                        if (tryfix.Checked)
                        {
                            //尝试修正
                            if (Regex.IsMatch(word, @"s$"))
                            {

                            }
                        }
                        //删除单词
                        SendKeys.Send("^a");
                        Thread.Sleep(int.Parse(clickspan.Text));
                        SendKeys.Send("{BS}");
                        Thread.Sleep(int.Parse(inputwait.Text));
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void wordlistview_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择词表文件";
            ofd.Filter = "文本文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wordlistpath.Text = ofd.FileName;
            }
            ofd.Dispose();
        }

        //词表处理执行按钮点击时间
        private void dolistact_Click(object sender, EventArgs e)
        {
            //检查词表路径输入合法性
            if (Regex.IsMatch(wordlistpath.Text, @"^\s*$"))
            {
                wordlistpath.BackColor = WarningColor;
                return;
            }
            //读取词表
            List<string> wordList = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(wordlistpath.Text);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        wordList.Add(line);
                    }
                }
            }
            catch (Exception)
            {
                wordlistpath.BackColor = WarningColor;
                return;
            }
            //单词去重
            if (worddisct.Checked)
            {
                wordList = DistinctList(wordList);
            }
            //乱序
            if (listrandom.Checked)
            {
                wordList = RandomList(wordList);
            }
            //若词表分组被勾选，则进行分组处理
            if (listgroup.Checked)
            {
                if (Regex.IsMatch(groupnum.Text, @"^\d+$"))
                {
                    try
                    {
                        FolderBrowserDialog fbd = new FolderBrowserDialog();
                        fbd.Description = "选择分组词表保存位置";
                        fbd.ShowNewFolderButton = true;
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            for (int fileindex = 1; fileindex <= int.Parse(groupnum.Text); fileindex++)
                            {
                                StreamWriter sw = new StreamWriter(fbd.SelectedPath + @"\WordList" + fileindex + @".txt");
                                for (int i = 0; i < wordList.Count / int.Parse(groupnum.Text); i++)
                                {
                                    sw.WriteLine(wordList[(fileindex - 1) * wordList.Count / int.Parse(groupnum.Text) + i]);
                                }
                                sw.Close();
                            }

                        }
                        else
                        {
                            //对话框被取消
                            return;
                        }
                        System.Diagnostics.Process.Start(fbd.SelectedPath);
                        fbd.Dispose();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("创建失败！");
                        return;
                    }
                }
                else
                {
                    //分组数输入格式不合法
                    groupnum.BackColor = WarningColor;
                    return;
                }
            }
            //若词表分组未被勾选
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "保存词表";
                sfd.Filter = "文本文件|*.txt";
                sfd.AddExtension = true;
                sfd.OverwritePrompt = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(sfd.FileName);
                        foreach (string line in wordList)
                        {
                            sw.WriteLine(line);
                        }
                        sw.Close();
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("执行失败！");
                        return;
                    }
                }
                sfd.Dispose();
            }
        }

        //词表处理分组复选框勾选事件
        private void listgroup_CheckedChanged(object sender, EventArgs e)
        {
            if (!listgroup.Checked)
            {
                label4.Visible = false;
                groupnum.Visible = false;
            }
            else
            {
                label4.Visible = true;
                groupnum.Visible = true;
            }
        }

        private void leasttimes_TextChanged(object sender, EventArgs e)
        {
            leasttimes.BackColor = SystemColors.Window;
        }

        private void leastlen_TextChanged(object sender, EventArgs e)
        {
            leastlen.BackColor = SystemColors.Window;
        }

        /*
         * 废弃：已舍去在线词典功能
         * 废弃原因：不实用，且依赖外部dll不方便
        private void query_Click(object sender, EventArgs e)
        {
            //检查待查询单词的输入合法性
            if (Regex.IsMatch(tarword.Text, @"^\s*$"))
            {
                tarword.BackColor = WarningColor;
                return;
            }
            else
            {
                wordinfo.Text = "";
                //查询单词
                if (shanbeidic.Checked)
                {
                    //使用扇贝查词
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://api.shanbay.com/bdc/search/?word=" + tarword.Text);
                    req.Method = "GET";
                    req.ContentType = "text/html;charset=UTF-8";
                    //获取Json数据
                    string json = "";
                    try
                    {
                        StreamReader sr = new StreamReader(req.GetResponse().GetResponseStream(), Encoding.UTF8);
                        json = sr.ReadToEnd();
                    }
                    catch (Exception)
                    {
                        wordinfo.Text = "查询结果获取失败！";
                        return;
                    }
                    //解析Json（Json反序列化）
                    JObject obj = JObject.Parse(json);
                    //根据扇贝API获取解析结果
                    {
                        string status_code = (string)obj["status_code"];
                        if (status_code == "0")
                        {
                            //查词成功
                            string content = (string)obj["data"]["content"];
                            wordinfo.Text += "查询的单词为:" + content + Environment.NewLine;
                            string cn_definition_defn = (string)obj["data"]["cn_definition"]["defn"];
                            wordinfo.Text += "单词的中文释义为：" + Environment.NewLine;
                            wordinfo.Text += cn_definition_defn;
                        }
                        else
                        {
                            //查词失败
                            wordinfo.Text = "查询失败！";
                        }
                    }
                }
            }
        }
         * */

        /*
         * 废弃：该控件已被移除
        private void janeeyre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.shanbay.com/wordbook/116656/");
        }
         * */
    }
}
