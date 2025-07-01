// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF518948****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about data flow tasks.</para>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeDataFlowTasksResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeDataFlowTasksResponseBodyTaskInfo : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDataFlowTasksResponseBodyTaskInfoTask> Task { get; set; }
            public class DescribeDataFlowTasksResponseBodyTaskInfoTask : TeaModel {
                /// <summary>
                /// <para>The conflict policy for files with the same name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SKIP_THE_FILE: skips files with the same name.</description></item>
                /// <item><description>KEEP_LATEST: compares the update time and keeps the latest version.</description></item>
                /// <item><description>OVERWRITE_EXISTING: forcibly overwrites the existing file.</description></item>
                /// </list>
                /// 
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
                /// <para>The ID of the data flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dfid-194433a5be3****</para>
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                /// <summary>
                /// <para>The type of data on which operations are performed by the data flow task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Metadata: the metadata of a file, including the timestamp, ownership, and permission information of the file. If you select Metadata, only the metadata of the file is imported. You can only query the file. When you access the file data, the file is loaded from the source storage as required.</description></item>
                /// <item><description>Data: the data blocks of the file.</description></item>
                /// <item><description>MetaAndData: the metadata and data blocks of the file.</description></item>
                /// </list>
                /// <remarks>
                /// <para> CPFS for LINGJUN supports only the MetaAndData type.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Metadata</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The directory in which the data flow task is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path_in_cpfs/</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The directory mapped to the data flow task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path_in_cpfs/</para>
                /// </summary>
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

                /// <summary>
                /// <para>The cause of the task exception.</para>
                /// <remarks>
                /// <para> If this parameter is not returned or the return value is empty, no error occurs.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The directory of the fileset in the CPFS file system.</para>
                /// <para>Limits:</para>
                /// <list type="bullet">
                /// <item><description>The directory must be 2 to 1024 characters in length.</description></item>
                /// <item><description>The directory must be encoded in UTF-8.</description></item>
                /// <item><description>The directory must start and end with a forward slash (/).</description></item>
                /// <item><description>The directory must be a fileset directory in the CPFS file system.</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only CPFS supports this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/a/b/c/</para>
                /// </summary>
                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpfs-099394bd928c****</para>
                /// </summary>
                [NameInMap("FilesystemId")]
                [Validation(Required=false)]
                public string FilesystemId { get; set; }

                /// <summary>
                /// <para>The path of the smart directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/aa/</para>
                /// </summary>
                [NameInMap("FsPath")]
                [Validation(Required=false)]
                public string FsPath { get; set; }

                [NameInMap("Includes")]
                [Validation(Required=false)]
                public string Includes { get; set; }

                /// <summary>
                /// <para>The initiator of the data flow task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>User: The task is initiated by a user.</description></item>
                /// <item><description>System: The task is automatically initiated by CPFS based on the automatic update interval.</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only CPFS supports this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>User</para>
                /// </summary>
                [NameInMap("Originator")]
                [Validation(Required=false)]
                public string Originator { get; set; }

                /// <summary>
                /// <para>The progress of the data flow task. The number of operations that have been performed by the data flow task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public long? Progress { get; set; }

                /// <summary>
                /// <para>The progress of the data flow task.</para>
                /// </summary>
                [NameInMap("ProgressStats")]
                [Validation(Required=false)]
                public DescribeDataFlowTasksResponseBodyTaskInfoTaskProgressStats ProgressStats { get; set; }
                public class DescribeDataFlowTasksResponseBodyTaskInfoTaskProgressStats : TeaModel {
                    /// <summary>
                    /// <para>The actual amount of data for which the data flow task is complete. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131092971520</para>
                    /// </summary>
                    [NameInMap("ActualBytes")]
                    [Validation(Required=false)]
                    public long? ActualBytes { get; set; }

                    /// <summary>
                    /// <para>The actual number of files for which the data flow task is complete.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("ActualFiles")]
                    [Validation(Required=false)]
                    public long? ActualFiles { get; set; }

                    /// <summary>
                    /// <para>The average flow velocity. Unit: bytes/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>342279299</para>
                    /// </summary>
                    [NameInMap("AverageSpeed")]
                    [Validation(Required=false)]
                    public long? AverageSpeed { get; set; }

                    /// <summary>
                    /// <para>The amount of data (including skipped data) for which the data flow task is complete. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131092971520</para>
                    /// </summary>
                    [NameInMap("BytesDone")]
                    [Validation(Required=false)]
                    public long? BytesDone { get; set; }

                    /// <summary>
                    /// <para>The amount of data scanned on the source. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131092971520</para>
                    /// </summary>
                    [NameInMap("BytesTotal")]
                    [Validation(Required=false)]
                    public long? BytesTotal { get; set; }

                    /// <summary>
                    /// <para>The number of files (including skipped files) for which the data flow task is complete.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("FilesDone")]
                    [Validation(Required=false)]
                    public long? FilesDone { get; set; }

                    /// <summary>
                    /// <para>The number of files scanned on the source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("FilesTotal")]
                    [Validation(Required=false)]
                    public long? FilesTotal { get; set; }

                    /// <summary>
                    /// <para>The estimated remaining execution time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>437</para>
                    /// </summary>
                    [NameInMap("RemainTime")]
                    [Validation(Required=false)]
                    public long? RemainTime { get; set; }

                }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The save path of data flow task reports in the CPFS file system.</para>
                /// <list type="bullet">
                /// <item><description>The task reports for a CPFS file system are generated in the <c>.dataflow_report</c> directory of the CPFS file system.</description></item>
                /// <item><description>CPFS for LINGJUN returns an OSS download link for you to download the task reports.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>/path_in_cpfs/reportfile.cvs</para>
                /// </summary>
                [NameInMap("ReportPath")]
                [Validation(Required=false)]
                [Obsolete]
                public string ReportPath { get; set; }

                /// <summary>
                /// <para>The reports.</para>
                /// <remarks>
                /// <para> Streaming tasks do not support reports.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Reports")]
                [Validation(Required=false)]
                public DescribeDataFlowTasksResponseBodyTaskInfoTaskReports Reports { get; set; }
                public class DescribeDataFlowTasksResponseBodyTaskInfoTaskReports : TeaModel {
                    [NameInMap("Report")]
                    [Validation(Required=false)]
                    public List<DescribeDataFlowTasksResponseBodyTaskInfoTaskReportsReport> Report { get; set; }
                    public class DescribeDataFlowTasksResponseBodyTaskInfoTaskReportsReport : TeaModel {
                        /// <summary>
                        /// <para>The name of the report.</para>
                        /// <list type="bullet">
                        /// <item><description><para>CPFS:</para>
                        /// <para>TotalFilesReport: task reports.</para>
                        /// </description></item>
                        /// <item><description><para>CPFS for LINGJUN:</para>
                        /// <list type="bullet">
                        /// <item><description>FailedFilesReport: failed file reports.</description></item>
                        /// <item><description>SkippedFilesReport: skipped file reports.</description></item>
                        /// <item><description>SuccessFilesReport: successful file reports.</description></item>
                        /// </list>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TotalFilesReport</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The report URL.</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                }

                /// <summary>
                /// <para>The access path of the source storage. Format: <c>&lt;storage type&gt;://[&lt;account id&gt;:]&lt;path&gt;</c>.</para>
                /// <para>Parameters:</para>
                /// <list type="bullet">
                /// <item><description><para>storage type: Only Object Storage Service (OSS) is supported.</para>
                /// </description></item>
                /// <item><description><para>account id: the UID of the account of the source storage.</para>
                /// </description></item>
                /// <item><description><para>path: the name of the OSS bucket. Limits:</para>
                /// <list type="bullet">
                /// <item><description>The name can contain only lowercase letters, digits, and hyphens (-). The name must start and end with a lowercase letter or digit.</description></item>
                /// <item><description>The name can be up to 128 characters in length.</description></item>
                /// <item><description>The name must be encoded in UTF-8.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>The OSS bucket must be an existing bucket in the region.</para>
                /// </description></item>
                /// <item><description><para>Only CPFS for LINGJUN V2.6.0 and later support the account id parameter.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket1</para>
                /// </summary>
                [NameInMap("SourceStorage")]
                [Validation(Required=false)]
                public string SourceStorage { get; set; }

                /// <summary>
                /// <para>The time when the task started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-04 18:27:35</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the data flow task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The data flow task has been created and has not started.</description></item>
                /// <item><description>Executing: The data flow task is being executed.</description></item>
                /// <item><description>Failed: The data flow task failed to be executed. You can view the cause of the failure in the data flow task report.</description></item>
                /// <item><description>Completed: The data flow task is completed. You can check that all the files have been correctly transferred in the data flow task report.</description></item>
                /// <item><description>Canceled: The data flow task is canceled and is not completed.</description></item>
                /// <item><description>Canceling: The data flow task is being canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the data flow task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Import: imports data stored in the source storage to a CPFS file system.</description></item>
                /// <item><description>Export: exports specified data from a CPFS file system to the source storage.</description></item>
                /// <item><description>StreamImport: imports the specified data from the source storage to a CPFS file system in streaming mode.</description></item>
                /// <item><description>StreamExport: exports specified data from a CPFS file system to the source storage in streaming mode.</description></item>
                /// <item><description>Evict: releases the data blocks of a file in a CPFS file system. After the eviction, only the metadata of the file is retained in the CPFS file system. You can still query the file. However, the data blocks of the file are cleared and do not occupy the storage space in the CPFS file system. When you access the file data, the file is loaded from the source storage as required.</description></item>
                /// <item><description>Inventory: obtains the inventory list managed by a data flow from the CPFS file system, providing the cache status of inventories in the data flow.</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only CPFS for LINGJUN V2.6.0 and later support StreamImport and StreamExport.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Import</para>
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                /// <summary>
                /// <para>The ID of the data flow task.</para>
                /// 
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
