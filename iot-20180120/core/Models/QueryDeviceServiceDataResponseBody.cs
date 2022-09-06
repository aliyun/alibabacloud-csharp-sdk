// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceServiceDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceServiceDataResponseBodyData Data { get; set; }
        public class QueryDeviceServiceDataResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceServiceDataResponseBodyDataList List { get; set; }
            public class QueryDeviceServiceDataResponseBodyDataList : TeaModel {
                [NameInMap("ServiceInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceServiceDataResponseBodyDataListServiceInfo> ServiceInfo { get; set; }
                public class QueryDeviceServiceDataResponseBodyDataListServiceInfo : TeaModel {
                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    [NameInMap("InputData")]
                    [Validation(Required=false)]
                    public string InputData { get; set; }

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

            [NameInMap("NextTime")]
            [Validation(Required=false)]
            public long? NextTime { get; set; }

            [NameInMap("NextValid")]
            [Validation(Required=false)]
            public bool? NextValid { get; set; }

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
