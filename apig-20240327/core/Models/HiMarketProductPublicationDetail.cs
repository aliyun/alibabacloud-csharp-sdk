// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketProductPublicationDetail : TeaModel {
        /// <summary>
        /// <para>The portal ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>portal-xxx</para>
        /// </summary>
        [NameInMap("portalId")]
        [Validation(Required=false)]
        public string PortalId { get; set; }

        /// <summary>
        /// <para>The portal name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>开发者门户</para>
        /// </summary>
        [NameInMap("portalName")]
        [Validation(Required=false)]
        public string PortalName { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-xxx</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The product name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI网关API</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApiGateway</para>
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The product publish ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pub-xxx</para>
        /// </summary>
        [NameInMap("publicationId")]
        [Validation(Required=false)]
        public string PublicationId { get; set; }

    }

}
