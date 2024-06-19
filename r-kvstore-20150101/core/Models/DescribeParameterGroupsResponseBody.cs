// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        /// <summary>
        /// The list of parameter templates.
        /// </summary>
        [NameInMap("ParameterGroups")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupsResponseBodyParameterGroups> ParameterGroups { get; set; }
        public class DescribeParameterGroupsResponseBodyParameterGroups : TeaModel {
            /// <summary>
            /// The service category. Valid values:
            /// 
            /// *   **0**: Community Edition
            /// *   **1**: Enhanced Edition (Tair)
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public long? Category { get; set; }

            /// <summary>
            /// The time when the parameter template was created.
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The engine type. Valid values:
            /// 
            /// *   **redis**: Redis or Tair DRAM-based instance
            /// *   **tair_pena**: Tair persistent memory-optimized instance
            /// *   **tair_pdb**: Tair ESSD-based instance
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The compatible engine version.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The time when the parameter template was last modified.
            /// </summary>
            [NameInMap("Modified")]
            [Validation(Required=false)]
            public string Modified { get; set; }

            /// <summary>
            /// The parameter template ID.
            /// </summary>
            [NameInMap("ParamGroupId")]
            [Validation(Required=false)]
            public string ParamGroupId { get; set; }

            /// <summary>
            /// The description of the parameter template.
            /// </summary>
            [NameInMap("ParameterGroupDesc")]
            [Validation(Required=false)]
            public string ParameterGroupDesc { get; set; }

            /// <summary>
            /// The name of the parameter template.
            /// </summary>
            [NameInMap("ParameterGroupName")]
            [Validation(Required=false)]
            public string ParameterGroupName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
