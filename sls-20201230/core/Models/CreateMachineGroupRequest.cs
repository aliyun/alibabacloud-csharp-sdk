// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateMachineGroupRequest : TeaModel {
        /// <summary>
        /// 机器组属性。
        /// </summary>
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public CreateMachineGroupRequestGroupAttribute GroupAttribute { get; set; }
        public class CreateMachineGroupRequestGroupAttribute : TeaModel {
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
        /// 机器组类型，可选值，默认为空。
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// 机器组标识种类，支持 ip 、userdefined 两种。
        /// </summary>
        [NameInMap("machineIdentifyType")]
        [Validation(Required=false)]
        public string MachineIdentifyType { get; set; }

        /// <summary>
        /// 机器列表。
        /// </summary>
        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
