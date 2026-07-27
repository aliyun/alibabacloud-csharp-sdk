// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateGwConsumerOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The redemption code used for subsequent activation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;9&quot;</para>
        /// </summary>
        [NameInMap("CreditToken")]
        [Validation(Required=false)]
        public string CreditToken { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-14T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the AI gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-2ze24rr575j5b18cg</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The order ID returned after the order is placed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2035638*******</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7E6A8FD-C50B-46B2-BA85-D8B8D3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
