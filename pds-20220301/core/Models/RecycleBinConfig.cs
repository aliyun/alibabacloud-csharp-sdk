// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class RecycleBinConfig : TeaModel {
        [NameInMap("auto_delete_enabled")]
        [Validation(Required=false)]
        public bool? AutoDeleteEnabled { get; set; }

        [NameInMap("auto_delete_keep_second")]
        [Validation(Required=false)]
        public int? AutoDeleteKeepSecond { get; set; }

        [NameInMap("delete_trash_normal_file_disabled")]
        [Validation(Required=false)]
        public bool? DeleteTrashNormalFileDisabled { get; set; }

    }

}
