// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreatePublishTaskRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If you omit this parameter, the default business space is used. You can obtain the key from the Business Management page of your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The type of content to publish. To publish a bot, use the <c>CreateInstancePublishTask</c> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>faq</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Specifies data to publish by ID. This parameter is used only when <c>BizType</c> is set to <c>faq</c>. In this case, provide one or more category IDs to publish knowledge exclusively from the specified categories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;8521&quot;]</para>
        /// </summary>
        [NameInMap("DataIdList")]
        [Validation(Required=false)]
        public List<string> DataIdList { get; set; }

    }

}
