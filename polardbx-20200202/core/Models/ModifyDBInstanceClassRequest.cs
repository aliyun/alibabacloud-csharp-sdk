// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyDBInstanceClassRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CnClass")]
        [Validation(Required=false)]
        public string CnClass { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("DnClass")]
        [Validation(Required=false)]
        public string DnClass { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SpecifiedDNScale")]
        [Validation(Required=false)]
        public bool? SpecifiedDNScale { get; set; }

        [NameInMap("SpecifiedDNSpecMapJson")]
        [Validation(Required=false)]
        public string SpecifiedDNSpecMapJson { get; set; }

        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        [NameInMap("TargetDBInstanceClass")]
        [Validation(Required=false)]
        public string TargetDBInstanceClass { get; set; }

    }

}
