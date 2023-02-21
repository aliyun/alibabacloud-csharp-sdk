// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcAdminLicenseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcAdminLicenseResponseBodyData> Data { get; set; }
        public class GetOcIcAdminLicenseResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("LicenseName")]
            [Validation(Required=false)]
            public string LicenseName { get; set; }

            [NameInMap("LicenseNo")]
            [Validation(Required=false)]
            public string LicenseNo { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
