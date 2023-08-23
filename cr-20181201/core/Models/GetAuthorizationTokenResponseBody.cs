// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetAuthorizationTokenResponseBody : TeaModel {
        /// <summary>
        /// The temporary password returned after you call this API operation is a Security Token Service (STS) token whose validity period is 1 hour. Take note of the following items when you log on to Container Registry instances by using an STS token:
        /// 
        /// *   If the STS token belongs to an Alibaba Cloud account, you can use the STS token to log on to all Container Registry instances that belong to the Alibaba Cloud account.
        /// *   If the STS token belongs to a Resource Access Management (RAM) user, you can use the STS token to log on to all Container Registry instances that belong to the RAM user.
        /// *   You can use an STS token to access only Container Registry instances to which the STS token is scoped.
        /// </summary>
        [NameInMap("AuthorizationToken")]
        [Validation(Required=false)]
        public string AuthorizationToken { get; set; }

        /// <summary>
        /// Indicates whether the API call is successful.
        /// 
        /// *   `true`: successful
        /// *   `false`: failed
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// The username that is used to log on to the Container Registry instance.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The timestamp when the temporary password expires. Unit: milliseconds.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The password that is used to log on to the Container Registry instance.
        /// </summary>
        [NameInMap("TempUsername")]
        [Validation(Required=false)]
        public string TempUsername { get; set; }

    }

}
