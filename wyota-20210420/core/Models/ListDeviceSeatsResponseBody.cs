// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListDeviceSeatsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeviceSeatsResponseBodyData Data { get; set; }
        public class ListDeviceSeatsResponseBodyData : TeaModel {
            [NameInMap("DeviceSeatDTOList")]
            [Validation(Required=false)]
            public List<ListDeviceSeatsResponseBodyDataDeviceSeatDTOList> DeviceSeatDTOList { get; set; }
            public class ListDeviceSeatsResponseBodyDataDeviceSeatDTOList : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("SeatName")]
                [Validation(Required=false)]
                public string SeatName { get; set; }

                [NameInMap("SeatNo")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                [NameInMap("SerialNo")]
                [Validation(Required=false)]
                public string SerialNo { get; set; }

                [NameInMap("SiteId")]
                [Validation(Required=false)]
                public string SiteId { get; set; }

                [NameInMap("SiteName")]
                [Validation(Required=false)]
                public string SiteName { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
