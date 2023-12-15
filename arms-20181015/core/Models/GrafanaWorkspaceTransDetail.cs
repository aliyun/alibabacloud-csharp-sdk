// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceTransDetail : TeaModel {
        [NameInMap("dashboardAmount")]
        [Validation(Required=false)]
        public int? DashboardAmount { get; set; }

        [NameInMap("dataSourceAmount")]
        [Validation(Required=false)]
        public int? DataSourceAmount { get; set; }

        [NameInMap("original")]
        [Validation(Required=false)]
        public long? Original { get; set; }

        [NameInMap("originalName")]
        [Validation(Required=false)]
        public string OriginalName { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

        [NameInMap("targetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

    }

}
