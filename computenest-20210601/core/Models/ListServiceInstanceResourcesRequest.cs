// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceResourcesRequest : TeaModel {
        [NameInMap("ExpireTimeEnd")]
        [Validation(Required=false)]
        public string ExpireTimeEnd { get; set; }

        [NameInMap("ExpireTimeStart")]
        [Validation(Required=false)]
        public string ExpireTimeStart { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceARN")]
        [Validation(Required=false)]
        public List<string> ResourceARN { get; set; }

        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        [NameInMap("ServiceInstanceResourceType")]
        [Validation(Required=false)]
        public string ServiceInstanceResourceType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServiceInstanceResourcesRequestTag> Tag { get; set; }
        public class ListServiceInstanceResourcesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
