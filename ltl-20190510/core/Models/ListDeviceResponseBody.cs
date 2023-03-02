// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class ListDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeviceResponseBodyData Data { get; set; }
        public class ListDeviceResponseBodyData : TeaModel {
            [NameInMap("Num")]
            [Validation(Required=false)]
            public int? Num { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListDeviceResponseBodyDataPageData> PageData { get; set; }
            public class ListDeviceResponseBodyDataPageData : TeaModel {
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("LastSaveTime")]
                [Validation(Required=false)]
                public long? LastSaveTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
