// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatIpCidrResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the NAT CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcnatcidr-gw8lhqtvdn4qnea****</para>
        /// </summary>
        [NameInMap("NatIpCidrId")]
        [Validation(Required=false)]
        public string NatIpCidrId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7021BEB1-210F-48A9-AB82-BE9A9110BB89</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
