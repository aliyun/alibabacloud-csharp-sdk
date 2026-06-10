// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GenerateUserAccessTokenRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If you do not specify this parameter, the system accesses the default business space. You can obtain the key from the Business Management page of your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The user\&quot;s email address.</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>This parameter is reserved. You do not need to specify it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>Additional information formatted as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;xx&quot;: 123,
        ///     &quot;yy&quot;: 22332,
        ///     &quot;customerNameCard&quot;: [
        ///         {
        ///             &quot;key&quot;: &quot;姓名&quot;,
        ///             &quot;value&quot;: &quot;张三&quot;
        ///         },
        ///         {
        ///             &quot;key&quot;: &quot;等级&quot;,
        ///             &quot;value&quot;: &quot;v2&quot;
        ///         },
        ///         {
        ///             &quot;key&quot;: &quot;联系方式&quot;,
        ///             &quot;value&quot;: &quot;123&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>The external user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8882022040000000171</para>
        /// </summary>
        [NameInMap("ForeignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// <para>The visitor\&quot;s nickname.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("Nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        /// <summary>
        /// <para>The user\&quot;s telephone number.</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
