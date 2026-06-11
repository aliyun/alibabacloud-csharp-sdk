// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class UpdatePromptRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;cs&quot;,&quot;qa&quot;,&quot;support&quot;]</para>
        /// </summary>
        [NameInMap("BizTags")]
        [Validation(Required=false)]
        public List<string> BizTags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>客服问答 Prompt</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer-service-qa</para>
        /// </summary>
        [NameInMap("PromptKey")]
        [Validation(Required=false)]
        public string PromptKey { get; set; }

    }

}
