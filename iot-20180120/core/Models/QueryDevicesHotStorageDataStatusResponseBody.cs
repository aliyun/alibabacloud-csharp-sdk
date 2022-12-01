// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicesHotStorageDataStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDevicesHotStorageDataStatusResponseBodyData Data { get; set; }
        public class QueryDevicesHotStorageDataStatusResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDevicesHotStorageDataStatusResponseBodyDataList List { get; set; }
            public class QueryDevicesHotStorageDataStatusResponseBodyDataList : TeaModel {
                [NameInMap("PropertyStatusDataInfo")]
                [Validation(Required=false)]
                public List<QueryDevicesHotStorageDataStatusResponseBodyDataListPropertyStatusDataInfo> PropertyStatusDataInfo { get; set; }
                public class QueryDevicesHotStorageDataStatusResponseBodyDataListPropertyStatusDataInfo : TeaModel {
                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

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
