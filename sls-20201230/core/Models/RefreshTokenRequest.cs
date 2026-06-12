// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class RefreshTokenRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The expiration time of the access token in seconds. This specifies the period during which the token is valid for accessing page API operations. The default value is 86400 seconds (one day). The value must be an integer from 0 to 86400.</para>
        /// </description></item>
        /// <item><description><para>The actual expiration time of the access token is the minimum value of accessTokenExpirationTime and expirationTime.</para>
        /// </description></item>
        /// <item><description><para>If you call this operation using Security Token Service (STS), the actual expiration time of the access token is the minimum value of accessTokenExpirationTime, expirationTime, and the STS token expiration time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("accessTokenExpirationTime")]
        [Validation(Required=false)]
        public long? AccessTokenExpirationTime { get; set; }

        /// <summary>
        /// <para>The logon-free ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ***************.eyJ******************.KUT****************</para>
        /// </summary>
        [NameInMap("ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
