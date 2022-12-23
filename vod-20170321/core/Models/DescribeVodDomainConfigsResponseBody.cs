// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// The configurations of the domain name.
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public DescribeVodDomainConfigsResponseBodyDomainConfigs DomainConfigs { get; set; }
        public class DescribeVodDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public List<DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfig : TeaModel {
                /// <summary>
                /// The ID of the configuration.
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// The parameters of each feature.
                /// </summary>
                [NameInMap("FunctionArgs")]
                [Validation(Required=false)]
                public DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
                        /// <summary>
                        /// The name of the parameter.
                        /// </summary>
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        /// <summary>
                        /// The value of the parameter.
                        /// </summary>
                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }

                /// <summary>
                /// The name of the function.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// The status of the configuration. Valid values:
                /// - **success**
                /// - **testing**
                /// - **failed**
                /// - **configuring**
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
