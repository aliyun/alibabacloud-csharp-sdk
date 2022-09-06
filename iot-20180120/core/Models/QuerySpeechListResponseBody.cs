// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySpeechListResponseBodyData Data { get; set; }
        public class QuerySpeechListResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QuerySpeechListResponseBodyDataList List { get; set; }
            public class QuerySpeechListResponseBodyDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<QuerySpeechListResponseBodyDataListItems> Items { get; set; }
                public class QuerySpeechListResponseBodyDataListItems : TeaModel {
                    [NameInMap("AudioFormat")]
                    [Validation(Required=false)]
                    public string AudioFormat { get; set; }

                    [NameInMap("BizCode")]
                    [Validation(Required=false)]
                    public string BizCode { get; set; }

                    [NameInMap("SpeechCode")]
                    [Validation(Required=false)]
                    public string SpeechCode { get; set; }

                    [NameInMap("SpeechList")]
                    [Validation(Required=false)]
                    public QuerySpeechListResponseBodyDataListItemsSpeechList SpeechList { get; set; }
                    public class QuerySpeechListResponseBodyDataListItemsSpeechList : TeaModel {
                        [NameInMap("Items")]
                        [Validation(Required=false)]
                        public List<QuerySpeechListResponseBodyDataListItemsSpeechListItems> Items { get; set; }
                        public class QuerySpeechListResponseBodyDataListItemsSpeechListItems : TeaModel {
                            [NameInMap("BizCode")]
                            [Validation(Required=false)]
                            public string BizCode { get; set; }

                            [NameInMap("SpeechCode")]
                            [Validation(Required=false)]
                            public string SpeechCode { get; set; }

                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                            [NameInMap("Voice")]
                            [Validation(Required=false)]
                            public string Voice { get; set; }

                        }

                    }

                    [NameInMap("SpeechType")]
                    [Validation(Required=false)]
                    public string SpeechType { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("Voice")]
                    [Validation(Required=false)]
                    public string Voice { get; set; }

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
