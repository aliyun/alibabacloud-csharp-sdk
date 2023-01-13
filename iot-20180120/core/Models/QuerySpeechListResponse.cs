// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechListResponse : TeaModel {
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
        public QuerySpeechListResponseData Data { get; set; }
        public class QuerySpeechListResponseData : TeaModel {
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
            public QuerySpeechListResponseDataList List { get; set; }
            public class QuerySpeechListResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QuerySpeechListResponseDataListItems> Items { get; set; }
                public class QuerySpeechListResponseDataListItems : TeaModel {
                    [NameInMap("AudioFormat")]
                    [Validation(Required=true)]
                    public string AudioFormat { get; set; }

                    [NameInMap("BizCode")]
                    [Validation(Required=true)]
                    public string BizCode { get; set; }

                    [NameInMap("SpeechCode")]
                    [Validation(Required=true)]
                    public string SpeechCode { get; set; }

                    [NameInMap("SpeechType")]
                    [Validation(Required=true)]
                    public string SpeechType { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=true)]
                    public string Text { get; set; }

                    [NameInMap("Voice")]
                    [Validation(Required=true)]
                    public string Voice { get; set; }

                    [NameInMap("SpeechList")]
                    [Validation(Required=true)]
                    public QuerySpeechListResponseDataListItemsSpeechList SpeechList { get; set; }
                    public class QuerySpeechListResponseDataListItemsSpeechList : TeaModel {
                        [NameInMap("Items")]
                        [Validation(Required=true)]
                        public List<QuerySpeechListResponseDataListItemsSpeechListItems> Items { get; set; }
                        public class QuerySpeechListResponseDataListItemsSpeechListItems : TeaModel {
                            [NameInMap("BizCode")]
                            [Validation(Required=true)]
                            public string BizCode { get; set; }

                            [NameInMap("SpeechCode")]
                            [Validation(Required=true)]
                            public string SpeechCode { get; set; }

                            [NameInMap("Text")]
                            [Validation(Required=true)]
                            public string Text { get; set; }

                            [NameInMap("Voice")]
                            [Validation(Required=true)]
                            public string Voice { get; set; }

                        }

                    }

                }

            }

        }

    }

}
