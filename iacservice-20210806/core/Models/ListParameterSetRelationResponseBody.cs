// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListParameterSetRelationResponseBody : TeaModel {
        [NameInMap("parameterSets")]
        [Validation(Required=false)]
        public List<ListParameterSetRelationResponseBodyParameterSets> ParameterSets { get; set; }
        public class ListParameterSetRelationResponseBodyParameterSets : TeaModel {
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
            public Dictionary<string, string> Parameters { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
