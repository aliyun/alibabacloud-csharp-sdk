// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertyDataResponse : TeaModel {
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
        public QueryDevicePropertyDataResponseData Data { get; set; }
        public class QueryDevicePropertyDataResponseData : TeaModel {
            [NameInMap("NextValid")]
            [Validation(Required=true)]
            public bool? NextValid { get; set; }
            [NameInMap("NextTime")]
            [Validation(Required=true)]
            public long? NextTime { get; set; }
            [NameInMap("List")]
            [Validation(Required=true)]
            public QueryDevicePropertyDataResponseDataList List { get; set; }
            public class QueryDevicePropertyDataResponseDataList : TeaModel {
                [NameInMap("PropertyInfo")]
                [Validation(Required=true)]
                public List<QueryDevicePropertyDataResponseDataListPropertyInfo> PropertyInfo { get; set; }
                public class QueryDevicePropertyDataResponseDataListPropertyInfo : TeaModel {
                    [NameInMap("Time")]
                    [Validation(Required=true)]
                    public string Time { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=true)]
                    public string Value { get; set; }

                }

            }
        };

    }

}
