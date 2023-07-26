// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// Details of the parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParametersResponseBodyParameters> Parameters { get; set; }
        public class DescribeParametersResponseBodyParameters : TeaModel {
            /// <summary>
            /// The current value of the parameter.
            /// </summary>
            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            /// <summary>
            /// Indicates whether a restart is required for parameter modifications to take effect. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ForceRestartInstance")]
            [Validation(Required=false)]
            public string ForceRestartInstance { get; set; }

            /// <summary>
            /// Indicates whether the parameter can be modified. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsChangeableConfig")]
            [Validation(Required=false)]
            public string IsChangeableConfig { get; set; }

            /// <summary>
            /// The valid values of the parameter.
            /// </summary>
            [NameInMap("OptionalRange")]
            [Validation(Required=false)]
            public string OptionalRange { get; set; }

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
            /// The default value of the parameter.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
