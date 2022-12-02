// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListClustersRequest : TeaModel {
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterStates")]
        [Validation(Required=false)]
        public List<string> ClusterStates { get; set; }

        [NameInMap("ClusterTypes")]
        [Validation(Required=false)]
        public List<string> ClusterTypes { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PaymentTypes")]
        [Validation(Required=false)]
        public List<string> PaymentTypes { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
