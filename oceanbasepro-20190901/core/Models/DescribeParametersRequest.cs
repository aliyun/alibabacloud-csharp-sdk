// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersRequest : TeaModel {
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        [NameInMap("DimensionValue")]
        [Validation(Required=false)]
        public string DimensionValue { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
