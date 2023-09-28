// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateConstraintRequest : TeaModel {
        /// <summary>
        /// The configuration of the constraint.
        /// 
        /// Format: { "LocalRoleName": "\<role_name>" }.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The type of the constraint.
        /// 
        /// The value is fixed as Launch, which specifies the launch constraint.
        /// </summary>
        [NameInMap("ConstraintType")]
        [Validation(Required=false)]
        public string ConstraintType { get; set; }

        /// <summary>
        /// The description of the constraint.
        /// 
        /// The value must be 1 to 128 characters in length.
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

    }

}
