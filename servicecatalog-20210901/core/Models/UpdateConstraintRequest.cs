// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateConstraintRequest : TeaModel {
        /// <summary>
        /// The configurations of the constraint.
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
        /// The description of the constraint.
        /// 
        /// The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
