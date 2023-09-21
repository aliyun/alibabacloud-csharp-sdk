// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectDashboardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectDashboardResponseBodyData Data { get; set; }
        public class GetFileProtectDashboardResponseBodyData : TeaModel {
            [NameInMap("EnableRuleCount")]
            [Validation(Required=false)]
            public int? EnableRuleCount { get; set; }

            [NameInMap("PluginCount")]
            [Validation(Required=false)]
            public int? PluginCount { get; set; }

            [NameInMap("PluginOfflineCount")]
            [Validation(Required=false)]
            public int? PluginOfflineCount { get; set; }

            [NameInMap("PluginOnlineCount")]
            [Validation(Required=false)]
            public int? PluginOnlineCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
