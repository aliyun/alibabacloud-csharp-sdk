// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetDownloadJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The download configuration.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public GetDownloadJobResponseBodyConfiguration Configuration { get; set; }
        public class GetDownloadJobResponseBodyConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow downloading incomplete data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("allowInComplete")]
            [Validation(Required=false)]
            public bool? AllowInComplete { get; set; }

            /// <summary>
            /// <para>The start time of the download task. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722409860</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <para>The source Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ali-test-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable PowerSQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("powerSql")]
            [Validation(Required=false)]
            public bool? PowerSql { get; set; }

            /// <summary>
            /// <para>The search statement.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description>| select *</description></item>
            /// </list>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The export configuration.</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public GetDownloadJobResponseBodyConfigurationSink Sink { get; set; }
            public class GetDownloadJobResponseBodyConfigurationSink : TeaModel {
                /// <summary>
                /// <para>The Object Storage Service (OSS) bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ali-test-oss-bucket</para>
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The compression format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("compressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// <para>The file format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>csv</para>
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The prefix of the file that is saved to the bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>download/</para>
                /// </summary>
                [NameInMap("prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role that is used for the download.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::0123456789:role/aliyunlogdefaultrole</para>
                /// </summary>
                [NameInMap("roleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// <para>The value is fixed to AliyunOSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunOSS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The end time of the download task. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722411060</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

        }

        /// <summary>
        /// <para>The time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1722411060</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a download job</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>download-123456</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The execution details.</para>
        /// </summary>
        [NameInMap("executionDetails")]
        [Validation(Required=false)]
        public GetDownloadJobResponseBodyExecutionDetails ExecutionDetails { get; set; }
        public class GetDownloadJobResponseBodyExecutionDetails : TeaModel {
            /// <summary>
            /// <para>The ETag of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXSFGSDASDASDG123ASD</para>
            /// </summary>
            [NameInMap("checkSum")]
            [Validation(Required=false)]
            public string CheckSum { get; set; }

            /// <summary>
            /// <para>The error message if the download fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>timeout</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The duration of the download task in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("executeTime")]
            [Validation(Required=false)]
            public long? ExecuteTime { get; set; }

            /// <summary>
            /// <para>The URL of the download result.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.csv.zst?xxx">https://xxx.csv.zst?xxx</a></para>
            /// </summary>
            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The size of the downloaded file in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The number of downloaded log entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("logCount")]
            [Validation(Required=false)]
            public long? LogCount { get; set; }

            /// <summary>
            /// <para>Notification text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }

            /// <summary>
            /// <para>The download progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

        }

        /// <summary>
        /// <para>The name of the download task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>download-123</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status of the download task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STARTING、RUNNING、SUCCEEDED、ERROR</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
