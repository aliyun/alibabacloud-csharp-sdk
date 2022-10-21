// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListNodeGroupsRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("NodeGroupIds")]
        [Validation(Required=false)]
        public List<string> NodeGroupIds { get; set; }

        [NameInMap("NodeGroupNames")]
        [Validation(Required=false)]
        public List<string> NodeGroupNames { get; set; }

        [NameInMap("NodeGroupStates")]
        [Validation(Required=false)]
        public List<string> NodeGroupStates { get; set; }

        [NameInMap("NodeGroupTypes")]
        [Validation(Required=false)]
        public List<string> NodeGroupTypes { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
