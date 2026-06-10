// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribePerspectiveRequest : TeaModel {
        /// <summary>
        /// <para>The key for the business space. If you do not specify this parameter, the default business space is used. You can get the key from your main account\&quot;s Business Management page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The ID of the perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3001</para>
        /// </summary>
        [NameInMap("PerspectiveId")]
        [Validation(Required=false)]
        public string PerspectiveId { get; set; }

    }

}
