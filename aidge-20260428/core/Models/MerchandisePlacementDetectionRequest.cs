// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies a custom API version. If you created a &quot;My API&quot; during the trial phase, you can find the corresponding ApiId in the product console under &quot;Intelligent Inspection &gt; API Management &gt; My API&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_xxx</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The URL of the shelf or floor-stack image to be recognized (accessible over the public network or from OSS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/shelf.jpg">https://example.com/shelf.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The ID of the customer\&quot;s dedicated SKU vector library, which determines which library is used for retrieval. The library must be created in advance through the library creation process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <para>The business type (reserved for future routing by business line). The current phase supports skincare &amp; lotion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>水乳</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
