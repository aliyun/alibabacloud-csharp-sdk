// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateMachineGroupRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the machine group. This parameter is empty by default.</para>
        /// </summary>
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public UpdateMachineGroupRequestGroupAttribute GroupAttribute { get; set; }
        public class UpdateMachineGroupRequestGroupAttribute : TeaModel {
            /// <summary>
            /// <para>The identifier of the external management system on which the machine group depends. This parameter is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testgroup2</para>
            /// </summary>
            [NameInMap("externalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }

            /// <summary>
            /// <para>The topic of the machine group. This parameter is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testtopic2</para>
            /// </summary>
            [NameInMap("groupTopic")]
            [Validation(Required=false)]
            public string GroupTopic { get; set; }

        }

        /// <summary>
        /// <para>The name of the machine group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-machine-group</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the machine group. Set the value to an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The identifier type of the machine group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ip: The machine group uses IP addresses as identifiers.</description></item>
        /// <item><description>userdefined: The machine group uses custom identifiers.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userdefined</para>
        /// </summary>
        [NameInMap("machineIdentifyType")]
        [Validation(Required=false)]
        public string MachineIdentifyType { get; set; }

        /// <summary>
        /// <para>The identifiers of the machines in the machine group.</para>
        /// <list type="bullet">
        /// <item><description>If you set machineIdentifyType to ip, enter the IP addresses of the machines.</description></item>
        /// <item><description>If you set machineIdentifyType to userdefined, enter a custom identifier.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[uu_id_1，uu_id_2]</para>
        /// </summary>
        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
