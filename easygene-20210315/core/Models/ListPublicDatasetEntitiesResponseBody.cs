// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListPublicDatasetEntitiesResponseBody : TeaModel {
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("Entities")]
        [Validation(Required=false)]
        public List<ListPublicDatasetEntitiesResponseBodyEntities> Entities { get; set; }
        public class ListPublicDatasetEntitiesResponseBodyEntities : TeaModel {
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
