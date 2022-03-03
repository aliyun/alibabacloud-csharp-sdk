// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceSpeechResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceSpeechResponseBodyData Data { get; set; }
        public class QueryDeviceSpeechResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceSpeechResponseBodyDataList List { get; set; }
            public class QueryDeviceSpeechResponseBodyDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<QueryDeviceSpeechResponseBodyDataListItems> Items { get; set; }
                public class QueryDeviceSpeechResponseBodyDataListItems : TeaModel {
                    [NameInMap("AudioFormat")]
                    [Validation(Required=false)]
                    public string AudioFormat { get; set; }

                    [NameInMap("BizCode")]
                    [Validation(Required=false)]
                    public string BizCode { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public float? Size { get; set; }

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
