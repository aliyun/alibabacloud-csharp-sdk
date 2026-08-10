// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GenerateYikeLoginTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The session expiration time (millisecond timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782008128000</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The login token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*<em><b><b>d6931ff7e89b5eb19484</b></b></em></para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The generated user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23253**</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
