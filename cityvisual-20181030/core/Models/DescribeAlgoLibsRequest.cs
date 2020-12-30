// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeAlgoLibsRequest : TeaModel {
        [NameInMap("AlgoLibName")]
        [Validation(Required=false)]
        public string AlgoLibName { get; set; }

        [NameInMap("CapabilityName")]
        [Validation(Required=false)]
        public string CapabilityName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AlgoLibId")]
        [Validation(Required=false)]
        public string AlgoLibId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
