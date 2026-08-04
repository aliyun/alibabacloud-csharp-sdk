// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class ExistBindsByOuterIdRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("MinorOuterId")]
        [Validation(Required=false)]
        public string MinorOuterId { get; set; }

        [NameInMap("OuterId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
