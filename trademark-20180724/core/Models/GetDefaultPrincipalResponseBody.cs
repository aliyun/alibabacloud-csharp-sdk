// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class GetDefaultPrincipalResponseBody : TeaModel {
        [NameInMap("PrincipalDescription")]
        [Validation(Required=false)]
        public string PrincipalDescription { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        [NameInMap("PrincipalValue")]
        [Validation(Required=false)]
        public int? PrincipalValue { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
