// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreatePerspectiveRequest : TeaModel {
        /// <summary>
        /// <para>The agent key. If unspecified, the system uses the default agent. You can obtain this key from the Business Management page of your Alibaba Cloud account.</para>
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
        /// <para>用于购物APP的移动端视角</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the perspective. The maximum length is 50 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>移动端视角</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
