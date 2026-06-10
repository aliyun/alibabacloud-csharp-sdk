// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeleteSimQuestionRequest : TeaModel {
        /// <summary>
        /// <para>The key for the business space. If you omit this parameter, the default business space is used. You can find the key on the business management page of your primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The ID of the similar question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000002788</para>
        /// </summary>
        [NameInMap("SimQuestionId")]
        [Validation(Required=false)]
        public long? SimQuestionId { get; set; }

    }

}
