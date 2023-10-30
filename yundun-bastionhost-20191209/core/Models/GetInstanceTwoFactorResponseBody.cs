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
            /// Queries the settings of two-factor authentication on a bastion host.
            /// </summary>
            [NameInMap("EnableTwoFactor")]
            [Validation(Required=false)]
            public bool? EnableTwoFactor { get; set; }

            [NameInMap("SkipTwoFactorTime")]
            [Validation(Required=false)]
            public long? SkipTwoFactorTime { get; set; }

            [NameInMap("TwoFactorMethods")]
            [Validation(Required=false)]
            public List<string> TwoFactorMethods { get; set; }

        }

        /// <summary>
        /// The duration within which two-factor authentication is not required after a local user passes two-factor authentication. Valid values: `0 to 168`. Unit: hours.
        /// 
        /// >  If 0 is returned, a local user must pass two-factor authentication every time the local user logs on to the bastion host.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
