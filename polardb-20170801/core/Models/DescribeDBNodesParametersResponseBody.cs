// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBNodesParametersResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the nodes.
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public List<DescribeDBNodesParametersResponseBodyDBNodeIds> DBNodeIds { get; set; }
        public class DescribeDBNodesParametersResponseBodyDBNodeIds : TeaModel {
            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// The parameters of the current node.
            /// </summary>
            [NameInMap("RunningParameters")]
            [Validation(Required=false)]
            public List<DescribeDBNodesParametersResponseBodyDBNodeIdsRunningParameters> RunningParameters { get; set; }
            public class DescribeDBNodesParametersResponseBodyDBNodeIdsRunningParameters : TeaModel {
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
                /// *   **1**: no. You can customize the nodes to which the modified parameter value can be synchronized to.
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
                /// *   **normal**
                /// *   **modifying**
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

        /// <summary>
        /// The type of the database engine. Set the value to **MySQL**.
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The version of the MySQL database engine. Valid values:
        /// 
        /// *   **5.6**
        /// *   **5.7**
        /// *   **8.0**
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
