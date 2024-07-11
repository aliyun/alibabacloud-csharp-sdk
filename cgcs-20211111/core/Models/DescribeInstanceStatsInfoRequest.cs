// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class DescribeInstanceStatsInfoRequest : TeaModel {
        [NameInMap("DistrictIds")]
        [Validation(Required=false)]
        public List<string> DistrictIds { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public List<string> ProjectIds { get; set; }

    }

}
