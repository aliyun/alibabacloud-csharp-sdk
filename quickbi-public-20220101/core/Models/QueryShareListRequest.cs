// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryShareListRequest : TeaModel {
        /// <summary>
        /// The type of work being shared. Valid values:
        /// 
        /// *   product: BI portal
        /// *   dashboard: dashboard
        /// *   worksheet: workbook
        /// *   dashboardOfflineQuery: self-service data retrieval
        /// *   Analysis: Ad hoc analysis
        /// *   DATAFORM
        /// *   SCREEN: Data dashboard
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}
