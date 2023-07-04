// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateTrafficMirrorFilterRulesResponseBody : TeaModel {
        [NameInMap("EgressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRulesResponseBodyEgressRules> EgressRules { get; set; }
        public class CreateTrafficMirrorFilterRulesResponseBodyEgressRules : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// The list of outbound rules.
        /// </summary>
        [NameInMap("IngressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRulesResponseBodyIngressRules> IngressRules { get; set; }
        public class CreateTrafficMirrorFilterRulesResponseBodyIngressRules : TeaModel {
            /// <summary>
            /// The ID of the outbound rule.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// The ID of the inbound rule.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
