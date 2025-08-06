// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddLicenseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AddLicenseResponseBodyData> Data { get; set; }
        public class AddLicenseResponseBodyData : TeaModel {
            [NameInMap("AppItemId")]
            [Validation(Required=false)]
            public string AppItemId { get; set; }

            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("LicenseId")]
            [Validation(Required=false)]
            public long? LicenseId { get; set; }

            [NameInMap("SdkType")]
            [Validation(Required=false)]
            public string SdkType { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
