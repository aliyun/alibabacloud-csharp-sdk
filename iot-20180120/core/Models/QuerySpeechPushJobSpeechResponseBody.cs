// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechPushJobSpeechResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySpeechPushJobSpeechResponseBodyData Data { get; set; }
        public class QuerySpeechPushJobSpeechResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QuerySpeechPushJobSpeechResponseBodyDataList List { get; set; }
            public class QuerySpeechPushJobSpeechResponseBodyDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<QuerySpeechPushJobSpeechResponseBodyDataListItems> Items { get; set; }
                public class QuerySpeechPushJobSpeechResponseBodyDataListItems : TeaModel {
                    [NameInMap("BizCode")]
                    [Validation(Required=false)]
                    public string BizCode { get; set; }

                    [NameInMap("SpeechList")]
                    [Validation(Required=false)]
                    public QuerySpeechPushJobSpeechResponseBodyDataListItemsSpeechList SpeechList { get; set; }
                    public class QuerySpeechPushJobSpeechResponseBodyDataListItemsSpeechList : TeaModel {
                        [NameInMap("Items")]
                        [Validation(Required=false)]
                        public List<QuerySpeechPushJobSpeechResponseBodyDataListItemsSpeechListItems> Items { get; set; }
                        public class QuerySpeechPushJobSpeechResponseBodyDataListItemsSpeechListItems : TeaModel {
                            [NameInMap("BizCode")]
                            [Validation(Required=false)]
                            public string BizCode { get; set; }

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
