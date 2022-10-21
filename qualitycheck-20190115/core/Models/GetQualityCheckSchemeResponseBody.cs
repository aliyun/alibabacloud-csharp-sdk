// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetQualityCheckSchemeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityCheckSchemeResponseBodyData Data { get; set; }
        public class GetQualityCheckSchemeResponseBodyData : TeaModel {
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

            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public List<string> RuleIds { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<RulesInfo> RuleList { get; set; }

            [NameInMap("SchemeCheckTypeList")]
            [Validation(Required=false)]
            public List<GetQualityCheckSchemeResponseBodyDataSchemeCheckTypeList> SchemeCheckTypeList { get; set; }
            public class GetQualityCheckSchemeResponseBodyDataSchemeCheckTypeList : TeaModel {
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public long? CheckType { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public int? Enable { get; set; }

                [NameInMap("SchemeId")]
                [Validation(Required=false)]
                public long? SchemeId { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("SourceScore")]
                [Validation(Required=false)]
                public int? SourceScore { get; set; }

            }

            [NameInMap("SchemeId")]
            [Validation(Required=false)]
            public long? SchemeId { get; set; }

            [NameInMap("SchemeTemplateId")]
            [Validation(Required=false)]
            public long? SchemeTemplateId { get; set; }

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

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<string> Messages { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
