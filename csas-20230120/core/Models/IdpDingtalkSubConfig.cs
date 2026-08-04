// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpDingtalkSubConfig : TeaModel {
        /// <summary>
        /// <para>Your application\&quot;s unique identifier. You can get this identifier from the DingTalk Open Platform.</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>Your application\&quot;s secret key. You can get this key from the DingTalk Open Platform.</para>
        /// </summary>
        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <para>Your enterprise\&quot;s unique ID in DingTalk.</para>
        /// </summary>
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>The AES key used to decrypt the content of event callbacks. This ensures the confidentiality of the event data.</para>
        /// </summary>
        [NameInMap("EventAesKey")]
        [Validation(Required=false)]
        public string EventAesKey { get; set; }

        /// <summary>
        /// <para>A custom label for event subscriptions. This field is reserved for future use.</para>
        /// </summary>
        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        /// <summary>
        /// <para>The token used to verify the authenticity of event callback requests from DingTalk.</para>
        /// </summary>
        [NameInMap("EventVerifyToken")]
        [Validation(Required=false)]
        public string EventVerifyToken { get; set; }

        /// <summary>
        /// <para>Specifies whether this identity provider is the exclusive login method. If set to <c>true</c>, other login methods are disabled.</para>
        /// </summary>
        [NameInMap("Exclusive")]
        [Validation(Required=false)]
        public bool? Exclusive { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the OAuth authentication flow.</para>
        /// </summary>
        [NameInMap("Oauth")]
        [Validation(Required=false)]
        public bool? Oauth { get; set; }

        /// <summary>
        /// <para>The URL where the user is redirected after successful authorization. You must register this URL on the DingTalk Open Platform.</para>
        /// </summary>
        [NameInMap("RedirectUri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

    }

}
