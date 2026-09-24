// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionRequest : TeaModel {
        /// <summary>
        /// <para>Specify this parameter to use a custom API version. If you created a custom API during the trial phase, you can find the corresponding ApiId in the product console under <b>Intelligent Inspection &gt; API Management &gt; My APIs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_xxx</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The URL of the shelf or floor-stack photo to be recognized (accessible over the Internet or from OSS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/shelf.jpg">https://example.com/shelf.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The ID of the customer-specific SKU vector library, which determines which library is used for recall. The library must be created in advance through the library creation process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The business type (reserved for future routing by business line). The current release supports skincare.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skincare</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
