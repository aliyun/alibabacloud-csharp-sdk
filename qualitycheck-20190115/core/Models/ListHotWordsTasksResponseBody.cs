// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListHotWordsTasksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHotWordsTasksResponseBodyData Data { get; set; }
        public class ListHotWordsTasksResponseBodyData : TeaModel {
            [NameInMap("HotWordsTaskPo")]
            [Validation(Required=false)]
            public List<ListHotWordsTasksResponseBodyDataHotWordsTaskPo> HotWordsTaskPo { get; set; }
            public class ListHotWordsTasksResponseBodyDataHotWordsTaskPo : TeaModel {
                public ListHotWordsTasksResponseBodyDataHotWordsTaskPoDialogueParam DialogueParam { get; set; }
                public class ListHotWordsTasksResponseBodyDataHotWordsTaskPoDialogueParam : TeaModel {
                    [NameInMap("DataSetIds")]
                    [Validation(Required=false)]
                    public string DataSetIds { get; set; }

                    [NameInMap("DialogueId")]
                    [Validation(Required=false)]
                    public long? DialogueId { get; set; }

                    [NameInMap("EndIndex")]
                    [Validation(Required=false)]
                    public int? EndIndex { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public int? Role { get; set; }

                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public int? SourceType { get; set; }

                    [NameInMap("StartIndex")]
                    [Validation(Required=false)]
                    public int? StartIndex { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }
                public string EndTime { get; set; }
                public int? InstanceStatus { get; set; }
                public string LastExecutionTime { get; set; }
                public string Message { get; set; }
                public string Name { get; set; }
                public string StartTime { get; set; }
                public int? Status { get; set; }
                public long? TaskConfigId { get; set; }
                public int? TimeInterval { get; set; }
                public int? TimeUnit { get; set; }
                public int? Type { get; set; }
                public ListHotWordsTasksResponseBodyDataHotWordsTaskPoWordsParam WordsParam { get; set; }
                public class ListHotWordsTasksResponseBodyDataHotWordsTaskPoWordsParam : TeaModel {
                    [NameInMap("Excludes")]
                    [Validation(Required=false)]
                    public string Excludes { get; set; }

                    [NameInMap("ExtraConfigId")]
                    [Validation(Required=false)]
                    public long? ExtraConfigId { get; set; }

                    [NameInMap("Includes")]
                    [Validation(Required=false)]
                    public string Includes { get; set; }

                }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
