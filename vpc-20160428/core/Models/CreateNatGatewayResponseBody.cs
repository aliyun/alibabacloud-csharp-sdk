// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of DNAT entries.</para>
        /// </summary>
        [NameInMap("ForwardTableIds")]
        [Validation(Required=false)]
        public CreateNatGatewayResponseBodyForwardTableIds ForwardTableIds { get; set; }
        public class CreateNatGatewayResponseBodyForwardTableIds : TeaModel {
            [NameInMap("ForwardTableId")]
            [Validation(Required=false)]
            public List<string> ForwardTableId { get; set; }

        }

        /// <summary>
        /// <para>A list of FULLNAT entries.</para>
        /// </summary>
        [NameInMap("FullNatTableIds")]
        [Validation(Required=false)]
        public CreateNatGatewayResponseBodyFullNatTableIds FullNatTableIds { get; set; }
        public class CreateNatGatewayResponseBodyFullNatTableIds : TeaModel {
            [NameInMap("FullNatTableId")]
            [Validation(Required=false)]
            public List<string> FullNatTableId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-112za33e4****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2315DEB7-5E92-423A-91F7-4C1EC9AD97C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of SNAT entries.</para>
        /// </summary>
        [NameInMap("SnatTableIds")]
        [Validation(Required=false)]
        public CreateNatGatewayResponseBodySnatTableIds SnatTableIds { get; set; }
        public class CreateNatGatewayResponseBodySnatTableIds : TeaModel {
            [NameInMap("SnatTableId")]
            [Validation(Required=false)]
            public List<string> SnatTableId { get; set; }

        }

    }

}
