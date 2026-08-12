// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateTicketRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The expiration time of the access token in seconds, which specifies how long the user can access page APIs. Default value: 86400 (one day). Valid values: 0 to 86400 (one day).</description></item>
        /// <item><description>The actual access token expiration time is the minimum value of accessTokenExpirationTime and expirationTime.</description></item>
        /// <item><description>If you call this operation by using a Security Token Service (STS) token, the actual access token expiration time is the minimum value of accessTokenExpirationTime, expirationTime, and the STS token expiration time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("accessTokenExpirationTime")]
        [Validation(Required=false)]
        public long? AccessTokenExpirationTime { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The expiration time in seconds for the embedded page URL link. Default value: 86400 (one day). Valid values: 0 to 2592000 (30 days).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

    }

}
