// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListPrincipalsResponseBody : TeaModel {
        /// <summary>
        /// The RAM entities.
        /// </summary>
        [NameInMap("Principals")]
        [Validation(Required=false)]
        public List<ListPrincipalsResponseBodyPrincipals> Principals { get; set; }
        public class ListPrincipalsResponseBodyPrincipals : TeaModel {
            /// <summary>
            /// The ID of the RAM entity.
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// The type of the RAM entity. Valid values:
            /// 
            /// *   RamUser: a RAM user
            /// *   RamRole: a RAM role
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
