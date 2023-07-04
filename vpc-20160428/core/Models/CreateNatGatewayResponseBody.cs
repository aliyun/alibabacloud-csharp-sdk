// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatGatewayResponseBody : TeaModel {
        /// <summary>
        /// The list of DNAT entries.
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
        /// The list of FULLNAT entries.
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
        /// The ID of the NAT gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of SNAT entries.
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
