// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class QueryCheckInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCheckInfoResponseBodyData Data { get; set; }
        public class QueryCheckInfoResponseBodyData : TeaModel {
            [NameInMap("CheckDetailList")]
            [Validation(Required=false)]
            public List<QueryCheckInfoResponseBodyDataCheckDetailList> CheckDetailList { get; set; }
            public class QueryCheckInfoResponseBodyDataCheckDetailList : TeaModel {
                [NameInMap("BlockRule")]
                [Validation(Required=false)]
                public List<QueryCheckInfoResponseBodyDataCheckDetailListBlockRule> BlockRule { get; set; }
                public class QueryCheckInfoResponseBodyDataCheckDetailListBlockRule : TeaModel {
                    [NameInMap("BlockHarm")]
                    [Validation(Required=false)]
                    public string BlockHarm { get; set; }

                    [NameInMap("BlockId")]
                    [Validation(Required=false)]
                    public long? BlockId { get; set; }

                    [NameInMap("Express")]
                    [Validation(Required=false)]
                    public string Express { get; set; }

                    [NameInMap("ScopeEndTime")]
                    [Validation(Required=false)]
                    public long? ScopeEndTime { get; set; }

                    [NameInMap("ScopeNodeList")]
                    [Validation(Required=false)]
                    public List<QueryCheckInfoResponseBodyDataCheckDetailListBlockRuleScopeNodeList> ScopeNodeList { get; set; }
                    public class QueryCheckInfoResponseBodyDataCheckDetailListBlockRuleScopeNodeList : TeaModel {
                        [NameInMap("LeafLevel")]
                        [Validation(Required=false)]
                        public string LeafLevel { get; set; }

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

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public long? RuleId { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("ScopeRuleId")]
                    [Validation(Required=false)]
                    public long? ScopeRuleId { get; set; }

                    [NameInMap("ScopeStartTime")]
                    [Validation(Required=false)]
                    public long? ScopeStartTime { get; set; }

                }

                [NameInMap("CheckholdReason")]
                [Validation(Required=false)]
                public string CheckholdReason { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("PicInfo")]
                [Validation(Required=false)]
                public string PicInfo { get; set; }

                [NameInMap("RiskExplain")]
                [Validation(Required=false)]
                public string RiskExplain { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("CheckResultUrl")]
            [Validation(Required=false)]
            public string CheckResultUrl { get; set; }

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
