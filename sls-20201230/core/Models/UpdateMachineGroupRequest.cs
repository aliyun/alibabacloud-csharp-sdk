// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateMachineGroupRequest : TeaModel {
        /// <summary>
        /// The attribute of the machine group. This parameter is empty by default.
        /// </summary>
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public UpdateMachineGroupRequestGroupAttribute GroupAttribute { get; set; }
        public class UpdateMachineGroupRequestGroupAttribute : TeaModel {
            /// <summary>
            /// The identifier of the external management system on which the machine group depends. This parameter is empty by default.
            /// </summary>
            [NameInMap("externalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }

            /// <summary>
            /// The topic of the machine group. This parameter is empty by default.
            /// </summary>
            [NameInMap("groupTopic")]
            [Validation(Required=false)]
            public string GroupTopic { get; set; }

        }

        /// <summary>
        /// The name of the machine group.
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The type of the machine group. Set the value to an empty string.
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The identifier type of the machine group. Valid values:
        /// 
        /// *   ip: The machine group uses IP addresses as identifiers.
        /// *   userdefined: The machine group uses custom identifiers.
        /// </summary>
        [NameInMap("machineIdentifyType")]
        [Validation(Required=false)]
        public string MachineIdentifyType { get; set; }

        /// <summary>
        /// The identifiers of the machines in the machine group.
        /// 
        /// *   If you set machineIdentifyType to ip, enter the IP addresses of the machines.
        /// *   If you set machineIdentifyType to userdefined, enter a custom identifier.
        /// </summary>
        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
