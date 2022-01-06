// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalEventDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceOriginalEventDataResponseBodyData Data { get; set; }
        public class QueryDeviceOriginalEventDataResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceOriginalEventDataResponseBodyDataList List { get; set; }
            public class QueryDeviceOriginalEventDataResponseBodyDataList : TeaModel {
                [NameInMap("EventInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceOriginalEventDataResponseBodyDataListEventInfo> EventInfo { get; set; }
                public class QueryDeviceOriginalEventDataResponseBodyDataListEventInfo : TeaModel {
                    [NameInMap("EventType")]
                    [Validation(Required=false)]
                    public string EventType { get; set; }

                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OutputData")]
                    [Validation(Required=false)]
                    public string OutputData { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

            }
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }
            [NameInMap("NextValid")]
            [Validation(Required=false)]
            public bool? NextValid { get; set; }
        };

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
