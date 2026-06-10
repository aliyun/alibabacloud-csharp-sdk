// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class LinkInstanceCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The category\&quot;s ability type. Valid values: <c>FAQ</c> and <c>MRC</c> (machine reading comprehension). Defaults to <c>FAQ</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAQ,MRC</para>
        /// </summary>
        [NameInMap("AbilityType")]
        [Validation(Required=false)]
        public string AbilityType { get; set; }

        /// <summary>
        /// <para>The key for the business space. If you do not specify this parameter, the default business space is used. You can obtain the key on the Business Management page of your primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>An array of FAQ category IDs to link to the chatbot.</para>
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
