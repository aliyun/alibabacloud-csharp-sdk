// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class CreateTicketRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The access token expiration time, in seconds. This specifies the expiration time for the user to access page operations. Default value: 86400 (one day). Valid values: 0 to 86400 (one day).</para>
        /// </description></item>
        /// <item><description><para>The actual access token expiration time is the minimum value of accessTokenExpirationTime and expirationTime.</para>
        /// </description></item>
        /// <item><description><para>If you call this operation by using Security Token Service (STS), the actual access token expiration time is the minimum value of accessTokenExpirationTime, expirationTime, and the STS token expiration time.</para>
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
        /// <item><description>The expiration time, in seconds. This specifies the expiration time of the embedded page URL. Default value: 86400 (one day). Valid values: 0 to 2592000 (30 days).</description></item>
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
