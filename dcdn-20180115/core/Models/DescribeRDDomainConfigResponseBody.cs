// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRDDomainConfigResponseBody : TeaModel {
        /// <summary>
        /// The configuration of the domain name.
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeRDDomainConfigResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeRDDomainConfigResponseBodyDomainConfigs : TeaModel {
            /// <summary>
            /// The ID of the configuration.
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// The configurations of the features.
            /// </summary>
            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeRDDomainConfigResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeRDDomainConfigResponseBodyDomainConfigsFunctionArgs : TeaModel {
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

            /// <summary>
            /// The name of the feature.
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
            /// The status. Valid values:
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
