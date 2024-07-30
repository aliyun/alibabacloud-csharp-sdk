// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListQualityCheckSchemeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListQualityCheckSchemeResponseBodyData> Data { get; set; }
        public class ListQualityCheckSchemeResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<ListQualityCheckSchemeResponseBodyDataRuleList> RuleList { get; set; }
            public class ListQualityCheckSchemeResponseBodyDataRuleList : TeaModel {
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListQualityCheckSchemeResponseBodyDataRuleListRules> Rules { get; set; }
                public class ListQualityCheckSchemeResponseBodyDataRuleListRules : TeaModel {
                    [NameInMap("CheckType")]
                    [Validation(Required=false)]
                    public int? CheckType { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                    [NameInMap("RuleScoreType")]
                    [Validation(Required=false)]
                    public int? RuleScoreType { get; set; }

                    [NameInMap("ScoreNum")]
                    [Validation(Required=false)]
                    public int? ScoreNum { get; set; }

                    [NameInMap("ScoreNumType")]
                    [Validation(Required=false)]
                    public int? ScoreNumType { get; set; }

                    [NameInMap("ScoreType")]
                    [Validation(Required=false)]
                    public int? ScoreType { get; set; }

                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public int? TargetType { get; set; }

                }

            }

            [NameInMap("SchemeCheckTypeList")]
            [Validation(Required=false)]
            public List<ListQualityCheckSchemeResponseBodyDataSchemeCheckTypeList> SchemeCheckTypeList { get; set; }
            public class ListQualityCheckSchemeResponseBodyDataSchemeCheckTypeList : TeaModel {
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public int? CheckType { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public int? Enable { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public int? TargetType { get; set; }

            }

            [NameInMap("SchemeId")]
            [Validation(Required=false)]
            public long? SchemeId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public int? TemplateType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UpdateUserName")]
            [Validation(Required=false)]
            public string UpdateUserName { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

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

        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
