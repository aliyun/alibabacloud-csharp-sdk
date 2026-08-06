// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class UpdatePromptRequest : TeaModel {
        /// <summary>
        /// <para>The list of business tags. The value is a string array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cs&quot;,&quot;qa&quot;,&quot;support&quot;]</para>
        /// </summary>
        [NameInMap("BizTags")]
        [Validation(Required=false)]
        public List<string> BizTags { get; set; }

        /// <summary>
        /// <para>The description of the prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客服问答 Prompt</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The mapping between prompt versions and labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;latest&quot;:&quot;0.0.1&quot;,&quot;stable&quot;:&quot;0.0.1&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the prompt.</para>
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
