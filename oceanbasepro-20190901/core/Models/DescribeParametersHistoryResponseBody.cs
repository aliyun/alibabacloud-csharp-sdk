// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersHistoryResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of parameter modification records.
        /// </summary>
        [NameInMap("Respond")]
        [Validation(Required=false)]
        public List<DescribeParametersHistoryResponseBodyRespond> Respond { get; set; }
        public class DescribeParametersHistoryResponseBodyRespond : TeaModel {
            /// <summary>
            /// The number of returned entries on each page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The parameter modification history.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeParametersHistoryResponseBodyRespondParameters> Parameters { get; set; }
            public class DescribeParametersHistoryResponseBodyRespondParameters : TeaModel {
                /// <summary>
                /// The time when the parameter modification was initiated.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The resource ID of the parameter type.    
                /// - When you called this operation to query the modification history of cluster parameters, the value is DEFAULT_DIMENSION_VALUE.   
                /// - When you called this operation to query the modification history of tenant parameters, the value is the tenant ID.
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the parameter after the modification.
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// The parameter value before modification.
                /// </summary>
                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

                /// <summary>
                /// The modification status. Valid values:    
                /// - APPLIED: The modification was successful.   
                /// - SCHEDULING: The modification was to be made.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the parameter modification took effect.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// The number of parameter modification records.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
