// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UserQuotaPermission : TeaModel {
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<string> Permissions { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

    }

}
