// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// The configurations of the domain name.
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public DescribeDcdnDomainConfigsResponseBodyDomainConfigs DomainConfigs { get; set; }
        public class DescribeDcdnDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfig : TeaModel {
                /// <summary>
                /// The ID of the configuration.
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// The configurations of the features.
                /// </summary>
                [NameInMap("FunctionArgs")]
                [Validation(Required=false)]
                public DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeDcdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
                        /// <summary>
                        /// The name of the configuration.
                        /// </summary>
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        /// <summary>
                        /// The value of the configuration.
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
                /// The ID of the advanced condition configuration.
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// The status of the configuration. Valid values:
                /// 
                /// *   **success**: successful
                /// *   **testing**: testing
                /// *   **failed**: The configuration failed.
                /// *   **configuring**: The configuration is in progress.
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
