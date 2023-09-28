// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class DisassociatePrincipalFromPortfolioRequest : TeaModel {
        /// <summary>
        /// The ID of the product portfolio.
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// The ID of the RAM entity.
        /// 
        /// For more information about how to obtain the ID of a RAM user, see [GetUser](~~28681~~).
        /// 
        /// For more information about how to obtain the ID of a RAM role, see [GetRole](~~28711~~).
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// The type of the Resource Access Management (RAM) entity. Valid values:
        /// 
        /// *   RamUser: a RAM user
        /// *   RamRole: a RAM role
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

    }

}
