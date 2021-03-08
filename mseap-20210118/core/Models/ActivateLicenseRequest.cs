/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class ActivateLicenseRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("LicensePublisher")]
        [Validation(Required=false)]
        public string LicensePublisher { get; set; }

        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

    }

}
