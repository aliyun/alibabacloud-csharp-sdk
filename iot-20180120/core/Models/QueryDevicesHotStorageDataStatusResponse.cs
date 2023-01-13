// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicesHotStorageDataStatusResponse : TeaModel {
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
        public QueryDevicesHotStorageDataStatusResponseData Data { get; set; }
        public class QueryDevicesHotStorageDataStatusResponseData : TeaModel {
            [NameInMap("NextPageToken")]
            [Validation(Required=true)]
            public string NextPageToken { get; set; }

            [NameInMap("NextValid")]
            [Validation(Required=true)]
            public bool? NextValid { get; set; }

            [NameInMap("List")]
            [Validation(Required=true)]
            public QueryDevicesHotStorageDataStatusResponseDataList List { get; set; }
            public class QueryDevicesHotStorageDataStatusResponseDataList : TeaModel {
                [NameInMap("PropertyStatusDataInfo")]
                [Validation(Required=true)]
                public List<QueryDevicesHotStorageDataStatusResponseDataListPropertyStatusDataInfo> PropertyStatusDataInfo { get; set; }
                public class QueryDevicesHotStorageDataStatusResponseDataListPropertyStatusDataInfo : TeaModel {
                    [NameInMap("Identifier")]
                    [Validation(Required=true)]
                    public string Identifier { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=true)]
                    public long? Time { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=true)]
                    public string Value { get; set; }

                }

            }

        }

    }

}
