// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BrowserStreams : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("automationStream")]
        [Validation(Required=false)]
        public BrowserAutomationStream AutomationStream { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("liveViewStream")]
        [Validation(Required=false)]
        public BrowserLiveViewStream LiveViewStream { get; set; }

    }

}
