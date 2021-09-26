// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ChangeLogMaskConfigStateRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaskId")]
        [Validation(Required=false)]
        public int? MaskId { get; set; }

        [NameInMap("MaskState")]
        [Validation(Required=false)]
        public int? MaskState { get; set; }

    }

}
