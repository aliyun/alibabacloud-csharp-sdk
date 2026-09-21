// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateApiKeyInput : TeaModel {
        /// <summary>
        /// <para>The name of the API key. The name can be up to 128 characters in length and can contain letters, digits, spaces, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ci-pipeline-key</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The expiration time of the API key. The time is in UTC and in the RFC 3339 format. If you leave this parameter empty, the API key never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099-12-31T23:59:59Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The IP blacklist. After you configure this parameter, IP addresses in the list cannot use the API key. This parameter is mutually exclusive with ipWhitelist.</para>
        /// </summary>
        [NameInMap("ipBlacklist")]
        [Validation(Required=false)]
        public List<IPConfig> IpBlacklist { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. After you configure this parameter, only IP addresses in the list can use the API key. This parameter is mutually exclusive with ipBlacklist.</para>
        /// </summary>
        [NameInMap("ipWhitelist")]
        [Validation(Required=false)]
        public List<IPConfig> IpWhitelist { get; set; }

        /// <summary>
        /// <para>The ID of the team to which the API key belongs. The value is in UUID format. If you do not specify this parameter, the default team of the current account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f4a2c18-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
