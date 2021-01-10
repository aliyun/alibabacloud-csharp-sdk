// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryAsrJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryAsrJobListResponseBodyJobList JobList { get; set; }
        public class QueryAsrJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryAsrJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryAsrJobListResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public QueryAsrJobListResponseBodyJobListJobAsrConfig AsrConfig { get; set; }
                public class QueryAsrJobListResponseBodyJobListJobAsrConfig : TeaModel {
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                }
                public string PipelineId { get; set; }
                public QueryAsrJobListResponseBodyJobListJobInput Input { get; set; }
                public class QueryAsrJobListResponseBodyJobListJobInput : TeaModel {
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }
                public string Id { get; set; }
                public QueryAsrJobListResponseBodyJobListJobAsrResult AsrResult { get; set; }
                public class QueryAsrJobListResponseBodyJobListJobAsrResult : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("AsrTextList")]
                    [Validation(Required=false)]
                    public QueryAsrJobListResponseBodyJobListJobAsrResultAsrTextList AsrTextList { get; set; }
                    public class QueryAsrJobListResponseBodyJobListJobAsrResultAsrTextList : TeaModel {
                        [NameInMap("AsrText")]
                        [Validation(Required=false)]
                        public List<QueryAsrJobListResponseBodyJobListJobAsrResultAsrTextListAsrText> AsrText { get; set; }
                        public class QueryAsrJobListResponseBodyJobListJobAsrResultAsrTextListAsrText : TeaModel {
                            public string EndTime { get; set; }
                            public int? StartTime { get; set; }
                            public string ChannelId { get; set; }
                            public string Text { get; set; }
                            public string SpeechRate { get; set; }
                        }
                    };

                }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryAsrJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryAsrJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
