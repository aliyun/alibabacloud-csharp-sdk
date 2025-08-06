// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddFreeLicenseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("LicenseList")]
        [Validation(Required=false)]
        public List<AddFreeLicenseResponseBodyLicenseList> LicenseList { get; set; }
        public class AddFreeLicenseResponseBodyLicenseList : TeaModel {
            [NameInMap("AppItemId")]
            [Validation(Required=false)]
            public string AppItemId { get; set; }

            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            [NameInMap("LicenseId")]
            [Validation(Required=false)]
            public long? LicenseId { get; set; }

            [NameInMap("LicenseItemId")]
            [Validation(Required=false)]
            public string LicenseItemId { get; set; }

            [NameInMap("SdkType")]
            [Validation(Required=false)]
            public string SdkType { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
