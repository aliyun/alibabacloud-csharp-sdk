// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SyncOrgStructureShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The enterprise identifier. This value must match the corpId returned by listAvailableConfigs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCorpId</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>The department list. At least one root department must be included.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("departments")]
        [Validation(Required=false)]
        public string DepartmentsShrink { get; set; }

        /// <summary>
        /// <para>The member list. This parameter is required when syncMembers is set to true.</para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public string MembersShrink { get; set; }

        /// <summary>
        /// <para>The platform type. Valid values: saml, oauth2, or custom.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saml</para>
        /// </summary>
        [NameInMap("platformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

        /// <summary>
        /// <para>The SSO configuration ID. For SAML/OAuth2, this parameter is optional. If not specified, the value is automatically derived based on corpId. If multiple IdPs use the same corpId, you must explicitly specify this parameter. Otherwise, an AMBIGUOUS error is returned. This parameter is not required for custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSsoSettingsId</para>
        /// </summary>
        [NameInMap("ssoSettingsId")]
        [Validation(Required=false)]
        public string SsoSettingsId { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize member relationships. In custom mode, this parameter is forced to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("syncMembers")]
        [Validation(Required=false)]
        public bool? SyncMembers { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
