// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketProductPublicationDetail : TeaModel {
        /// <summary>
        /// <para>The unique ID of the portal.</para>
        /// </summary>
        [NameInMap("portalId")]
        [Validation(Required=false)]
        public string PortalId { get; set; }

        /// <summary>
        /// <para>The name of the portal.</para>
        /// </summary>
        [NameInMap("portalName")]
        [Validation(Required=false)]
        public string PortalName { get; set; }

        /// <summary>
        /// <para>The unique ID of the product.</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The name of the product.</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The type of the product.</para>
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The unique ID of the product publication.</para>
        /// </summary>
        [NameInMap("publicationId")]
        [Validation(Required=false)]
        public string PublicationId { get; set; }

    }

}
