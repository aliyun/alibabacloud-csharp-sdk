// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class EditPhotoStoreRequest : TeaModel {
        [NameInMap("AutoCleanEnabled")]
        [Validation(Required=false)]
        public string AutoCleanEnabled { get; set; }

        [NameInMap("AutoCleanDays")]
        [Validation(Required=false)]
        public int? AutoCleanDays { get; set; }

        [NameInMap("DefaultQuota")]
        [Validation(Required=false)]
        public long? DefaultQuota { get; set; }

        [NameInMap("DefaultTrashQuota")]
        [Validation(Required=false)]
        public long? DefaultTrashQuota { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

    }

}
