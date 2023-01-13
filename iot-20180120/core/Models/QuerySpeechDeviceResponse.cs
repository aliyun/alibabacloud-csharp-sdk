// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechDeviceResponse : TeaModel {
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
        public QuerySpeechDeviceResponseData Data { get; set; }
        public class QuerySpeechDeviceResponseData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=true)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("List")]
            [Validation(Required=true)]
            public QuerySpeechDeviceResponseDataList List { get; set; }
            public class QuerySpeechDeviceResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QuerySpeechDeviceResponseDataListItems> Items { get; set; }
                public class QuerySpeechDeviceResponseDataListItems : TeaModel {
                    [NameInMap("AvailableSpace")]
                    [Validation(Required=true)]
                    public float? AvailableSpace { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=true)]
                    public string DeviceName { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=true)]
                    public string IotId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=true)]
                    public string ProductKey { get; set; }

                }

            }

        }

    }

}
