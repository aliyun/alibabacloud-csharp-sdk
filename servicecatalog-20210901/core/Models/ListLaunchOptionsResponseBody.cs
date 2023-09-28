// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListLaunchOptionsResponseBody : TeaModel {
        /// <summary>
        /// The launch options.
        /// </summary>
        [NameInMap("LaunchOptionSummaries")]
        [Validation(Required=false)]
        public List<ListLaunchOptionsResponseBodyLaunchOptionSummaries> LaunchOptionSummaries { get; set; }
        public class ListLaunchOptionsResponseBodyLaunchOptionSummaries : TeaModel {
            /// <summary>
            /// The constraints.
            /// </summary>
            [NameInMap("ConstraintSummaries")]
            [Validation(Required=false)]
            public List<ListLaunchOptionsResponseBodyLaunchOptionSummariesConstraintSummaries> ConstraintSummaries { get; set; }
            public class ListLaunchOptionsResponseBodyLaunchOptionSummariesConstraintSummaries : TeaModel {
                /// <summary>
                /// The type of the constraint. Valid values:
                /// 
                /// 1.  Launch
                /// 2.  Template
                /// 3.  Approval
                /// 4.  StackRegion
                /// </summary>
                [NameInMap("ConstraintType")]
                [Validation(Required=false)]
                public string ConstraintType { get; set; }

                /// <summary>
                /// The description of the constraint.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The types of operations that require approval. If the type of the constraint is Approval, this parameter is not empty.
                /// </summary>
                [NameInMap("OperationTypes")]
                [Validation(Required=false)]
                public List<string> OperationTypes { get; set; }

                /// <summary>
                /// The regions in which users can launch the service. If the type of the constraint is StackRegion, this parameter is not empty.
                /// </summary>
                [NameInMap("StackRegions")]
                [Validation(Required=false)]
                public List<string> StackRegions { get; set; }

            }

            /// <summary>
            /// The ID of the product portfolio.
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// The name of the product portfolio.
            /// </summary>
            [NameInMap("PortfolioName")]
            [Validation(Required=false)]
            public string PortfolioName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
