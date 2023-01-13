// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalPropertyDataResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceOriginalPropertyDataResponseData Data { get; set; }
        public class QueryDeviceOriginalPropertyDataResponseData : TeaModel {
            [NameInMap("NextValid")]
            [Validation(Required=true)]
            public bool? NextValid { get; set; }

            [NameInMap("nextPageToken")]
            [Validation(Required=true)]
            public string NextPageToken { get; set; }

            [NameInMap("List")]
            [Validation(Required=true)]
            public QueryDeviceOriginalPropertyDataResponseDataList List { get; set; }
            public class QueryDeviceOriginalPropertyDataResponseDataList : TeaModel {
                [NameInMap("PropertyInfo")]
                [Validation(Required=true)]
                public List<QueryDeviceOriginalPropertyDataResponseDataListPropertyInfo> PropertyInfo { get; set; }
                public class QueryDeviceOriginalPropertyDataResponseDataListPropertyInfo : TeaModel {
                    [NameInMap("Time")]
                    [Validation(Required=true)]
                    public string Time { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=true)]
                    public string Value { get; set; }

                }

            }

        }

    }

}
