// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class VersionWeight : TeaModel {
        /// <summary>
        /// <para>Agent runtime version number</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>Traffic weight ratio (0.0–1.0)</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public float? Weight { get; set; }

    }

}
