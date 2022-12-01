// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicesHotStorageDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDevicesHotStorageDataResponseBodyData Data { get; set; }
        public class QueryDevicesHotStorageDataResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDevicesHotStorageDataResponseBodyDataList List { get; set; }
            public class QueryDevicesHotStorageDataResponseBodyDataList : TeaModel {
                [NameInMap("PropertyInfo")]
                [Validation(Required=false)]
                public List<QueryDevicesHotStorageDataResponseBodyDataListPropertyInfo> PropertyInfo { get; set; }
                public class QueryDevicesHotStorageDataResponseBodyDataListPropertyInfo : TeaModel {
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
