// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdatePerspectiveRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If not specified, the default business space is used. You can get the key from the Business Management page of your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The name of the perspective. The name must be 50 characters or fewer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户端视角</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The perspective ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3001</para>
        /// </summary>
        [NameInMap("PerspectiveId")]
        [Validation(Required=false)]
        public string PerspectiveId { get; set; }

    }

}
