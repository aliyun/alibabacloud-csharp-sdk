// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        [NameInMap("ConfigParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyConfigParameters ConfigParameters { get; set; }
        public class DescribeParametersResponseBodyConfigParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyConfigParametersParameter> Parameter { get; set; }
            public class DescribeParametersResponseBodyConfigParametersParameter : TeaModel {
                public string CheckingCode { get; set; }
                public bool? ForceRestart { get; set; }
                public bool? ModifiableStatus { get; set; }
                public string ParameterDescription { get; set; }
                public string ParameterName { get; set; }
                public string ParameterValue { get; set; }
            }
        };

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyRunningParametersParameter> Parameter { get; set; }
            public class DescribeParametersResponseBodyRunningParametersParameter : TeaModel {
                public string CheckingCode { get; set; }
                public string ForceRestart { get; set; }
                public string ModifiableStatus { get; set; }
                public string ParameterDescription { get; set; }
                public string ParameterName { get; set; }
                public string ParameterValue { get; set; }
            }
        };

    }

}
