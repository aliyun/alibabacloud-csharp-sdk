// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionRequest : TeaModel {
        /// <summary>
        /// <para>Specify this parameter to use a custom API version. If you created a custom API during the trial phase, you can find the corresponding ApiId in the product console under Intelligent Inspection &gt; API Management &gt; My API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_xxx</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The URL of the original shelf or floor stack image to be recognized (accessible over the Internet or through OSS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/shelf.jpg">https://example.com/shelf.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The ID of the customer-specific SKU vector library, which determines which library is used for retrieval. The library must be created in advance through the library creation process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <para>The custom rule. Enter a detection prompt as the workflow input parameter rule. When this parameter is specified, the type parameter is not required (a dedicated rule branch is used). If Rule is empty, you must specify Type to start detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Please identify all visible beverage products in the image and return only a JSON array. Output format example: [{&quot;bbox_2d&quot;:[100,200,250,600],&quot;sku_name&quot;:&quot;Coca-Cola&quot;}]</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The business type (reserved for future routing by business line). The current release supports skincare &amp; lotion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>水乳</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
