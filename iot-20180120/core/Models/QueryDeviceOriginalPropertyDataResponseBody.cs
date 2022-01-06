// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalPropertyDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceOriginalPropertyDataResponseBodyData Data { get; set; }
        public class QueryDeviceOriginalPropertyDataResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceOriginalPropertyDataResponseBodyDataList List { get; set; }
            public class QueryDeviceOriginalPropertyDataResponseBodyDataList : TeaModel {
                [NameInMap("PropertyInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceOriginalPropertyDataResponseBodyDataListPropertyInfo> PropertyInfo { get; set; }
                public class QueryDeviceOriginalPropertyDataResponseBodyDataListPropertyInfo : TeaModel {
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }
            [NameInMap("NextValid")]
            [Validation(Required=false)]
            public bool? NextValid { get; set; }
            [NameInMap("nextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }
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
