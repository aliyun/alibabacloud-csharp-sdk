// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        [NameInMap("ConfigParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyConfigParameters ConfigParameters { get; set; }
        public class DescribeParametersResponseBodyConfigParameters : TeaModel {
            [NameInMap("DBInstanceParameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyConfigParametersDBInstanceParameter> DBInstanceParameter { get; set; }
            public class DescribeParametersResponseBodyConfigParametersDBInstanceParameter : TeaModel {
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

        [NameInMap("ParamGroupInfo")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyParamGroupInfo ParamGroupInfo { get; set; }
        public class DescribeParametersResponseBodyParamGroupInfo : TeaModel {
            [NameInMap("ParamGroupId")]
            [Validation(Required=false)]
            public string ParamGroupId { get; set; }

            [NameInMap("ParameterGroupDesc")]
            [Validation(Required=false)]
            public string ParameterGroupDesc { get; set; }

            [NameInMap("ParameterGroupName")]
            [Validation(Required=false)]
            public string ParameterGroupName { get; set; }

            [NameInMap("ParameterGroupType")]
            [Validation(Required=false)]
            public string ParameterGroupType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("DBInstanceParameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyRunningParametersDBInstanceParameter> DBInstanceParameter { get; set; }
            public class DescribeParametersResponseBodyRunningParametersDBInstanceParameter : TeaModel {
                [NameInMap("ParameterDefaultValue")]
                [Validation(Required=false)]
                public string ParameterDefaultValue { get; set; }

                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

                [NameInMap("ParameterValueRange")]
                [Validation(Required=false)]
                public string ParameterValueRange { get; set; }

            }

        }

    }

}
