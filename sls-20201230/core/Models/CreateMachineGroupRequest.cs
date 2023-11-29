// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateMachineGroupRequest : TeaModel {
        /// <summary>
        /// The attributes of the machine group.
        /// </summary>
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public CreateMachineGroupRequestGroupAttribute GroupAttribute { get; set; }
        public class CreateMachineGroupRequestGroupAttribute : TeaModel {
            /// <summary>
            /// The identifier of the external management system on which the machine group depends.
            /// </summary>
            [NameInMap("externalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }

            /// <summary>
            /// The log topic of the machine group.
            /// </summary>
            [NameInMap("groupTopic")]
            [Validation(Required=false)]
            public string GroupTopic { get; set; }

        }

        /// <summary>
        /// The name of the machine group. The name must meet the following requirements:
        /// 
        /// *   The name of each machine group in a project must be unique.
        /// *   It can contain only lowercase letters, digits, hyphens (-), and underscores (\_).
        /// *   It must start and end with a lowercase letter or a digit.
        /// *   It must be 3 to 128 characters in length.
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The type of the machine group. The parameter can be left empty.
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The type of the machine group identifier. Valid values:
        /// 
        /// *   ip: The machine group uses IP addresses as identifiers.
        /// *   userdefined: The machine group uses custom identifiers.
        /// </summary>
        [NameInMap("machineIdentifyType")]
        [Validation(Required=false)]
        public string MachineIdentifyType { get; set; }

        /// <summary>
        /// The identifiers of machine group.
        /// 
        /// *   If you set machineIdentifyType to ip, enter the IP address of the machine.
        /// *   If you set machineIdentifyType to userdefined, enter a custom identifier.
        /// </summary>
        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
