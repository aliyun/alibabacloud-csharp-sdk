// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouterInterfaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The order number. This parameter is returned if InstanceChargeType is set to PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202008594930117</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>079874CD-AEC1-43E6-AC03-ADD96B6E4907</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-2ze7fbuohm****</para>
        /// </summary>
        [NameInMap("RouterInterfaceId")]
        [Validation(Required=false)]
        public string RouterInterfaceId { get; set; }

    }

}
