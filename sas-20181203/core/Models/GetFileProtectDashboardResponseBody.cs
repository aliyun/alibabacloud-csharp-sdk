// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectDashboardResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectDashboardResponseBodyData Data { get; set; }
        public class GetFileProtectDashboardResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of enabled rules.
            /// </summary>
            [NameInMap("EnableRuleCount")]
            [Validation(Required=false)]
            public int? EnableRuleCount { get; set; }

            /// <summary>
            /// The total number of servers on which the Security Center agent is installed.
            /// </summary>
            [NameInMap("PluginCount")]
            [Validation(Required=false)]
            public int? PluginCount { get; set; }

            /// <summary>
            /// The total number of servers on which the Security Center agent is offline.
            /// </summary>
            [NameInMap("PluginOfflineCount")]
            [Validation(Required=false)]
            public int? PluginOfflineCount { get; set; }

            /// <summary>
            /// The total number of servers on which the Security Center agent is online.
            /// </summary>
            [NameInMap("PluginOnlineCount")]
            [Validation(Required=false)]
            public int? PluginOnlineCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
