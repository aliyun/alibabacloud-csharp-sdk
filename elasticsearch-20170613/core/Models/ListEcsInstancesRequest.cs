// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEcsInstancesRequest : TeaModel {
        /// <summary>
        /// test
        /// </summary>
        [NameInMap("ecsInstanceIds")]
        [Validation(Required=false)]
        public string EcsInstanceIds { get; set; }

        /// <summary>
        /// \[{ "tagKey":"a","tagValue":"b"}]
        /// </summary>
        [NameInMap("ecsInstanceName")]
        [Validation(Required=false)]
        public string EcsInstanceName { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// \["i-bp13y63575oypr9d\*\*\*\*","i-bp1gyhphjaj73jsr\*\*\*\*"]
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// vpc-bp16k1dvzxtmagcva\*\*\*\*
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
