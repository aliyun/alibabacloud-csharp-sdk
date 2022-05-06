// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ConfirmNotifyShrinkRequest : TeaModel {
        [NameInMap("Confirmor")]
        [Validation(Required=false)]
        public long? Confirmor { get; set; }

        [NameInMap("NotifyIdList")]
        [Validation(Required=false)]
        public string NotifyIdListShrink { get; set; }

    }

}
