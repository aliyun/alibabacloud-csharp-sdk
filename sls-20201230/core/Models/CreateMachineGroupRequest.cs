// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateMachineGroupRequest : TeaModel {
        /// <summary>
        /// <para>The attributes of the machine group.</para>
        /// </summary>
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public CreateMachineGroupRequestGroupAttribute GroupAttribute { get; set; }
        public class CreateMachineGroupRequestGroupAttribute : TeaModel {
            /// <summary>
            /// <para>The identifier of the external management system on which the machine group depends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testgroup</para>
            /// </summary>
            [NameInMap("externalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }

            /// <summary>
            /// <para>The log topic of the machine group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testtopic</para>
            /// </summary>
            [NameInMap("groupTopic")]
            [Validation(Required=false)]
            public string GroupTopic { get; set; }

        }

        /// <summary>
        /// <para>The name of the machine group. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name of each machine group in a project must be unique.</description></item>
        /// <item><description>It can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>It must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>It must be 3 to 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-machine-group</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the machine group. The parameter can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The type of the machine group identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ip: The machine group uses IP addresses as identifiers.</description></item>
        /// <item><description>userdefined: The machine group uses custom identifiers.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("machineIdentifyType")]
        [Validation(Required=false)]
        public string MachineIdentifyType { get; set; }

        /// <summary>
        /// <para>The identifiers of machine group.</para>
        /// <list type="bullet">
        /// <item><description>If you set machineIdentifyType to ip, enter the IP address of the machine.</description></item>
        /// <item><description>If you set machineIdentifyType to userdefined, enter a custom identifier.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
