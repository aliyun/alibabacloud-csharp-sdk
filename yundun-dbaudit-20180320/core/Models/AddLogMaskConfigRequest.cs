/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class AddLogMaskConfigRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaskName")]
        [Validation(Required=false)]
        public string MaskName { get; set; }

        [NameInMap("MaskRegex")]
        [Validation(Required=false)]
        public string MaskRegex { get; set; }

        [NameInMap("MaskTxt")]
        [Validation(Required=false)]
        public string MaskTxt { get; set; }

        [NameInMap("MaskDescription")]
        [Validation(Required=false)]
        public string MaskDescription { get; set; }

    }

}
