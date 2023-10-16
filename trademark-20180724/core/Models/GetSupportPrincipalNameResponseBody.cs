// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class GetSupportPrincipalNameResponseBody : TeaModel {
        [NameInMap("Principals")]
        [Validation(Required=false)]
        public List<GetSupportPrincipalNameResponseBodyPrincipals> Principals { get; set; }
        public class GetSupportPrincipalNameResponseBodyPrincipals : TeaModel {
            [NameInMap("DefaultPrincipal")]
            [Validation(Required=false)]
            public bool? DefaultPrincipal { get; set; }

            [NameInMap("PrincipalDescription")]
            [Validation(Required=false)]
            public string PrincipalDescription { get; set; }

            [NameInMap("PrincipalValue")]
            [Validation(Required=false)]
            public int? PrincipalValue { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
