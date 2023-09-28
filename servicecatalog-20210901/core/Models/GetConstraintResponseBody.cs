// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetConstraintResponseBody : TeaModel {
        /// <summary>
        /// The details of the constraint.
        /// </summary>
        [NameInMap("ConstraintDetail")]
        [Validation(Required=false)]
        public GetConstraintResponseBodyConstraintDetail ConstraintDetail { get; set; }
        public class GetConstraintResponseBodyConstraintDetail : TeaModel {
            /// <summary>
            /// The configuration of the constraint.
            /// 
            /// Format: { "LocalRoleName": "\<role_name>" }.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The ID of the constraint.
            /// </summary>
            [NameInMap("ConstraintId")]
            [Validation(Required=false)]
            public string ConstraintId { get; set; }

            /// <summary>
            /// The type of the constraint.
            /// 
            /// The value is fixed as Launch, which indicates the launch constraint.
            /// </summary>
            [NameInMap("ConstraintType")]
            [Validation(Required=false)]
            public string ConstraintType { get; set; }

            /// <summary>
            /// The time when the constraint was created.
            /// 
            /// The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the constraint.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the product portfolio to which the constraint belongs.
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// The ID of the product for which the constraint is created.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The name of the product.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
