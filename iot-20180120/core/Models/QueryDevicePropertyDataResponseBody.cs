// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertyDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDevicePropertyDataResponseBodyData Data { get; set; }
        public class QueryDevicePropertyDataResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDevicePropertyDataResponseBodyDataList List { get; set; }
            public class QueryDevicePropertyDataResponseBodyDataList : TeaModel {
                [NameInMap("PropertyInfo")]
                [Validation(Required=false)]
                public List<QueryDevicePropertyDataResponseBodyDataListPropertyInfo> PropertyInfo { get; set; }
                public class QueryDevicePropertyDataResponseBodyDataListPropertyInfo : TeaModel {
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

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
