// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupTemplateListResponseBody : TeaModel {
        /// <summary>
        /// The compatible engine version. Valid values:
        /// 
        /// ApsaraDB for Redis Community Edition: 5.0, 6.0, and 7.0. Tair DRAM-based instances: 5.0 and 6.0. Tair persistent memory-optimized instances: 6.0. Tair ESSD-based instances: 4.0.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The information about parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupTemplateListResponseBodyParameters> Parameters { get; set; }
        public class DescribeParameterGroupTemplateListResponseBodyParameters : TeaModel {
            /// <summary>
            /// The regular expression used to validate input.
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// Indicates whether the modification takes effect. Valid values: 0 and 1. A value of 0 indicates that the modification does not take effect. A value of 1 indicates that the modification takes effect.
            /// </summary>
            [NameInMap("Effective")]
            [Validation(Required=false)]
            public long? Effective { get; set; }

            /// <summary>
            /// A divisor of the parameter. For a parameter of the integer or byte type, the valid values must be a multiple of Factor unless you set Factor to 0.
            /// </summary>
            [NameInMap("Factor")]
            [Validation(Required=false)]
            public long? Factor { get; set; }

            /// <summary>
            /// The description of the parameter.
            /// </summary>
            [NameInMap("ParameterDescription")]
            [Validation(Required=false)]
            public string ParameterDescription { get; set; }

            /// <summary>
            /// The parameter name.
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// The default value of the parameter.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

            /// <summary>
            /// Indicates whether the parameter can be modified. Valid values:
            /// 
            /// *   **0: The parameter cannot be modified.**
            /// *   **1**: The parameter can be modified.
            /// </summary>
            [NameInMap("Revisable")]
            [Validation(Required=false)]
            public long? Revisable { get; set; }

            /// <summary>
            /// Indicates whether the minor version can be changed. Valid values: true and false.
            /// </summary>
            [NameInMap("SupportModifyForMinorVersion")]
            [Validation(Required=false)]
            public bool? SupportModifyForMinorVersion { get; set; }

            /// <summary>
            /// The unit of the parameter value. Valid values: INT (ordinary integer), STRING (fixed string), and B (byte).
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
