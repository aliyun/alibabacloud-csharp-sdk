// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class UpdateDisplayKnowledgeRequest : Darabonba.Model {
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
        /// <para>The records to update. A maximum of 500 records can be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<UpdateDisplayKnowledgeRequestRecords> Records { get; set; }
        public class UpdateDisplayKnowledgeRequestRecords : Darabonba.Model {
            /// <summary>
            /// <para>The HTTP or HTTPS URL of the product image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx/96f21ebdaeeba27a.jpg">https://xxxx/96f21ebdaeeba27a.jpg</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1489638581</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The SKU ID. If this parameter is not empty, the original value is overwritten.</para>
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

