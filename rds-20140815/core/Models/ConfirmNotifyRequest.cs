// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ConfirmNotifyRequest : TeaModel {
        [NameInMap("Confirmor")]
        [Validation(Required=false)]
        public long? Confirmor { get; set; }

        [NameInMap("NotifyIdList")]
        [Validation(Required=false)]
        public List<long?> NotifyIdList { get; set; }

    }

}
