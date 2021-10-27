// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyData Data { get; set; }
        public class DescribeParametersResponseBodyData : TeaModel {
            [NameInMap("ConfigParameters")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyDataConfigParameters> ConfigParameters { get; set; }
            public class DescribeParametersResponseBodyDataConfigParameters : TeaModel {
                public string ParameterDescription { get; set; }
                public string ParameterName { get; set; }
                public string ParameterValue { get; set; }
            }
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }
            [NameInMap("RunningParameters")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyDataRunningParameters> RunningParameters { get; set; }
            public class DescribeParametersResponseBodyDataRunningParameters : TeaModel {
                public string ParameterDescription { get; set; }
                public string ParameterName { get; set; }
                public string ParameterValue { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
