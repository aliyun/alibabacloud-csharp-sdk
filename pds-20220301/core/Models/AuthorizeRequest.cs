// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AuthorizeRequest : TeaModel {
        /// <summary>
        /// <para>The application ID returned when the application was created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47eUHhrzgWBvlLWj</para>
        /// </summary>
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide the consent page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hide_consent")]
        [Validation(Required=false)]
        public bool? HideConsent { get; set; }

        /// <summary>
        /// <para>The authentication method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: all logon methods that are integrated on the default logon page provided by Drive and Photo Service.</description></item>
        /// <item><description>ding: logs on by scanning a DingTalk QR code.</description></item>
        /// <item><description>ding_sns: logs on by entering a DingTalk account and its password.</description></item>
        /// <item><description>ram: logs on as an Alibaba Cloud Resource Access Management (RAM) user.</description></item>
        /// <item><description>wechat: logs on by scanning a WeCom QR code.</description></item>
        /// <item><description>wechat_app: logs on without authentication in WeCom.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("login_type")]
        [Validation(Required=false)]
        public string LoginType { get; set; }

        /// <summary>
        /// <para>The callback URL specified when the application was created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyunpds.com/sign/callback">https://www.aliyunpds.com/sign/callback</a></para>
        /// </summary>
        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// <para>The format in which to return the response. Set the value to code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("response_type")]
        [Validation(Required=false)]
        public string ResponseType { get; set; }

        /// <summary>
        /// <para>The requested permissions. By default, all permissions are requested.</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public List<string> Scope { get; set; }

        /// <summary>
        /// <para>The user-defined parameter to return in the callback URL after the requested permissions are granted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customdata</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
