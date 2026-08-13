// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerConfig : TeaModel {
        /// <summary>
        /// <para>The configuration item details in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;description\&quot;:\&quot;This is a new pytorchjob template\&quot;}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The system-generated unique ID of the debug config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-vf9lowjt3pso</para>
        /// </summary>
        [NameInMap("DebuggerConfigId")]
        [Validation(Required=false)]
        public string DebuggerConfigId { get; set; }

        /// <summary>
        /// <para>The description of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a basic Pytorch configuration template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the template configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pytorch Experiment Config</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The creation time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:00Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:00Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

    }

}
