// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListDownloadJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of log download tasks returned in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of log download tasks.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<ListDownloadJobsResponseBodyResults> Results { get; set; }
        public class ListDownloadJobsResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The download configuration.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public ListDownloadJobsResponseBodyResultsConfiguration Configuration { get; set; }
            public class ListDownloadJobsResponseBodyResultsConfiguration : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow downloading incomplete results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("allowInComplete")]
                [Validation(Required=false)]
                public string AllowInComplete { get; set; }

                /// <summary>
                /// <para>The start timestamp, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1722409260</para>
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
                /// <para>Indicates whether PowerSQL is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("powerSql")]
                [Validation(Required=false)]
                public bool? PowerSql { get; set; }

                /// <summary>
                /// <para>The query statement.</para>
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
                /// <para>The log download task configuration.</para>
                /// </summary>
                [NameInMap("sink")]
                [Validation(Required=false)]
                public ListDownloadJobsResponseBodyResultsConfigurationSink Sink { get; set; }
                public class ListDownloadJobsResponseBodyResultsConfigurationSink : TeaModel {
                    /// <summary>
                    /// <para>The OSS bucket.</para>
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
                    /// <para>The download file format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>csv</para>
                    /// </summary>
                    [NameInMap("contentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The file prefix used when downloading to the user\&quot;s OSS bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>download/</para>
                    /// </summary>
                    [NameInMap("prefix")]
                    [Validation(Required=false)]
                    public string Prefix { get; set; }

                    /// <summary>
                    /// <para>The ARN of the RAM role used for the download.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::123456:role/aliyunlogimportossrole</para>
                    /// </summary>
                    [NameInMap("roleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                    /// <summary>
                    /// <para>Fixed value: AliyunOSS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunOSS</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The end timestamp, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1722411060</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The creation time of the log download task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722411060</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the log download task.</para>
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
            /// <para>download-123</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The execution details.</para>
            /// </summary>
            [NameInMap("executionDetails")]
            [Validation(Required=false)]
            public ListDownloadJobsResponseBodyResultsExecutionDetails ExecutionDetails { get; set; }
            public class ListDownloadJobsResponseBodyResultsExecutionDetails : TeaModel {
                /// <summary>
                /// <para>The file ETag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ETASFGASDASQWDasd</para>
                /// </summary>
                [NameInMap("checkSum")]
                [Validation(Required=false)]
                public string CheckSum { get; set; }

                /// <summary>
                /// <para>The download error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>timeout</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The download execution time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("executeTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The download result link.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://sls-downloaded-xxxx.csv.gzip?Expiresxxx">https://sls-downloaded-xxxx.csv.gzip?Expiresxxx</a></para>
                /// </summary>
                [NameInMap("filePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                /// <summary>
                /// <para>The download file size.</para>
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
                /// <para>The notification information.</para>
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
            /// <para>The name of the log download task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>download-123</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STARTING、RUNNING、SUCCEEDED、ERROR</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
