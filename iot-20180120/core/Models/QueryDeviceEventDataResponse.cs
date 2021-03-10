// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceEventDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceEventDataResponseData Data { get; set; }
        public class QueryDeviceEventDataResponseData : TeaModel {
            [NameInMap("NextTime")]
            [Validation(Required=true)]
            public long? NextTime { get; set; }
            [NameInMap("NextValid")]
            [Validation(Required=true)]
            public bool? NextValid { get; set; }
            [NameInMap("List")]
            [Validation(Required=true)]
            public QueryDeviceEventDataResponseDataList List { get; set; }
            public class QueryDeviceEventDataResponseDataList : TeaModel {
                [NameInMap("EventInfo")]
                [Validation(Required=true)]
                public List<QueryDeviceEventDataResponseDataListEventInfo> EventInfo { get; set; }
                public class QueryDeviceEventDataResponseDataListEventInfo : TeaModel {
                    [NameInMap("Time")]
                    [Validation(Required=true)]
                    public string Time { get; set; }

                    [NameInMap("Identifier")]
                    [Validation(Required=true)]
                    public string Identifier { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("EventType")]
                    [Validation(Required=true)]
                    public string EventType { get; set; }

                    [NameInMap("OutputData")]
                    [Validation(Required=true)]
                    public string OutputData { get; set; }

                }

            }
        };

    }

}
