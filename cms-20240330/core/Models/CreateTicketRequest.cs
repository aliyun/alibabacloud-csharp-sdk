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
        /// <item><description><para>The expiration time of the access token, in seconds. This is the period during which a user can access the page APIs. The value can range from 0 to 86,400 seconds (one day). The default value is 86,400 seconds (one day).</para>
        /// </description></item>
        /// <item><description><para>The effective expiration time of the access token is the minimum value of accessTokenExpirationTime and expirationTime.</para>
        /// </description></item>
        /// <item><description><para>If you call the operation using a Security Token Service (STS) token, the effective expiration time of the access token is the minimum value of accessTokenExpirationTime, expirationTime, and the expiration time of the STS token.</para>
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
        /// <list type="bullet">
        /// <item><description>The expiration time of the URL for the embedded page, in seconds. The value can range from 0 to 2,592,000 seconds (30 days). The default value is 86,400 seconds (one day).</description></item>
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
