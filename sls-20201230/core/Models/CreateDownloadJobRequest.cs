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
            /// <para>Specifies whether to allow the download of incomplete results. Valid values: \<c>true\\</c> and \<c>false\\</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowInComplete")]
            [Validation(Required=false)]
            public bool? AllowInComplete { get; set; }

            /// <summary>
            /// <para>The start time. This is a UNIX timestamp that is accurate to the second.</para>
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
            /// <para>Specifies whether to enable PowerSQL. Valid values: \<c>true\\</c> and \<c>false\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("powerSql")]
            [Validation(Required=false)]
            public bool? PowerSql { get; set; }

            /// <summary>
            /// <para>The search statement.</para>
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
                /// <para>The destination Object Storage Service (OSS) bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-test-bucket</para>
                /// </summary>
                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The compression format of the file. Valid values: \<c>zstd\\</c>, \<c>lz4\\</c>, \<c>gzip\\</c>, and \<c>none\\</c>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("compressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// <para>The format of the downloaded file. Valid values: \<c>csv\\</c> and \<c>json\\</c>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>csv</para>
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The prefix of the path in the destination OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>download/</para>
                /// </summary>
                [NameInMap("prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role to use for the download.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::0123456789:role/aliyunlogdefaultrole</para>
                /// </summary>
                [NameInMap("roleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// <para>The type of the destination. Set the value to \<c>AliyunOSS\\</c>.</para>
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
            /// <para>The end time. This is a UNIX timestamp that is accurate to the second.</para>
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
        /// <para>The name of the job. The name must meet the following requirements:</para>
        /// <para>The job name must be unique within a project.</para>
        /// <list type="bullet">
        /// <item><description><para>It can contain only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>The name must be 2 to 64 characters in length.</para>
        /// </description></item>
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
