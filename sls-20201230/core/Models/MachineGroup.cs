// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MachineGroup : TeaModel {
        /// <summary>
        /// 机器组属性。
        /// </summary>
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public MachineGroupGroupAttribute GroupAttribute { get; set; }
        public class MachineGroupGroupAttribute : TeaModel {
            [NameInMap("externalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }
            [NameInMap("groupTopic")]
            [Validation(Required=false)]
            public string GroupTopic { get; set; }
        };

        /// <summary>
        /// 机器组名称。
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 机器组种类。
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// 机器组标识种类，支持 IP 标识或者用户自定义标识，即 ip 、userdefined。
        /// </summary>
        [NameInMap("machineIdentifyType")]
        [Validation(Required=false)]
        public string MachineIdentifyType { get; set; }

        /// <summary>
        /// 机器组标识列表。
        /// </summary>
        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
