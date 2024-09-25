// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateTrafficMirrorFilterRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of outbound rules.</para>
        /// </summary>
        [NameInMap("EgressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRulesResponseBodyEgressRules> EgressRules { get; set; }
        public class CreateTrafficMirrorFilterRulesResponseBodyEgressRules : TeaModel {
            /// <summary>
            /// <para>The ID of the outbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tmr-j6cok23ugp53eeib5****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The list of inbound rules.</para>
        /// </summary>
        [NameInMap("IngressRules")]
        [Validation(Required=false)]
        public List<CreateTrafficMirrorFilterRulesResponseBodyIngressRules> IngressRules { get; set; }
        public class CreateTrafficMirrorFilterRulesResponseBodyIngressRules : TeaModel {
            /// <summary>
            /// <para>The ID of the inbound rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tmr-j6c6rtallo51ouzv3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07F272E2-6AD5-433A-8207-A607C76F1676</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
