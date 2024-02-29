// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterParametersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The database engine that the cluster runs. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **PostgreSQL**
        /// *   **Oracle**
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The version of the database engine. 
        /// 
        /// - Valid values for the MySQL database engine:    - **5.6**
        ///   - **5.7**
        ///   - **8.0**
        /// - Valid value for the PostgreSQL database engine:    - **11**
        ///   - **14**
        /// - Valid value for the Oracle database engine: **11**
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// The cluster engine.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The number of parameters.
        /// </summary>
        [NameInMap("ParameterNumbers")]
        [Validation(Required=false)]
        public string ParameterNumbers { get; set; }

        /// <summary>
        /// A comparison between the current parameters of the PolarDB cluster and the parameters of the source RDS instance before migration.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeDBClusterParametersResponseBodyParameters Parameters { get; set; }
        public class DescribeDBClusterParametersResponseBodyParameters : TeaModel {
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeDBClusterParametersResponseBodyParametersParameters> Parameters { get; set; }
            public class DescribeDBClusterParametersResponseBodyParametersParameters : TeaModel {
                /// <summary>
                /// Indicates whether the source parameters and current parameters have the same value.
                /// </summary>
                [NameInMap("IsEqual")]
                [Validation(Required=false)]
                public string IsEqual { get; set; }

                [NameInMap("IsInstancePolarDBKey")]
                [Validation(Required=false)]
                public string IsInstancePolarDBKey { get; set; }

                [NameInMap("IsInstanceRdsKey")]
                [Validation(Required=false)]
                public string IsInstanceRdsKey { get; set; }

                [NameInMap("IsPolarDBKey")]
                [Validation(Required=false)]
                public string IsPolarDBKey { get; set; }

                [NameInMap("IsRdsKey")]
                [Validation(Required=false)]
                public string IsRdsKey { get; set; }

                /// <summary>
                /// The description of the parameter of the current cluster.
                /// </summary>
                [NameInMap("distParameterDescription")]
                [Validation(Required=false)]
                public string DistParameterDescription { get; set; }

                /// <summary>
                /// The name of the parameter of the current cluster.
                /// </summary>
                [NameInMap("distParameterName")]
                [Validation(Required=false)]
                public string DistParameterName { get; set; }

                /// <summary>
                /// The valid values of the parameter of the current cluster.
                /// </summary>
                [NameInMap("distParameterOptional")]
                [Validation(Required=false)]
                public string DistParameterOptional { get; set; }

                /// <summary>
                /// The value of the parameter of the current cluster.
                /// </summary>
                [NameInMap("distParameterValue")]
                [Validation(Required=false)]
                public string DistParameterValue { get; set; }

                /// <summary>
                /// The description of the parameter of the source instance.
                /// </summary>
                [NameInMap("rdsParameterDescription")]
                [Validation(Required=false)]
                public string RdsParameterDescription { get; set; }

                /// <summary>
                /// The name of the parameter of the source instance.
                /// </summary>
                [NameInMap("rdsParameterName")]
                [Validation(Required=false)]
                public string RdsParameterName { get; set; }

                /// <summary>
                /// The valid values of the parameter of the source instance.
                /// </summary>
                [NameInMap("rdsParameterOptional")]
                [Validation(Required=false)]
                public string RdsParameterOptional { get; set; }

                /// <summary>
                /// The value of the parameter of the source instance.
                /// </summary>
                [NameInMap("rdsParameterValue")]
                [Validation(Required=false)]
                public string RdsParameterValue { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The parameters that are in use.
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public DescribeDBClusterParametersResponseBodyRunningParameters RunningParameters { get; set; }
        public class DescribeDBClusterParametersResponseBodyRunningParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeDBClusterParametersResponseBodyRunningParametersParameter> Parameter { get; set; }
            public class DescribeDBClusterParametersResponseBodyRunningParametersParameter : TeaModel {
                /// <summary>
                /// The valid values of the parameter.
                /// </summary>
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                /// <summary>
                /// The data type of the parameter value. Valid values:
                /// 
                /// *   **INT**
                /// *   **STRING**
                /// *   **B**
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// The default value of the parameter.
                /// </summary>
                [NameInMap("DefaultParameterValue")]
                [Validation(Required=false)]
                public string DefaultParameterValue { get; set; }

                /// <summary>
                /// A divisor of the parameter. For a parameter of the integer or byte type, the valid values must be a multiple of Factor unless you set Factor to 0.
                /// </summary>
                [NameInMap("Factor")]
                [Validation(Required=false)]
                public string Factor { get; set; }

                /// <summary>
                /// Indicates whether a cluster restart is required to allow the parameter modification to take effect. Valid values:
                /// 
                /// *   **false**
                /// *   **true**
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public bool? ForceRestart { get; set; }

                /// <summary>
                /// Indicates whether the parameter can be modified. Valid values:
                /// 
                /// *   **false**
                /// *   **true**
                /// </summary>
                [NameInMap("IsModifiable")]
                [Validation(Required=false)]
                public bool? IsModifiable { get; set; }

                /// <summary>
                /// Indicates whether the parameter is a global parameter. Valid values:
                /// 
                /// *   **0**: yes. The modified parameter value is synchronized to other nodes.
                /// *   **1**: no. You can customize the nodes to which the modified parameter value can be synchronized.
                /// </summary>
                [NameInMap("IsNodeAvailable")]
                [Validation(Required=false)]
                public string IsNodeAvailable { get; set; }

                /// <summary>
                /// The dependencies of the parameter.
                /// </summary>
                [NameInMap("ParamRelyRule")]
                [Validation(Required=false)]
                public string ParamRelyRule { get; set; }

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
                /// The status of the parameter. Valid values:
                /// 
                /// *   **Normal**
                /// *   **Modifying**
                /// </summary>
                [NameInMap("ParameterStatus")]
                [Validation(Required=false)]
                public string ParameterStatus { get; set; }

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
