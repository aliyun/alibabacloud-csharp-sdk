// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RoutingConfiguration : TeaModel {
        /// <summary>
        /// <para>Traffic weight configuration for different versions</para>
        /// </summary>
        [NameInMap("versionWeights")]
        [Validation(Required=false)]
        public List<VersionWeight> VersionWeights { get; set; }

    }

}
