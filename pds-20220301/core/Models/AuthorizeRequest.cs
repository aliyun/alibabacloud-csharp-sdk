// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AuthorizeRequest : TeaModel {
        /// <summary>
        /// The application ID returned when the application was created.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Specifies whether to hide the consent page.
        /// </summary>
        [NameInMap("hide_consent")]
        [Validation(Required=false)]
        public bool? HideConsent { get; set; }

        /// <summary>
        /// The authentication method. Valid values:
        /// 
        /// *   default: all logon methods that are integrated on the default logon page provided by Drive and Photo Service.
        /// *   ding: logs on by scanning a DingTalk QR code.
        /// *   ding_sns: logs on by entering a DingTalk account and its password.
        /// *   ram: logs on as an Alibaba Cloud Resource Access Management (RAM) user.
        /// *   wechat: logs on by scanning a WeCom QR code.
        /// *   wechat_app: logs on without authentication in WeCom.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("login_type")]
        [Validation(Required=false)]
        public string LoginType { get; set; }

        /// <summary>
        /// The callback URL specified when the application was created.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// The format in which to return the response. Set the value to code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("response_type")]
        [Validation(Required=false)]
        public string ResponseType { get; set; }

        /// <summary>
        /// The requested permissions. By default, all permissions are requested.
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public List<string> Scope { get; set; }

        /// <summary>
        /// The user-defined parameter to return in the callback URL after the requested permissions are granted.
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
