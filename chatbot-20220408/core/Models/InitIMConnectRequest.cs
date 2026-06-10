// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class InitIMConnectRequest : TeaModel {
        /// <summary>
        /// <para>The key for the business space. Omit this parameter to use the default business space. You can get the key from the business management page of your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The identifier for the connection source. You can obtain this value from the channel console.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The access token for user authentication.</para>
        /// </summary>
        [NameInMap("UserAccessToken")]
        [Validation(Required=false)]
        public string UserAccessToken { get; set; }

    }

}
