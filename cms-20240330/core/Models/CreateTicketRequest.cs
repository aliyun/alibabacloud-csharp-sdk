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
        /// <item><description>Access token expiration time (in seconds), which is the expiration time for the user to access the page interface. The default value is 86400 seconds (one day), and the range of values is from 0 to 86400 seconds (one day).</description></item>
        /// <item><description>The access token expiration time is the minimum value between <c>accessTokenExpirationTime</c> and <c>expirationTime</c>.</description></item>
        /// <item><description>If called through STS, the access token expiration time (i.e., the time during which the user can access the page interface) is the minimum value among <c>accessTokenExpirationTime</c>, <c>expirationTime</c>, and the STS expiration time.</description></item>
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
        /// <item><description>Expiration time (in seconds), which is the expiration time for the embedded page URL. The default value is 86400 seconds (one day), and the range of values is from 0 to 2592000 seconds (30 days).</description></item>
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
