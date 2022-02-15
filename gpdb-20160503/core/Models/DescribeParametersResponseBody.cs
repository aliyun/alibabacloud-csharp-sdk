// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParametersResponseBodyParameters> Parameters { get; set; }
        public class DescribeParametersResponseBodyParameters : TeaModel {
            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            [NameInMap("ForceRestartInstance")]
            [Validation(Required=false)]
            public string ForceRestartInstance { get; set; }

            [NameInMap("IsChangeableConfig")]
            [Validation(Required=false)]
            public string IsChangeableConfig { get; set; }

            [NameInMap("OptionalRange")]
            [Validation(Required=false)]
            public string OptionalRange { get; set; }

            [NameInMap("ParameterDescription")]
            [Validation(Required=false)]
            public string ParameterDescription { get; set; }

            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
