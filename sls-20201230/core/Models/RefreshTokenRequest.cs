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
        /// <item><description>The validity period of the access token. Unit: seconds. Default value: 86400, which specifies one day. Valid values: 0 to 86400.</description></item>
        /// <item><description>The validity period of the access token is the smaller value between accessTokenExpirationTime and expirationTime.</description></item>
        /// <item><description>If you use a Security Token Service (STS) token to call this operation, the validity period of the access token is the smallest value among accessTokenExpirationTime, expirationTime, and the validity period of the STS token.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("accessTokenExpirationTime")]
        [Validation(Required=false)]
        public long? AccessTokenExpirationTime { get; set; }

        /// <summary>
        /// <para>The ticket that is used for logon-free access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ***************.eyJ******************.KUT****************</para>
        /// </summary>
        [NameInMap("ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
