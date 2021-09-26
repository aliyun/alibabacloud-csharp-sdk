// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogMaskConfigsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaskName")]
        [Validation(Required=false)]
        public string MaskName { get; set; }

        [NameInMap("MaskType")]
        [Validation(Required=false)]
        public int? MaskType { get; set; }

        [NameInMap("MaskState")]
        [Validation(Required=false)]
        public int? MaskState { get; set; }

    }

}
