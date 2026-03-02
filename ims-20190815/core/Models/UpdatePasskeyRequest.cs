// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdatePasskeyRequest : TeaModel {
        [NameInMap("PasskeyId")]
        [Validation(Required=false)]
        public string PasskeyId { get; set; }

        [NameInMap("PasskeyName")]
        [Validation(Required=false)]
        public string PasskeyName { get; set; }

        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
