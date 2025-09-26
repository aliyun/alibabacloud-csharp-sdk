// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BrowserSessionOut : TeaModel {
        [NameInMap("browserId")]
        [Validation(Required=false)]
        public string BrowserId { get; set; }

        [NameInMap("browserName")]
        [Validation(Required=false)]
        public string BrowserName { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>会话空闲超时时间，单位为秒</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
