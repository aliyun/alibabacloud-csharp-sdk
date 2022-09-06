// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySpeechDeviceResponseBodyData Data { get; set; }
        public class QuerySpeechDeviceResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QuerySpeechDeviceResponseBodyDataList List { get; set; }
            public class QuerySpeechDeviceResponseBodyDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<QuerySpeechDeviceResponseBodyDataListItems> Items { get; set; }
                public class QuerySpeechDeviceResponseBodyDataListItems : TeaModel {
                    [NameInMap("AvailableSpace")]
                    [Validation(Required=false)]
                    public float? AvailableSpace { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                }

            }

            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
