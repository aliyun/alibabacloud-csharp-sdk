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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("powerSqlMode")]
        [Validation(Required=false)]
        public string PowerSqlMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("store")]
        [Validation(Required=false)]
        public string Store { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timeSpanType")]
        [Validation(Required=false)]
        public string TimeSpanType { get; set; }

        [NameInMap("ui")]
        [Validation(Required=false)]
        public string Ui { get; set; }

    }

}
