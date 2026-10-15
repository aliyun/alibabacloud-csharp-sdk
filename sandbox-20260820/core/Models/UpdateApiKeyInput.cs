// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateApiKeyInput : TeaModel {
        /// <summary>
        /// <para>The new name of the API key. The name can be up to 128 characters in length and can contain letters, digits, spaces, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ci-pipeline-key-v2</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The expiration time of the API key, in UTC, in RFC 3339 format. Leave this parameter empty to indicate that the API key never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099-12-31T23:59:59Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The IP blacklist. If specified, the existing blacklist is entirely overwritten. This parameter is mutually exclusive with ipWhitelist.</para>
        /// </summary>
        [NameInMap("ipBlacklist")]
        [Validation(Required=false)]
        public List<IPConfig> IpBlacklist { get; set; }

        /// <summary>
        /// <para>The IP whitelist. If specified, the existing whitelist is entirely overwritten. This parameter is mutually exclusive with ipBlacklist.</para>
        /// </summary>
        [NameInMap("ipWhitelist")]
        [Validation(Required=false)]
        public List<IPConfig> IpWhitelist { get; set; }

        /// <summary>
        /// <para>The new status of the API key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: Enabled.</description></item>
        /// <item><description>inactive: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inactive</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
