// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom API. Pass this parameter if you need to specify a custom version of the API. If you created a custom API during the trial phase, you can query the ApiId of the corresponding feature in the product console by choosing Intelligent Inspection &gt; API Management &gt; My APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_xxx</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The URL of the original shelf or floor display image to be recognized. The URL must be accessible over the Internet or from OSS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/shelf.jpg">https://example.com/shelf.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The ID of the customer-specific SKU vector database, which determines the database used for retrieval. The database must be created through the database creation process in advance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <para>The custom rule. You can enter a detection prompt, which is passed as the <c>rule</c> input parameter to the workflow. If this parameter is specified, the <c>type</c> parameter is not required and the independent rule branch is used. If this parameter is left empty, you must specify the <c>type</c> parameter to start detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Identify all visible beverage products in the image and return only a JSON array. Output format example: [{&quot;bbox_2d&quot;:[100,200,250,600],&quot;sku_name&quot;:&quot;Coca-Cola&quot;}]</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The business type. This parameter is reserved for future routing based on business lines. Currently, only skincare products are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Skincare</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
