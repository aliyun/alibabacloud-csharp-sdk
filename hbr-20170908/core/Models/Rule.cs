// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class Rule : TeaModel {
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        [NameInMap("DestinationRetention")]
        [Validation(Required=false)]
        public long? DestinationRetention { get; set; }

        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        [NameInMap("DoCopy")]
        [Validation(Required=false)]
        public bool? DoCopy { get; set; }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

    }

}
