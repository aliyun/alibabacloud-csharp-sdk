// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFlowTopResourceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of the top 10 protected objects that receive requests.
        /// </summary>
        [NameInMap("RuleHitsTopResource")]
        [Validation(Required=false)]
        public List<DescribeFlowTopResourceResponseBodyRuleHitsTopResource> RuleHitsTopResource { get; set; }
        public class DescribeFlowTopResourceResponseBodyRuleHitsTopResource : TeaModel {
            /// <summary>
            /// The total number of requests received by the protected object in a specified time range.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The protected object.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

    }

}
