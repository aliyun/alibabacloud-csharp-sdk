// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAvailableConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>可用的组织同步配置列表</para>
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<ListAvailableConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListAvailableConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>企业标识（wecom=corpId, saml=idpEntityId, oauth2=clientId, custom=客户自定义）。注意：OAuth2 多 IdP 配置使用相同 clientId 时，需在 syncOrgStructure 中显式传 ssoSettingsId</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleCorpId</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>企业展示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>平台类型: wecom / saml / oauth2 / custom</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("platformType")]
            [Validation(Required=false)]
            public string PlatformType { get; set; }

            /// <summary>
            /// <para>SSO 配置 ID（仅 SAML/OAuth2/WeCom 有值，custom 为 null）</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSsoSettingsId</para>
            /// </summary>
            [NameInMap("ssoSettingsId")]
            [Validation(Required=false)]
            public string SsoSettingsId { get; set; }

            /// <summary>
            /// <para>SSO 配置名称（仅 SAML/OAuth2/WeCom 有值，custom 为 null）</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("ssoSettingsName")]
            [Validation(Required=false)]
            public string SsoSettingsName { get; set; }

        }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
