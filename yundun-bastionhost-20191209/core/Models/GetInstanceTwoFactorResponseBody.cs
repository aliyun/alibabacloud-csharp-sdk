// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceTwoFactorResponseBody : TeaModel {
        /// <summary>
        /// The settings of two-factor authentication.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetInstanceTwoFactorResponseBodyConfig Config { get; set; }
        public class GetInstanceTwoFactorResponseBodyConfig : TeaModel {
            /// <summary>
            /// Indicates whether two-factor authentication is enabled. Valid values:
            /// 
            /// *   **true**: enabled
            /// *   **false**: disabled
            /// </summary>
            [NameInMap("EnableTwoFactor")]
            [Validation(Required=false)]
            public bool? EnableTwoFactor { get; set; }

            /// <summary>
            /// The duration within which two-factor authentication is not required after a local user passes two-factor authentication. Valid values: `0 to 168`. Unit: hours.
            /// 
            /// >  If 0 is returned, a local user must pass two-factor authentication every time the local user logs on to the bastion host.
            /// </summary>
            [NameInMap("SkipTwoFactorTime")]
            [Validation(Required=false)]
            public long? SkipTwoFactorTime { get; set; }

            /// <summary>
            /// Indicates one or more methods that are used to send verification codes if two-factor authentication is enabled.
            /// </summary>
            [NameInMap("TwoFactorMethods")]
            [Validation(Required=false)]
            public List<string> TwoFactorMethods { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
