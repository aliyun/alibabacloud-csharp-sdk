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
                /// The configuration ID.
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// The feature parameters.
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
                        /// The parameter name.
                        /// </summary>
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        /// <summary>
                        /// The parameter value.
                        /// </summary>
                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }

                /// <summary>
                /// The feature name.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// The configuration status. Valid values:
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
