// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GenerateUserAccessTokenRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a***<a href="mailto:bcx@gmail.com">bcx@gmail.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8882022040000000171</para>
        /// </summary>
        [NameInMap("ForeignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1381111****</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
