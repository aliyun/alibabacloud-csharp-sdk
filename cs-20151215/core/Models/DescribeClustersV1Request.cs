// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1Request : TeaModel {
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
