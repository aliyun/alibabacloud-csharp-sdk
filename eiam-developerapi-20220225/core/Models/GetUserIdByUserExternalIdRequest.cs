// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetUserIdByUserExternalIdRequest : TeaModel {
        [NameInMap("userExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        [NameInMap("userSourceId")]
        [Validation(Required=false)]
        public string UserSourceId { get; set; }

        [NameInMap("userSourceType")]
        [Validation(Required=false)]
        public string UserSourceType { get; set; }

    }

}
