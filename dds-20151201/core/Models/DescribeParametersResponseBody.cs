// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// The settings of parameters that are being configured.
        /// </summary>
        [NameInMap("ConfigParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyConfigParameters ConfigParameters { get; set; }
        public class DescribeParametersResponseBodyConfigParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyConfigParametersParameter> Parameter { get; set; }
            public class DescribeParametersResponseBodyConfigParametersParameter : TeaModel {
                /// <summary>
                /// The valid values of the parameter.
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// Indicates whether a restart is required for parameter modifications to take effect. Valid values:
                /// 
                /// *   **false**: A restart is not required. Modifications take effect immediately.
                /// *   **true**: A restart is required for parameter modifications to take effect.
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                /// <summary>
                /// Indicates whether the parameter value can be modified. Valid values:
                /// 
                /// *   **false**: The parameter value cannot be modified.
                /// *   **true**: The parameter value can be modified.
                /// </summary>
                [NameInMap("ModifiableStatus")]
                [Validation(Required=false)]
                public bool? ModifiableStatus { get; set; }

                /// <summary>
                /// The description of the parameter.
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        /// <summary>
        /// The database engine of the instance. Default value: **mongodb**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version of the instance.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The settings of the parameters that have taken effect.
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyRunningParametersParameter> Parameter { get; set; }
            public class DescribeParametersResponseBodyRunningParametersParameter : TeaModel {
                /// <summary>
                /// The role of the instance. Valid values:
                /// 
                /// *   **db**: a shard node.
                /// *   **cs**: a Configserver node.
                /// *   **mongos**: a mongos node.
                /// </summary>
                [NameInMap("CharacterType")]
                [Validation(Required=false)]
                public string CharacterType { get; set; }

                /// <summary>
                /// The valid values of the parameter.
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// Indicates whether a restart is required for parameter modifications to take effect. Valid values:
                /// 
                /// *   **false**: A restart is not required. Modifications take effect immediately.
                /// *   **true**: A restart is required for parameter modifications to take effect.
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public string ForceRestart { get; set; }

                /// <summary>
                /// Indicates whether the parameter value can be modified. Valid values:
                /// 
                /// *   **false**: The parameter value cannot be modified.
                /// *   **true**: The parameter value can be modified.
                /// </summary>
                [NameInMap("ModifiableStatus")]
                [Validation(Required=false)]
                public string ModifiableStatus { get; set; }

                /// <summary>
                /// The description of the parameter.
                /// </summary>
                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

    }

}
