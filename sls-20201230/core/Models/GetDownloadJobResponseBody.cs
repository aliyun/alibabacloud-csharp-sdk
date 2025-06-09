// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetDownloadJobResponseBody : TeaModel {
        /// <summary>
        /// <para>下载配置</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public GetDownloadJobResponseBodyConfiguration Configuration { get; set; }
        public class GetDownloadJobResponseBodyConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("allowInComplete")]
            [Validation(Required=false)]
            public bool? AllowInComplete { get; set; }

            /// <summary>
            /// <para>起点时间戳（精确到秒）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722409860</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <para>源logstore</para>
            /// 
            /// <b>Example:</b>
            /// <para>ali-test-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>是否启用powerSql</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("powerSql")]
            [Validation(Required=false)]
            public bool? PowerSql { get; set; }

            /// <summary>
            /// <para>查询语句</para>
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
            /// <para>导出配置</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public GetDownloadJobResponseBodyConfigurationSink Sink { get; set; }
            public class GetDownloadJobResponseBodyConfigurationSink : TeaModel {
                /// <summary>
                /// <para>对象存储桶</para>
                /// 
                /// <b>Example:</b>
                /// <para>ali-test-oss-bucket</para>
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>压缩格式</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("compressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// <para>下载文件格式</para>
                /// 
                /// <b>Example:</b>
                /// <para>csv</para>
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>download/</para>
                /// </summary>
                [NameInMap("prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// <para>下载使用roleArn</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::0123456789:role/aliyunlogdefaultrole</para>
                /// </summary>
                [NameInMap("roleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AliyunOSS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>结束时间戳（精确到秒）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722411060</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

        }

        /// <summary>
        /// <para>代表创建时间的资源属性字段</para>
        /// 
        /// <b>Example:</b>
        /// <para>1722411060</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>任务描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>a download job</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>任务显示名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>download-123456</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>任务执行细节</para>
        /// </summary>
        [NameInMap("executionDetails")]
        [Validation(Required=false)]
        public GetDownloadJobResponseBodyExecutionDetails ExecutionDetails { get; set; }
        public class GetDownloadJobResponseBodyExecutionDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>EXSFGSDASDASDG123ASD</para>
            /// </summary>
            [NameInMap("checkSum")]
            [Validation(Required=false)]
            public string CheckSum { get; set; }

            /// <summary>
            /// <para>下载错误信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>timeout</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>下载执行时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("executeTime")]
            [Validation(Required=false)]
            public long? ExecuteTime { get; set; }

            /// <summary>
            /// <para>下载结果链接</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.csv.zst?xxx">https://xxx.csv.zst?xxx</a></para>
            /// </summary>
            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>下载文件大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>下载日志条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("logCount")]
            [Validation(Required=false)]
            public long? LogCount { get; set; }

            [NameInMap("notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }

            /// <summary>
            /// <para>下载进度</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

        }

        /// <summary>
        /// <para>代表资源名称的资源属性字段</para>
        /// 
        /// <b>Example:</b>
        /// <para>download-123</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status of the log download task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
