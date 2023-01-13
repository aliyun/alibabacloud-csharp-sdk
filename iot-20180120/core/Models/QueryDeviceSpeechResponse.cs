// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceSpeechResponse : TeaModel {
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
        public QueryDeviceSpeechResponseData Data { get; set; }
        public class QueryDeviceSpeechResponseData : TeaModel {
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
            public QueryDeviceSpeechResponseDataList List { get; set; }
            public class QueryDeviceSpeechResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QueryDeviceSpeechResponseDataListItems> Items { get; set; }
                public class QueryDeviceSpeechResponseDataListItems : TeaModel {
                    [NameInMap("AudioFormat")]
                    [Validation(Required=true)]
                    public string AudioFormat { get; set; }

                    [NameInMap("BizCode")]
                    [Validation(Required=true)]
                    public string BizCode { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=true)]
                    public float? Size { get; set; }

                }

            }

        }

    }

}
