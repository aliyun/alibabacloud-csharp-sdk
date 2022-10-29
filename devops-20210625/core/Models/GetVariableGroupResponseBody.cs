// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetVariableGroupResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("variableGroup")]
        [Validation(Required=false)]
        public GetVariableGroupResponseBodyVariableGroup VariableGroup { get; set; }
        public class GetVariableGroupResponseBodyVariableGroup : TeaModel {
            [NameInMap("ccreatorAccountId")]
            [Validation(Required=false)]
            public string CcreatorAccountId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("relatedPipelines")]
            [Validation(Required=false)]
            public List<GetVariableGroupResponseBodyVariableGroupRelatedPipelines> RelatedPipelines { get; set; }
            public class GetVariableGroupResponseBodyVariableGroupRelatedPipelines : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<GetVariableGroupResponseBodyVariableGroupVariables> Variables { get; set; }
            public class GetVariableGroupResponseBodyVariableGroupVariables : TeaModel {
                [NameInMap("isEncrypted")]
                [Validation(Required=false)]
                public bool? IsEncrypted { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
