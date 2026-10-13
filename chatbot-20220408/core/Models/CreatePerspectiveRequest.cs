// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreatePerspectiveRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If this parameter is not specified, the default business space is accessed. You can obtain the key from the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The description of the perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A mobile perspective for the shopping app</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the perspective. The name can be up to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mobile perspective</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
