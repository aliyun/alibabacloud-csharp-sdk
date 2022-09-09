// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListParameterSetsResponseBody : TeaModel {
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("parameterSets")]
        [Validation(Required=false)]
        public List<ListParameterSetsResponseBodyParameterSets> ParameterSets { get; set; }
        public class ListParameterSetsResponseBodyParameterSets : TeaModel {
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
            public List<ListParameterSetsResponseBodyParameterSetsParameters> Parameters { get; set; }
            public class ListParameterSetsResponseBodyParameterSetsParameters : TeaModel {
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
            public List<ListParameterSetsResponseBodyParameterSetsRelationList> RelationList { get; set; }
            public class ListParameterSetsResponseBodyParameterSetsRelationList : TeaModel {
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

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
