// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateApiKeyInput : TeaModel {
        /// <summary>
        /// <para>The name of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-24T16:00:00.000Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The list of IP addresses that are blocked from using the API key.</para>
        /// </summary>
        [NameInMap("ipBlacklist")]
        [Validation(Required=false)]
        public List<IPConfig> IpBlacklist { get; set; }

        /// <summary>
        /// <para>The list of IP addresses that are allowed to use the API key.</para>
        /// </summary>
        [NameInMap("ipWhitelist")]
        [Validation(Required=false)]
        public List<IPConfig> IpWhitelist { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70d1c834-0383-58d8-97ac-5336eb91abcd</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
