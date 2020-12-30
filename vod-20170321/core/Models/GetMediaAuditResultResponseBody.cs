// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MediaAuditResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyMediaAuditResult MediaAuditResult { get; set; }
        public class GetMediaAuditResultResponseBodyMediaAuditResult : TeaModel {
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }
            [NameInMap("ImageResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResult> ImageResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultImageResult : TeaModel {
                public string Type { get; set; }
                public string Suggestion { get; set; }
                public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult> Result { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult : TeaModel {
                    public string Suggestion { get; set; }
                    public string Score { get; set; }
                    public string Label { get; set; }
                    public string Scene { get; set; }
                }
                public string Url { get; set; }
                public string Label { get; set; }
            }
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultAudioResult> AudioResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultAudioResult : TeaModel {
                public string Suggestion { get; set; }
                public string Score { get; set; }
                public string Label { get; set; }
                public string Scene { get; set; }
            }
            [NameInMap("VideoResult")]
            [Validation(Required=false)]
            public GetMediaAuditResultResponseBodyMediaAuditResultVideoResult VideoResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResult : TeaModel {
                [NameInMap("LogoResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult LogoResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult : TeaModel {
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList : TeaModel {
                        public string Url { get; set; }
                        public string Score { get; set; }
                        public string Timestamp { get; set; }
                        public string Label { get; set; }
                    }
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultCounterList : TeaModel {
                        public string Label { get; set; }
                        public int? Count { get; set; }
                    }
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }
                };

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                [NameInMap("LiveResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult LiveResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult : TeaModel {
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList : TeaModel {
                        public string Url { get; set; }
                        public string Score { get; set; }
                        public string Timestamp { get; set; }
                        public string Label { get; set; }
                    }
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultCounterList : TeaModel {
                        public string Label { get; set; }
                        public int? Count { get; set; }
                    }
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }
                };

                [NameInMap("PornResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult PornResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult : TeaModel {
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList : TeaModel {
                        public string Url { get; set; }
                        public string Score { get; set; }
                        public string Timestamp { get; set; }
                        public string Label { get; set; }
                    }
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultCounterList : TeaModel {
                        public string Label { get; set; }
                        public int? Count { get; set; }
                    }
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }
                };

                [NameInMap("AdResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult AdResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult : TeaModel {
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList : TeaModel {
                        public string Url { get; set; }
                        public string Score { get; set; }
                        public string Timestamp { get; set; }
                        public string Label { get; set; }
                    }
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultCounterList : TeaModel {
                        public string Label { get; set; }
                        public int? Count { get; set; }
                    }
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }
                };

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("TerrorismResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult TerrorismResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult : TeaModel {
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList : TeaModel {
                        public string Url { get; set; }
                        public string Score { get; set; }
                        public string Timestamp { get; set; }
                        public string Label { get; set; }
                    }
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList : TeaModel {
                        public string Label { get; set; }
                        public int? Count { get; set; }
                    }
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }
                };

            }
            [NameInMap("AbnormalModules")]
            [Validation(Required=false)]
            public string AbnormalModules { get; set; }
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }
            [NameInMap("TextResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultTextResult> TextResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultTextResult : TeaModel {
                public string Type { get; set; }
                public string Suggestion { get; set; }
                public string Score { get; set; }
                public string Label { get; set; }
                public string Content { get; set; }
                public string Scene { get; set; }
            }
        };

    }

}
