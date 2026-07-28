// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DataJuicerConfig : TeaModel {
        /// <summary>
        /// <para>The command type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>shell: shell command.</description></item>
        /// <item><description>config: DataJuicer YAML configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>config</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable resource estimation. When resource estimation is enabled, the execution mode must be distributed, and the command type must be config (DataJuicer YAML configuration).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableResourceEstimation")]
        [Validation(Required=false)]
        public bool? EnableResourceEstimation { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standalone: single-node.</description></item>
        /// <item><description>distributed: distributed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standalone</para>
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>The resource estimation limit. This parameter takes effect only when resource estimation is enabled.</para>
        /// </summary>
        [NameInMap("ResourceLimit")]
        [Validation(Required=false)]
        public ResourceLimit ResourceLimit { get; set; }

    }

}
