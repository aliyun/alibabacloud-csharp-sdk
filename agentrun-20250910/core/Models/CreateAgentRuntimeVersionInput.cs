// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateAgentRuntimeVersionInput : TeaModel {
        /// <summary>
        /// <para>A description of the agent runtime version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Version 1.0.0 release with new features</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
