// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// The configurations of the domain name.
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public DescribeCdnDomainConfigsResponseBodyDomainConfigs DomainConfigs { get; set; }
        public class DescribeCdnDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public List<DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfig : TeaModel {
                /// <summary>
                /// The ID of the configuration.
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// The configuration of each feature.
                /// </summary>
                [NameInMap("FunctionArgs")]
                [Validation(Required=false)]
                public DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
                        /// <summary>
                        /// The parameter name, which is the configuration item of **functionName**. You can configure multiple configuration items.
                        /// </summary>
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        /// <summary>
                        /// The parameter value, which is the value of the configuration item of **functionName**.
                        /// </summary>
                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }

                /// <summary>
                /// The name of the feature.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// The ID of the rule condition. This parameter is optional.
                /// 
                /// To create a rule condition, you can configure the **condition** feature that is described in the [Parameters for configuring features for domain names](https://help.aliyun.com/document_detail/388460.html) topic. A rule condition can identify parameters that are included in requests and filter requests based on the identified parameters. Each rule condition has a [ConfigId](https://help.aliyun.com/document_detail/388994.html). You can use ConfigId as ParentId that is referenced by other features. This way, you can combine rule conditions and features for flexible configurations.
                /// 
                /// For more information, see [BatchSetCdnDomainConfig](https://help.aliyun.com/document_detail/90915.html) or ParentId configuration example in this topic.
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// The status of the configuration. Valid values:
                /// 
                /// *   **success**
                /// *   **testing**
                /// *   **failed**
                /// *   **configuring**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
