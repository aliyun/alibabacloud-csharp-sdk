// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AlertQuery : TeaModel {
        [NameInMap("chartTitle")]
        [Validation(Required=false)]
        public string ChartTitle { get; set; }

        [NameInMap("dashboardId")]
        [Validation(Required=false)]
        public string DashboardId { get; set; }

        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("powerSqlMode")]
        [Validation(Required=false)]
        public string PowerSqlMode { get; set; }

        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

        [NameInMap("store")]
        [Validation(Required=false)]
        public string Store { get; set; }

        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

        [NameInMap("timeSpanType")]
        [Validation(Required=false)]
        public string TimeSpanType { get; set; }

        [NameInMap("ui")]
        [Validation(Required=false)]
        public string Ui { get; set; }

    }

}
