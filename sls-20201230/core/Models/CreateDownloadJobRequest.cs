// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateDownloadJobRequest : TeaModel {
        /// <summary>
        /// <para>下载配置</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public CreateDownloadJobRequestConfiguration Configuration { get; set; }
        public class CreateDownloadJobRequestConfiguration : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowInComplete")]
            [Validation(Required=false)]
            public bool? AllowInComplete { get; set; }

            /// <summary>
            /// <para>起点时间戳（精确到秒）</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722406260</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <para>源logstore</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>是否启用powerSql</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("powerSql")]
            [Validation(Required=false)]
            public bool? PowerSql { get; set; }

            /// <summary>
            /// <para>查询语句</para>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public CreateDownloadJobRequestConfigurationSink Sink { get; set; }
            public class CreateDownloadJobRequestConfigurationSink : TeaModel {
                /// <summary>
                /// <para>对象存储桶</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-test-bucket</para>
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>压缩格式</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("compressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// <para>下载文件格式</para>
                /// <para>This parameter is required.</para>
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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunOSS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>结束时间戳（精确到秒）</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722409860</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

        }

        /// <summary>
        /// <para>任务描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>任务显示名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>download-123456789</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>代表资源名称的资源属性字段</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>download-123</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
