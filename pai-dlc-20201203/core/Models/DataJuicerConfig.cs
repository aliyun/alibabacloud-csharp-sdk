// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DataJuicerConfig : TeaModel {
        /// <summary>
        /// <para>The command type.</para>
        /// <list type="bullet">
        /// <item><description><para>shell: A shell command.</para>
        /// </description></item>
        /// <item><description><para>config: The YAML configuration for DataJuicer.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>config</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable resource estimation.</para>
        /// </summary>
        [NameInMap("EnableResourceEstimation")]
        [Validation(Required=false)]
        public bool? EnableResourceEstimation { get; set; }

        /// <summary>
        /// <para>The execution mode.</para>
        /// <list type="bullet">
        /// <item><description><para>standalone: Single node.</para>
        /// </description></item>
        /// <item><description><para>distributed: Distributed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standalone</para>
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        [NameInMap("ResourceLimit")]
        [Validation(Required=false)]
        public ResourceLimit ResourceLimit { get; set; }

    }

}
