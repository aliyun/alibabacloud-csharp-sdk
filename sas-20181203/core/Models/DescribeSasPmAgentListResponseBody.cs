// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSasPmAgentListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SasPmAgentList")]
        [Validation(Required=false)]
        public List<DescribeSasPmAgentListResponseBodySasPmAgentList> SasPmAgentList { get; set; }
        public class DescribeSasPmAgentListResponseBodySasPmAgentList : TeaModel {
            [NameInMap("AliyunAssistId")]
            [Validation(Required=false)]
            public string AliyunAssistId { get; set; }

            [NameInMap("AliyunMonitorId")]
            [Validation(Required=false)]
            public string AliyunMonitorId { get; set; }

            [NameInMap("AssistInstallResult")]
            [Validation(Required=false)]
            public int? AssistInstallResult { get; set; }

            [NameInMap("AssistInstallStatus")]
            [Validation(Required=false)]
            public int? AssistInstallStatus { get; set; }

            [NameInMap("MonitorInstallResult")]
            [Validation(Required=false)]
            public int? MonitorInstallResult { get; set; }

            [NameInMap("MonitorInstallStatus")]
            [Validation(Required=false)]
            public int? MonitorInstallStatus { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
