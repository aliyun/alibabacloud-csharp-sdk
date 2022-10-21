// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListNodesRequest : TeaModel {
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

        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        [NameInMap("NodeStates")]
        [Validation(Required=false)]
        public List<string> NodeStates { get; set; }

        [NameInMap("PrivateIps")]
        [Validation(Required=false)]
        public List<string> PrivateIps { get; set; }

        [NameInMap("PublicIps")]
        [Validation(Required=false)]
        public List<string> PublicIps { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
