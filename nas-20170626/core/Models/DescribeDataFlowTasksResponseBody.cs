// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF518948****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeDataFlowTasksResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeDataFlowTasksResponseBodyTaskInfo : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDataFlowTasksResponseBodyTaskInfoTask> Task { get; set; }
            public class DescribeDataFlowTasksResponseBodyTaskInfoTask : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>KEEP_LATEST</para>
                /// </summary>
                [NameInMap("ConflictPolicy")]
                [Validation(Required=false)]
                public string ConflictPolicy { get; set; }

                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-04 18:27:35</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dfid-194433a5be3****</para>
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                /// <summary>
                /// <para>null Valid values:</para>
                /// <list type="bullet">
                /// <item><description>null null</description></item>
                /// <item><description>null</description></item>
                /// <item><description>null</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Metadata</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                [NameInMap("DstDirectory")]
                [Validation(Required=false)]
                public string DstDirectory { get; set; }

                /// <summary>
                /// <para>The time when the task ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-04 18:27:35</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// <item><description></description></item>
                /// <item><description></description></item>
                /// <item><description>null</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>/a/b/c/</para>
                /// </summary>
                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cpfs-099394bd928c****</para>
                /// </summary>
                [NameInMap("FilesystemId")]
                [Validation(Required=false)]
                public string FilesystemId { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>/aa/</para>
                /// </summary>
                [NameInMap("FsPath")]
                [Validation(Required=false)]
                public string FsPath { get; set; }

                /// <summary>
                /// <para>null Valid values:</para>
                /// <list type="bullet">
                /// <item><description>null</description></item>
                /// <item><description>null</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>User</para>
                /// </summary>
                [NameInMap("Originator")]
                [Validation(Required=false)]
                public string Originator { get; set; }

                /// <summary>
                /// <para>null null</para>
                /// 
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public long? Progress { get; set; }

                [NameInMap("ProgressStats")]
                [Validation(Required=false)]
                public DescribeDataFlowTasksResponseBodyTaskInfoTaskProgressStats ProgressStats { get; set; }
                public class DescribeDataFlowTasksResponseBodyTaskInfoTaskProgressStats : TeaModel {
                    [NameInMap("ActualBytes")]
                    [Validation(Required=false)]
                    public long? ActualBytes { get; set; }

                    [NameInMap("ActualFiles")]
                    [Validation(Required=false)]
                    public long? ActualFiles { get; set; }

                    [NameInMap("AverageSpeed")]
                    [Validation(Required=false)]
                    public long? AverageSpeed { get; set; }

                    [NameInMap("BytesDone")]
                    [Validation(Required=false)]
                    public long? BytesDone { get; set; }

                    [NameInMap("BytesTotal")]
                    [Validation(Required=false)]
                    public long? BytesTotal { get; set; }

                    [NameInMap("FilesDone")]
                    [Validation(Required=false)]
                    public long? FilesDone { get; set; }

                    [NameInMap("FilesTotal")]
                    [Validation(Required=false)]
                    public long? FilesTotal { get; set; }

                    [NameInMap("RemainTime")]
                    [Validation(Required=false)]
                    public long? RemainTime { get; set; }

                }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>null</para>
                /// <para>null``</para>
                /// <para>Limits:</para>
                /// <list type="bullet">
                /// <item><description>null</description></item>
                /// <item><description>The name must be encoded in UTF-8.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>/path_in_cpfs/reportfile.cvs</para>
                /// </summary>
                [NameInMap("ReportPath")]
                [Validation(Required=false)]
                [Obsolete]
                public string ReportPath { get; set; }

                [NameInMap("Reports")]
                [Validation(Required=false)]
                public DescribeDataFlowTasksResponseBodyTaskInfoTaskReports Reports { get; set; }
                public class DescribeDataFlowTasksResponseBodyTaskInfoTaskReports : TeaModel {
                    [NameInMap("Report")]
                    [Validation(Required=false)]
                    public List<DescribeDataFlowTasksResponseBodyTaskInfoTaskReportsReport> Report { get; set; }
                    public class DescribeDataFlowTasksResponseBodyTaskInfoTaskReportsReport : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                }

                /// <summary>
                /// <para>://</para>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// <item><description><list type="bullet">
                /// <item><description></description></item>
                /// <item><description></description></item>
                /// <item><description></description></item>
                /// <item><description><a href="http://https://%E3%80%82"></a></description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// <para>**</para>
                /// <hr>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket1</para>
                /// </summary>
                [NameInMap("SourceStorage")]
                [Validation(Required=false)]
                public string SourceStorage { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-04 18:27:35</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>null Valid values:</para>
                /// <list type="bullet">
                /// <item><description>null</description></item>
                /// <item><description>null</description></item>
                /// <item><description>null</description></item>
                /// <item><description>null</description></item>
                /// <item><description>null</description></item>
                /// <item><description>null</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>null Valid values:</para>
                /// <list type="bullet">
                /// <item><description>null</description></item>
                /// <item><description>null</description></item>
                /// <item><description>null null</description></item>
                /// <item><description>null</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Import</para>
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>taskId-12345678</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

    }

}
