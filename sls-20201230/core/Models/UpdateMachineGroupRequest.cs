// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateMachineGroupRequest : TeaModel {
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public UpdateMachineGroupRequestGroupAttribute GroupAttribute { get; set; }
        public class UpdateMachineGroupRequestGroupAttribute : TeaModel {
            [NameInMap("externalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }
            [NameInMap("groupTopic")]
            [Validation(Required=false)]
            public string GroupTopic { get; set; }
        };

        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("machineIdentifyType")]
        [Validation(Required=false)]
        public string MachineIdentifyType { get; set; }

        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
