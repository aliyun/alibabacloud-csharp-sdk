// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechPushJobSpeechResponse : TeaModel {
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
        public QuerySpeechPushJobSpeechResponseData Data { get; set; }
        public class QuerySpeechPushJobSpeechResponseData : TeaModel {
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
            public QuerySpeechPushJobSpeechResponseDataList List { get; set; }
            public class QuerySpeechPushJobSpeechResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QuerySpeechPushJobSpeechResponseDataListItems> Items { get; set; }
                public class QuerySpeechPushJobSpeechResponseDataListItems : TeaModel {
                    [NameInMap("BizCode")]
                    [Validation(Required=true)]
                    public string BizCode { get; set; }

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
                    public QuerySpeechPushJobSpeechResponseDataListItemsSpeechList SpeechList { get; set; }
                    public class QuerySpeechPushJobSpeechResponseDataListItemsSpeechList : TeaModel {
                        [NameInMap("Items")]
                        [Validation(Required=true)]
                        public List<QuerySpeechPushJobSpeechResponseDataListItemsSpeechListItems> Items { get; set; }
                        public class QuerySpeechPushJobSpeechResponseDataListItemsSpeechListItems : TeaModel {
                            [NameInMap("BizCode")]
                            [Validation(Required=true)]
                            public string BizCode { get; set; }

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
