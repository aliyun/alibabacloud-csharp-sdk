// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the specified feature.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public DescribeUserConfigsResponseBodyConfigs Configs { get; set; }
        public class DescribeUserConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The configurations of Object Storage Service (OSS).</para>
            /// </summary>
            [NameInMap("OssLogConfig")]
            [Validation(Required=false)]
            public DescribeUserConfigsResponseBodyConfigsOssLogConfig OssLogConfig { get; set; }
            public class DescribeUserConfigsResponseBodyConfigsOssLogConfig : TeaModel {
                /// <summary>
                /// <para>The name of the bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Buckettest</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>Indicates whether the OSS bucket is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// <para>The prefix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

            }

            /// <summary>
            /// <para>The configurations of Web Application Firewall (WAF).</para>
            /// </summary>
            [NameInMap("WafConfig")]
            [Validation(Required=false)]
            public DescribeUserConfigsResponseBodyConfigsWafConfig WafConfig { get; set; }
            public class DescribeUserConfigsResponseBodyConfigsWafConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether WAF is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BCC7BAA-ACBE-45E5-83F0-98BF7E693E84</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
