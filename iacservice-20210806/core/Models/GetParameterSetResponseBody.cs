// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetParameterSetResponseBody : TeaModel {
        [NameInMap("parameterSet")]
        [Validation(Required=false)]
        public GetParameterSetResponseBodyParameterSet ParameterSet { get; set; }
        public class GetParameterSetResponseBodyParameterSet : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parameterSetId")]
            [Validation(Required=false)]
            public string ParameterSetId { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetParameterSetResponseBodyParameterSetParameters> Parameters { get; set; }
            public class GetParameterSetResponseBodyParameterSetParameters : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            [NameInMap("relationList")]
            [Validation(Required=false)]
            public List<GetParameterSetResponseBodyParameterSetRelationList> RelationList { get; set; }
            public class GetParameterSetResponseBodyParameterSetRelationList : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
