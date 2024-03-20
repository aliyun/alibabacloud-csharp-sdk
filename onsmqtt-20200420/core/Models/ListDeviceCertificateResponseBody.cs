// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListDeviceCertificateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeviceCertificateResponseBodyData Data { get; set; }
        public class ListDeviceCertificateResponseBodyData : TeaModel {
            [NameInMap("DeviceCertificateVOS")]
            [Validation(Required=false)]
            public List<ListDeviceCertificateResponseBodyDataDeviceCertificateVOS> DeviceCertificateVOS { get; set; }
            public class ListDeviceCertificateResponseBodyDataDeviceCertificateVOS : TeaModel {
                [NameInMap("CaSn")]
                [Validation(Required=false)]
                public string CaSn { get; set; }

                [NameInMap("DeviceContent")]
                [Validation(Required=false)]
                public string DeviceContent { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceSn")]
                [Validation(Required=false)]
                public string DeviceSn { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("ValidBegin")]
                [Validation(Required=false)]
                public string ValidBegin { get; set; }

                [NameInMap("ValidEnd")]
                [Validation(Required=false)]
                public string ValidEnd { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
