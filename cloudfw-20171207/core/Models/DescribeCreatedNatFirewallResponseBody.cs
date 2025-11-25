// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeCreatedNatFirewallResponseBody : TeaModel {
        [NameInMap("CreatedNatFirewalls")]
        [Validation(Required=false)]
        public List<DescribeCreatedNatFirewallResponseBodyCreatedNatFirewalls> CreatedNatFirewalls { get; set; }
        public class DescribeCreatedNatFirewallResponseBodyCreatedNatFirewalls : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cfw-adk2ad45sf4t8****</para>
            /// </summary>
            [NameInMap("NatFirewallId")]
            [Validation(Required=false)]
            public string NatFirewallId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ngw-uf6i0zkjtz4t2sttf****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ngw-text</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>072B5287-8A85-529E-BD47-F8AC2DB1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
