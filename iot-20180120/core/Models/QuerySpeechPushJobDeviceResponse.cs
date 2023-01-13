// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechPushJobDeviceResponse : TeaModel {
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
        public QuerySpeechPushJobDeviceResponseData Data { get; set; }
        public class QuerySpeechPushJobDeviceResponseData : TeaModel {
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
            public QuerySpeechPushJobDeviceResponseDataList List { get; set; }
            public class QuerySpeechPushJobDeviceResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QuerySpeechPushJobDeviceResponseDataListItems> Items { get; set; }
                public class QuerySpeechPushJobDeviceResponseDataListItems : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=true)]
                    public string DeviceName { get; set; }

                    [NameInMap("ErrorCode")]
                    [Validation(Required=true)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=true)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=true)]
                    public long? GmtModified { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public string Status { get; set; }

                }

            }

        }

    }

}
