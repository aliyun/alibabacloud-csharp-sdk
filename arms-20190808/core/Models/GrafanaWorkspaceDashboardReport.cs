// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceDashboardReport : TeaModel {
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("grafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("lastSendTime")]
        [Validation(Required=false)]
        public long? LastSendTime { get; set; }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("reportChannelTarget")]
        [Validation(Required=false)]
        public string ReportChannelTarget { get; set; }

        [NameInMap("reportChannelType")]
        [Validation(Required=false)]
        public string ReportChannelType { get; set; }

        [NameInMap("reportStyle")]
        [Validation(Required=false)]
        public string ReportStyle { get; set; }

        [NameInMap("reportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("triggerDay")]
        [Validation(Required=false)]
        public string TriggerDay { get; set; }

        [NameInMap("triggerTime")]
        [Validation(Required=false)]
        public string TriggerTime { get; set; }

        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
