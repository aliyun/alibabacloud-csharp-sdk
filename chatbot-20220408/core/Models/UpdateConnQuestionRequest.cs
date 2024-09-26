// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateConnQuestionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000295</para>
        /// </summary>
        [NameInMap("ConnQuestionId")]
        [Validation(Required=false)]
        public long? ConnQuestionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>877397683</para>
        /// </summary>
        [NameInMap("OutlineId")]
        [Validation(Required=false)]
        public long? OutlineId { get; set; }

    }

}
