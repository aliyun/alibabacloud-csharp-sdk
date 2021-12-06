// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class ModifyDefenseThresholdRequest : TeaModel {
        [NameInMap("Bps")]
        [Validation(Required=false)]
        public int? Bps { get; set; }

        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("IsAuto")]
        [Validation(Required=false)]
        public bool? IsAuto { get; set; }

        [NameInMap("Pps")]
        [Validation(Required=false)]
        public int? Pps { get; set; }

    }

}
