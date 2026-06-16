// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ProtocolConfiguration : TeaModel {
        /// <summary>
        /// <para>Detailed protocol configuration information</para>
        /// </summary>
        [NameInMap("protocolSettings")]
        [Validation(Required=false)]
        public List<ProtocolSettings> ProtocolSettings { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Protocol Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        [Obsolete]
        public string Type { get; set; }

    }

}
