// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdatePerspectiveRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If not specified, the default business space is accessed. Obtain the key value from the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The perspective name. The name can be up to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Client perspective</para>
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
