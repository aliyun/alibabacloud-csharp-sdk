// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryCarProcessEventsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCarProcessEventsResponseBodyData Data { get; set; }
        public class QueryCarProcessEventsResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<QueryCarProcessEventsResponseBodyDataPageData> PageData { get; set; }
            public class QueryCarProcessEventsResponseBodyDataPageData : TeaModel {
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public int? ActionType { get; set; }

                [NameInMap("AreaIndex")]
                [Validation(Required=false)]
                public int? AreaIndex { get; set; }

                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public int? Confidence { get; set; }

                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                [NameInMap("EventPicId")]
                [Validation(Required=false)]
                public string EventPicId { get; set; }

                [NameInMap("EventPicUrl")]
                [Validation(Required=false)]
                public string EventPicUrl { get; set; }

                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public int? EventType { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("PlateNo")]
                [Validation(Required=false)]
                public string PlateNo { get; set; }

                [NameInMap("SubDeviceName")]
                [Validation(Required=false)]
                public string SubDeviceName { get; set; }

                [NameInMap("SubDeviceNickName")]
                [Validation(Required=false)]
                public string SubDeviceNickName { get; set; }

                [NameInMap("SubIotId")]
                [Validation(Required=false)]
                public string SubIotId { get; set; }

                [NameInMap("SubProductKey")]
                [Validation(Required=false)]
                public string SubProductKey { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
