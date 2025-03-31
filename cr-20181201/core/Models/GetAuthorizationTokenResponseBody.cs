// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetAuthorizationTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The temporary password returned after you call this API operation is a Security Token Service (STS) token whose validity period is 1 hour. Take note of the following items when you log on to Container Registry instances by using an STS token:</para>
        /// <list type="bullet">
        /// <item><description>If the STS token belongs to an Alibaba Cloud account, you can use the STS token to log on to all Container Registry instances that belong to the Alibaba Cloud account.</description></item>
        /// <item><description>If the STS token belongs to a Resource Access Management (RAM) user, you can use the STS token to log on to all Container Registry instances that belong to the RAM user.</description></item>
        /// <item><description>You can use an STS token to access only Container Registry instances to which the STS token is scoped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shaunadadakks:uuczxnjcyeyhdjadkkajsjdjadhyucb</para>
        /// </summary>
        [NameInMap("AuthorizationToken")]
        [Validation(Required=false)]
        public string AuthorizationToken { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: successful</description></item>
        /// <item><description><c>false</c>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571242083000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The username that is used to log on to the Container Registry instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The timestamp when the temporary password expires. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E069EB86-E6AD-4A98-ADDE-0E993390239A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The password that is used to log on to the Container Registry instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temp_user_cr</para>
        /// </summary>
        [NameInMap("TempUsername")]
        [Validation(Required=false)]
        public string TempUsername { get; set; }

    }

}
