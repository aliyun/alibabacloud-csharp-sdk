// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMSDdcsResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<QueryMSDdcsResourcesResponseBodyResources> Resources { get; set; }
        public class QueryMSDdcsResourcesResponseBodyResources : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<QueryMSDdcsResourcesResponseBodyResourcesAttributes> Attributes { get; set; }
            public class QueryMSDdcsResourcesResponseBodyResourcesAttributes : TeaModel {
                [NameInMap("AttributeName")]
                [Validation(Required=false)]
                public string AttributeName { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

    }

}
