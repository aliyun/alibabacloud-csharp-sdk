// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class CreateDownloadResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBS.ParamIsInValid</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the download task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDownloadResponseBodyData Data { get; set; }
        public class CreateDownloadResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The point in time of the backup set if the task is used to download a backup set at a specific point in time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1661373070000</para>
            /// </summary>
            [NameInMap("BackupSetTime")]
            [Validation(Required=false)]
            public long? BackupSetTime { get; set; }

            /// <summary>
            /// <para>The ID of the full backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>146005****</para>
            /// </summary>
            [NameInMap("BakSetId")]
            [Validation(Required=false)]
            public string BakSetId { get; set; }

            /// <summary>
            /// <para>The database and table information that is returned if databases and tables are filtered by the download task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb</para>
            /// </summary>
            [NameInMap("DbList")]
            [Validation(Required=false)]
            public string DbList { get; set; }

            /// <summary>
            /// <para>The state of the download task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>initializing: The download task was being initialized.</description></item>
            /// <item><description>queuing: The download task was queuing.</description></item>
            /// <item><description>running: The download task was running.</description></item>
            /// <item><description>failed: The download task failed.</description></item>
            /// <item><description>finished: The download task was complete.</description></item>
            /// <item><description>expired: The download task expired.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the TargetType parameter is set to URL, the download task expires in three days after the task is complete.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>initializing</para>
            /// </summary>
            [NameInMap("DownloadStatus")]
            [Validation(Required=false)]
            public string DownloadStatus { get; set; }

            /// <summary>
            /// <para>The size of the downloaded data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExportDataSize")]
            [Validation(Required=false)]
            public long? ExportDataSize { get; set; }

            /// <summary>
            /// <para>The format to which the downloaded data is converted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSV</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The time when the download task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1661940917570</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The size of the processed data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ImportDataSize")]
            [Validation(Required=false)]
            public long? ImportDataSize { get; set; }

            /// <summary>
            /// <para>The number of tables that have been downloaded and the total number of tables to be downloaded.</para>
            /// <remarks>
            /// <para>If the task is in the preparation stage, 0/0 is returned.</para>
            /// </remarks>
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
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// <para>The destination path to which the backup set is downloaded.</para>
            /// <remarks>
            /// <para> This parameter is returned if the value of <b>TargetType is OSS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_db/path</para>
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// <para>The type of the destination to which the backup set is downloaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The ID of the download task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dt-qxnsfq5s****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBS.ParamIsInValid</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>formatType can not be empty</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>formatType can not be empty</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A08F908D-2C35-583F-93C1-ED80753F****</para>
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
