// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class InitDtsRdsInstanceRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("EndpointInstanceType")]
        [Validation(Required=false)]
        public string EndpointInstanceType { get; set; }

        [NameInMap("EndpointRegion")]
        [Validation(Required=false)]
        public string EndpointRegion { get; set; }

        [NameInMap("EndpointInstanceId")]
        [Validation(Required=false)]
        public string EndpointInstanceId { get; set; }

        [NameInMap("EndpointCenId")]
        [Validation(Required=false)]
        public string EndpointCenId { get; set; }

    }

}
