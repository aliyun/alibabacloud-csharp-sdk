// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksBloodRelationshipResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryWorksBloodRelationshipResponseBodyResult> Result { get; set; }
        public class QueryWorksBloodRelationshipResponseBodyResult : TeaModel {
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public int? ComponentType { get; set; }

            [NameInMap("ComponentTypeName")]
            [Validation(Required=false)]
            public string ComponentTypeName { get; set; }

            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public List<QueryWorksBloodRelationshipResponseBodyResultQueryParams> QueryParams { get; set; }
            public class QueryWorksBloodRelationshipResponseBodyResultQueryParams : TeaModel {
                [NameInMap("AreaId")]
                [Validation(Required=false)]
                public string AreaId { get; set; }

                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("IsMeasure")]
                [Validation(Required=false)]
                public bool? IsMeasure { get; set; }

                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
