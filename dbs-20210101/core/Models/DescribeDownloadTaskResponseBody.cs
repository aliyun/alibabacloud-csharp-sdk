// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeDownloadTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBS.InternalError</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the tasks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDownloadTaskResponseBodyData Data { get; set; }
        public class DescribeDownloadTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the task.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public DescribeDownloadTaskResponseBodyDataContent Content { get; set; }
            public class DescribeDownloadTaskResponseBodyDataContent : TeaModel {
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<DescribeDownloadTaskResponseBodyDataContentList> List { get; set; }
                public class DescribeDownloadTaskResponseBodyDataContentList : TeaModel {
                    /// <summary>
                    /// <para>The point in time of the backup set if the task is used to download a backup set at a specific point in time. The value is a timestamp of the LONG type. Unit: millisecond.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1663162216000</para>
                    /// </summary>
                    [NameInMap("BackupSetTime")]
                    [Validation(Required=false)]
                    public string BackupSetTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the full backup set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>148261****</para>
                    /// </summary>
                    [NameInMap("BakSetId")]
                    [Validation(Required=false)]
                    public string BakSetId { get; set; }

                    /// <summary>
                    /// <para>The details of the databases.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[dbtest]</para>
                    /// </summary>
                    [NameInMap("DbList")]
                    [Validation(Required=false)]
                    public string DbList { get; set; }

                    /// <summary>
                    /// <para>The status of the download task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Initializing</b>: The download task is being initialized.</description></item>
                    /// <item><description><b>queuing</b>: The download task is queuing.</description></item>
                    /// <item><description><b>running</b>: The download task is running.</description></item>
                    /// <item><description><b>failed</b>: The download task fails.</description></item>
                    /// <item><description><b>finished</b>: The download task is complete.</description></item>
                    /// <item><description><b>expired</b>: The download task expires.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>queueing</para>
                    /// </summary>
                    [NameInMap("DownloadStatus")]
                    [Validation(Required=false)]
                    public string DownloadStatus { get; set; }

                    /// <summary>
                    /// <para>The amount of output data. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExportDataSize")]
                    [Validation(Required=false)]
                    public string ExportDataSize { get; set; }

                    /// <summary>
                    /// <para>The format to which the downloaded backup set is converted. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>csv</b></description></item>
                    /// <item><description><b>SQL</b></description></item>
                    /// <item><description><b>Parquet</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>csv</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The time when the download task was created. The value is a timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1663321957000</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The amount of data that is processed. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ImportDataSize")]
                    [Validation(Required=false)]
                    public string ImportDataSize { get; set; }

                    /// <summary>
                    /// <para>The number of tables that have been downloaded and the total number of tables to be downloaded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0/0</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    /// <summary>
                    /// <para>The ID of the region in which the instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionCode")]
                    [Validation(Required=false)]
                    public string RegionCode { get; set; }

                    /// <summary>
                    /// <para>The destination path to which the data is downloaded if the value of <b>TargetType is OSS</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_db/path</para>
                    /// </summary>
                    [NameInMap("TargetPath")]
                    [Validation(Required=false)]
                    public string TargetPath { get; set; }

                    /// <summary>
                    /// <para>The type of the method in which the backup set is downloaded. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>OSS</b></description></item>
                    /// <item><description><b>URL</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>URL</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                    /// <summary>
                    /// <para>The download task ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dt-qxntlvgu****</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

            }

            /// <summary>
            /// <para>The extra description of the download tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbtest</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The page number of the returned page. The value must be an integer that is greater than 0. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of full backup tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of returned pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBS.InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceName can not be empty</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceName can not be empty</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D285EB9-A443-592D-9F3D-A888FAC3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
