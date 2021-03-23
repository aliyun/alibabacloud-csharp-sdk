// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListAssistHistoriesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PerPage")]
        [Validation(Required=false)]
        public int? PerPage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Histories")]
        [Validation(Required=false)]
        public List<ListAssistHistoriesResponseBodyHistories> Histories { get; set; }
        public class ListAssistHistoriesResponseBodyHistories : TeaModel {
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("HardwareId")]
            [Validation(Required=false)]
            public string HardwareId { get; set; }

            [NameInMap("UUID")]
            [Validation(Required=false)]
            public string UUID { get; set; }

            [NameInMap("VIN")]
            [Validation(Required=false)]
            public string VIN { get; set; }

            [NameInMap("UID")]
            [Validation(Required=false)]
            public string UID { get; set; }

            [NameInMap("UNAME")]
            [Validation(Required=false)]
            public string UNAME { get; set; }

        }

    }

}
