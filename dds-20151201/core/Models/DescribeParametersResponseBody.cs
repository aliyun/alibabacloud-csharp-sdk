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
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                [NameInMap("ModifiableStatus")]
                [Validation(Required=false)]
                public bool? ModifiableStatus { get; set; }

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

        }

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
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public string ForceRestart { get; set; }

                [NameInMap("ModifiableStatus")]
                [Validation(Required=false)]
                public string ModifiableStatus { get; set; }

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

        }

    }

}
