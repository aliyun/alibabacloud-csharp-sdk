// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateDownloadJobRequest : TeaModel {
        /// <summary>
        /// <para>The download configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public CreateDownloadJobRequestConfiguration Configuration { get; set; }
        public class CreateDownloadJobRequestConfiguration : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow downloading inexact results. Valid values: true, false.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowInComplete")]
            [Validation(Required=false)]
            public bool? AllowInComplete { get; set; }

            /// <summary>
            /// <para>The start timestamp, in seconds.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1722406260</para>
            /// </summary>
            [NameInMap("fromTime")]
            [Validation(Required=false)]
            public long? FromTime { get; set; }

            /// <summary>
            /// <para>The source Logstore.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable PowerSQL. Valid values: true, false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("powerSql")]
            [Validation(Required=false)]
            public bool? PowerSql { get; set; }

            /// <summary>
            /// <para>The query statement.</para>
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
            /// <para>The export configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public CreateDownloadJobRequestConfigurationSink Sink { get; set; }
            public class CreateDownloadJobRequestConfigurationSink : TeaModel {
                /// <summary>
                /// <para>The OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-test-bucket</para>
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The compression format. Valid values: zstd, lz4, gzip, none.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("compressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// <para>The download file format. Valid values: csv, json.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>csv</para>
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The path prefix in the OSS bucket to which data is downloaded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>download/</para>
                /// </summary>
                [NameInMap("prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role used for the download.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::0123456789:role/aliyunlogdefaultrole</para>
                /// </summary>
                [NameInMap("roleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// <para>Fixed value: AliyunOSS.</para>
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
            /// <para>The end timestamp, in seconds.</para>
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
        /// <para>The description of the log download task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Log download task</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>download-123456789</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The job name. The following naming rules apply:</para>
        /// <para>Job names must be unique within the same project.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or digit.</description></item>
        /// <item><description>The name must be 2 to 64 characters in length.</description></item>
        /// </list>
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
