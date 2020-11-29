// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeParametersResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=true)]
        public List<DescribeParametersResponseParameters> Parameters { get; set; }
        public class DescribeParametersResponseParameters : TeaModel {
            [NameInMap("ParameterName")]
            [Validation(Required=true)]
            public string ParameterName { get; set; }

            [NameInMap("ParameterValue")]
            [Validation(Required=true)]
            public string ParameterValue { get; set; }

            [NameInMap("CurrentValue")]
            [Validation(Required=true)]
            public string CurrentValue { get; set; }

            [NameInMap("ParameterDescription")]
            [Validation(Required=true)]
            public string ParameterDescription { get; set; }

            [NameInMap("ForceRestartInstance")]
            [Validation(Required=true)]
            public string ForceRestartInstance { get; set; }

            [NameInMap("IsChangeableConfig")]
            [Validation(Required=true)]
            public string IsChangeableConfig { get; set; }

            [NameInMap("OptionalRange")]
            [Validation(Required=true)]
            public string OptionalRange { get; set; }

        }

    }

}
