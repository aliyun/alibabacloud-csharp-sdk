// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InstallAgentRequest : TeaModel {
        /// <summary>
        /// <para>ID of the widget to install</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("agent_id")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>Version of the widget to install</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.4.0-1</para>
        /// </summary>
        [NameInMap("agent_version")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>Installation Type:  </para>
        /// <list type="bullet">
        /// <item><description>InstallAndUpgrade: Install if not present; update if present.  </description></item>
        /// <item><description>OnlyInstallNotHasAgent: Install if not present; do nothing if present.  </description></item>
        /// <item><description>OnlyUpgradeHasAgent: Do nothing if not present; update if present.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstallAndUpgrade</para>
        /// </summary>
        [NameInMap("install_type")]
        [Validation(Required=false)]
        public string InstallType { get; set; }

        /// <summary>
        /// <para>List of instances on which to install the widget</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<InstallAgentRequestInstances> Instances { get; set; }
        public class InstallAgentRequestInstances : TeaModel {
            /// <summary>
            /// <para>Instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9b9vucz1iubsz8sjqo</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
