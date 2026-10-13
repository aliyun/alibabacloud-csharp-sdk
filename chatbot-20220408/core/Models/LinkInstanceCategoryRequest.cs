// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class LinkInstanceCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The capability type of the category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FAQ: Frequently asked questions.</description></item>
        /// <item><description>MRC: Document-based machine reading comprehension.</description></item>
        /// </list>
        /// <para>Default value: FAQ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAQ,MRC</para>
        /// </summary>
        [NameInMap("AbilityType")]
        [Validation(Required=false)]
        public string AbilityType { get; set; }

        /// <summary>
        /// <para>The business space key. If this parameter is not specified, the default business space is accessed. You can obtain the key on the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The array of FAQ category IDs to associate with the chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;30000065789\&quot;]</para>
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIds { get; set; }

        /// <summary>
        /// <para>The unique identifier of the chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-mp90s2lrk00050</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
