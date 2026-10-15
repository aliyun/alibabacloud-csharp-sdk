// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class ImportApiKeyInput : TeaModel {
        /// <summary>
        /// <para>The API key name. The name can be up to 128 characters in length and can contain letters, digits, spaces, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>migrated-key</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The plaintext value of the API key to import. After the import, the source of the key is set to custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2b_****</para>
        /// </summary>
        [NameInMap("apiKeyValue")]
        [Validation(Required=false)]
        public string ApiKeyValue { get; set; }

        /// <summary>
        /// <para>The expiration time of the API key in UTC. The time is in RFC 3339 format. If this parameter is left empty, the API key never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099-12-31T23:59:59Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the team to which the API key belongs, in UUID format. If this parameter is not specified, the default team of the current account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f4a2c18-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
