// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAvailableConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of queried Logtail configurations.</para>
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<ListAvailableConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListAvailableConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleCorpId</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The organization name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>The platform type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("platformType")]
            [Validation(Required=false)]
            public string PlatformType { get; set; }

            /// <summary>
            /// <para>The SSO configuration ID. This field has a value only for SAML, OAuth2, or WeCom types. The value is null for custom types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSsoSettingsId</para>
            /// </summary>
            [NameInMap("ssoSettingsId")]
            [Validation(Required=false)]
            public string SsoSettingsId { get; set; }

            /// <summary>
            /// <para>The SSO configuration name. This field has a value only for SAML, OAuth2, or WeCom types. The value is null for custom types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("ssoSettingsName")]
            [Validation(Required=false)]
            public string SsoSettingsName { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
