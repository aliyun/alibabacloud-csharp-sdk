// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MachineGroup : TeaModel {
        /// <summary>
        /// <para>The properties of the machine group.</para>
        /// </summary>
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public MachineGroupGroupAttribute GroupAttribute { get; set; }
        public class MachineGroupGroupAttribute : TeaModel {
            /// <summary>
            /// <para>The identifier of the external management system that the machine group depends on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testgroup</para>
            /// </summary>
            [NameInMap("externalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }

            /// <summary>
            /// <para>The topic of the machine group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testtopic</para>
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
        /// <para>machineGroup-test</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the machine group. This parameter is currently an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The machine identity type.</para>
        /// <list type="bullet">
        /// <item><description><para>ip: The machine group is identified by IP addresses.</para>
        /// </description></item>
        /// <item><description><para>userdefined: The machine group is identified by custom identifiers.</para>
        /// </description></item>
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
        /// <para>The list of machines.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
