// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class DiduiAreaDeductionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of products and their detection boxes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public string ProductsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the customer-specific SKU vector database that determines which database is used for retrieval. The database must be created in advance through the database creation process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <para>The optional business request ID used for Tracing Analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>didui-request-001</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        /// <summary>
        /// <para>The HTTPS URL of the overall floor display image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/didui.jpg">https://example.com/didui.jpg</a></para>
        /// </summary>
        [NameInMap("TargetImageUrl")]
        [Validation(Required=false)]
        public string TargetImageUrl { get; set; }

    }

}
