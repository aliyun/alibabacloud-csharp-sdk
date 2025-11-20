// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ActivateTemplateMCPRequest : TeaModel {
        [NameInMap("enabledTools")]
        [Validation(Required=false)]
        public List<string> EnabledTools { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>streamable-http</para>
        /// </summary>
        [NameInMap("transport")]
        [Validation(Required=false)]
        public string Transport { get; set; }

    }

}
