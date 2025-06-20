// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class QueryBlockEventResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBlockEventResponseBodyData Data { get; set; }
        public class QueryBlockEventResponseBodyData : TeaModel {
            [NameInMap("DataInfo")]
            [Validation(Required=false)]
            public List<QueryBlockEventResponseBodyDataDataInfo> DataInfo { get; set; }
            public class QueryBlockEventResponseBodyDataDataInfo : TeaModel {
                [NameInMap("EmpId")]
                [Validation(Required=false)]
                public string EmpId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("EventTimes")]
                [Validation(Required=false)]
                public List<QueryBlockEventResponseBodyDataDataInfoEventTimes> EventTimes { get; set; }
                public class QueryBlockEventResponseBodyDataDataInfoEventTimes : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("Express")]
                    [Validation(Required=false)]
                    public string Express { get; set; }

                    [NameInMap("Rule")]
                    [Validation(Required=false)]
                    public List<QueryBlockEventResponseBodyDataDataInfoEventTimesRule> Rule { get; set; }
                    public class QueryBlockEventResponseBodyDataDataInfoEventTimesRule : TeaModel {
                        [NameInMap("Level1")]
                        [Validation(Required=false)]
                        public string Level1 { get; set; }

                        [NameInMap("Level2")]
                        [Validation(Required=false)]
                        public string Level2 { get; set; }

                        [NameInMap("Level3")]
                        [Validation(Required=false)]
                        public string Level3 { get; set; }

                        [NameInMap("Level4")]
                        [Validation(Required=false)]
                        public string Level4 { get; set; }

                        [NameInMap("Level5")]
                        [Validation(Required=false)]
                        public string Level5 { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("ruleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("levelType")]
                [Validation(Required=false)]
                public QueryBlockEventResponseBodyDataDataInfoLevelType LevelType { get; set; }
                public class QueryBlockEventResponseBodyDataDataInfoLevelType : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public int? Value { get; set; }

                }

                [NameInMap("versionId")]
                [Validation(Required=false)]
                public long? VersionId { get; set; }

            }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraInfo { get; set; }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public QueryBlockEventResponseBodyDataPagination Pagination { get; set; }
            public class QueryBlockEventResponseBodyDataPagination : TeaModel {
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
