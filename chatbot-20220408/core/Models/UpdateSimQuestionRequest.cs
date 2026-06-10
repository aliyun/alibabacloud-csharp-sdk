// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateSimQuestionRequest : TeaModel {
        /// <summary>
        /// <para>The key of the workspace. If you do not specify this parameter, the default workspace is used. You can find the key on the Business Management page of your master account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The ID of the similar question that you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000002788</para>
        /// </summary>
        [NameInMap("SimQuestionId")]
        [Validation(Required=false)]
        public long? SimQuestionId { get; set; }

        /// <summary>
        /// <para>The new title of the similar question. The title can be up to 120 characters long.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试相似问标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
