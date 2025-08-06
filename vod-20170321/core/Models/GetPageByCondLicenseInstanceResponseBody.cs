// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPageByCondLicenseInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPageByCondLicenseInstanceResponseBodyData Data { get; set; }
        public class GetPageByCondLicenseInstanceResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<LicenseInstanceAppDTO> List { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
