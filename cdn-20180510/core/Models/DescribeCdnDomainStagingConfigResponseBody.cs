// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainStagingConfigResponseBody : TeaModel {
        /// <summary>
        /// The domain name configurations.
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeCdnDomainStagingConfigResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeCdnDomainStagingConfigResponseBodyDomainConfigs : TeaModel {
            /// <summary>
            /// The configuration ID.
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// The description of each feature.
            /// </summary>
            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeCdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeCdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs : TeaModel {
                /// <summary>
                /// The configuration name.
                /// </summary>
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                /// <summary>
                /// The configuration value.
                /// </summary>
                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

            /// <summary>
            /// The feature name.
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// The rule condition ID. This parameter is optional. To create a rule condition, you can configure the **condition** feature that is described in the [Parameters for configuring features for domain names](https://help.aliyun.com/document_detail/388460.html) topic. A rule condition can identify parameters that are included in requests and filter requests based on the identified parameters. Each rule condition has a [ConfigId](https://help.aliyun.com/document_detail/388994.html). You can reference ConfigId instead of ParentId in other features. This way, you can combine rule conditions and features for flexible configurations. For more information, see [BatchSetCdnDomainConfig](https://help.aliyun.com/document_detail/90915.html) or ParentId configuration example in this topic.
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// The configuration status. Valid values:
            /// 
            /// *   **testing**
            /// *   **configuring**
            /// *   **success**
            /// *   **failed**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
