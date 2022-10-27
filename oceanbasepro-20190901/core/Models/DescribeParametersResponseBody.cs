// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParametersResponseBodyParameters> Parameters { get; set; }
        public class DescribeParametersResponseBodyParameters : TeaModel {
            [NameInMap("AcceptableValue")]
            [Validation(Required=false)]
            public List<string> AcceptableValue { get; set; }

            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NeedReboot")]
            [Validation(Required=false)]
            public bool? NeedReboot { get; set; }

            [NameInMap("RejectedValue")]
            [Validation(Required=false)]
            public List<string> RejectedValue { get; set; }

            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
