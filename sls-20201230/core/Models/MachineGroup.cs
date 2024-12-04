// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MachineGroup : TeaModel {
        [NameInMap("groupAttribute")]
        [Validation(Required=false)]
        public MachineGroupGroupAttribute GroupAttribute { get; set; }
        public class MachineGroupGroupAttribute : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-group</para>
            /// </summary>
            [NameInMap("externalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-topic</para>
            /// </summary>
            [NameInMap("groupTopic")]
            [Validation(Required=false)]
            public string GroupTopic { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-group</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("machineIdentifyType")]
        [Validation(Required=false)]
        public string MachineIdentifyType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("machineList")]
        [Validation(Required=false)]
        public List<string> MachineList { get; set; }

    }

}
