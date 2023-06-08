// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserConfigsResponseBody : TeaModel {
        /// <summary>
        /// The configurations of the specified feature.
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public DescribeUserConfigsResponseBodyConfigs Configs { get; set; }
        public class DescribeUserConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// The configurations of Object Storage Service (OSS).
            /// </summary>
            [NameInMap("OssLogConfig")]
            [Validation(Required=false)]
            public DescribeUserConfigsResponseBodyConfigsOssLogConfig OssLogConfig { get; set; }
            public class DescribeUserConfigsResponseBodyConfigsOssLogConfig : TeaModel {
                /// <summary>
                /// The name of the bucket.
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// Indicates whether the OSS bucket is enabled.
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                /// <summary>
                /// The prefix.
                /// </summary>
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

            }

            /// <summary>
            /// The configurations of Web Application Firewall (WAF).
            /// </summary>
            [NameInMap("WafConfig")]
            [Validation(Required=false)]
            public DescribeUserConfigsResponseBodyConfigsWafConfig WafConfig { get; set; }
            public class DescribeUserConfigsResponseBodyConfigsWafConfig : TeaModel {
                /// <summary>
                /// Indicates whether WAF is enabled.
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
