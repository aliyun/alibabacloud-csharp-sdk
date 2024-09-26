// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSaasInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DS,FAQ</para>
        /// </summary>
        [NameInMap("SaasGroupCodes")]
        [Validation(Required=false)]
        public string SaasGroupCodes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userTest</para>
        /// </summary>
        [NameInMap("SaasName")]
        [Validation(Required=false)]
        public string SaasName { get; set; }

    }

}
