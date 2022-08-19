// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateDeviceCodeResponseBody : TeaModel {
        [NameInMap("device_code")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        [NameInMap("expires_at")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        [NameInMap("interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        [NameInMap("user_code")]
        [Validation(Required=false)]
        public string UserCode { get; set; }

        [NameInMap("verification_uri")]
        [Validation(Required=false)]
        public string VerificationUri { get; set; }

        [NameInMap("verification_uri_complete")]
        [Validation(Required=false)]
        public string VerificationUriComplete { get; set; }

    }

}
