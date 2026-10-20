// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AddDisplayKnowledgeRequest : Darabonba.Model {
        /// <summary>
        /// <para>The knowledge base ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <para>The records to add. A maximum of 500 records are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<AddDisplayKnowledgeRequestRecords> Records { get; set; }
        public class AddDisplayKnowledgeRequestRecords : Darabonba.Model {
            /// <summary>
            /// <para>The HTTP(S) URL of the product image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx/img_1784599244373_9c2309a0.jpg">https://xxxx/img_1784599244373_9c2309a0.jpg</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The SKU ID. If this parameter is left empty, the platform generates the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sku-001</para>
            /// </summary>
            [NameInMap("SkuId")]
            [Validation(Required=false)]
            public string SkuId { get; set; }

            /// <summary>
            /// <para>The SKU name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product front image</para>
            /// </summary>
            [NameInMap("SkuName")]
            [Validation(Required=false)]
            public string SkuName { get; set; }

        }

    }

}

