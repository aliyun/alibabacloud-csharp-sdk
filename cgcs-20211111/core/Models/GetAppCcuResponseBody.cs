// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class GetAppCcuResponseBody : TeaModel {
        [NameInMap("DetailList")]
        [Validation(Required=false)]
        public List<GetAppCcuResponseBodyDetailList> DetailList { get; set; }
        public class GetAppCcuResponseBodyDetailList : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("Ccu")]
            [Validation(Required=false)]
            public string Ccu { get; set; }

            [NameInMap("DistrictId")]
            [Validation(Required=false)]
            public string DistrictId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
