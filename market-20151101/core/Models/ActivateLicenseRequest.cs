/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class ActivateLicenseRequest : TeaModel {
        [NameInMap("Identification")]
        [Validation(Required=false)]
        public string Identification { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

    }

}
