// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterParametersResponseBody : TeaModel {
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeDBClusterParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeDBClusterParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeDBClusterParametersResponseBodyRunningParametersParameter> Parameter { get; set; }
            public class DescribeDBClusterParametersResponseBodyRunningParametersParameter : TeaModel {
                public string CheckingCode { get; set; }
                public string DataType { get; set; }
                public string DefaultParameterValue { get; set; }
                public string Factor { get; set; }
                public bool? ForceRestart { get; set; }
                public bool? IsModifiable { get; set; }
                public string IsNodeAvailable { get; set; }
                public string ParamRelyRule { get; set; }
                public string ParameterDescription { get; set; }
                public string ParameterName { get; set; }
                public string ParameterStatus { get; set; }
                public string ParameterValue { get; set; }
            }
        };

    }

}
