// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateIpSetsRequest : TeaModel {
        [NameInMap("IpSets")]
        [Validation(Required=false)]
        public List<UpdateIpSetsRequestIpSets> IpSets { get; set; }
        public class UpdateIpSetsRequestIpSets : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
