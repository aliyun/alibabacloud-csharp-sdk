// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEcsInstancesRequest : TeaModel {
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("ecsInstanceIds")]
        [Validation(Required=false)]
        public string EcsInstanceIds { get; set; }

        [NameInMap("ecsInstanceName")]
        [Validation(Required=false)]
        public string EcsInstanceName { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
