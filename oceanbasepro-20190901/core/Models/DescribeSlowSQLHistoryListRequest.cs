// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSlowSQLHistoryListRequest : TeaModel {
        /// <summary>
        /// The end time of the time range for querying the execution history of the slow SQL statement.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The number of the page to return.    
        /// - Start value: 1   
        /// - Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of rows to return on each page.  
        /// - Maximum value: 100   
        /// - Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The SQL ID, which uniquely identifies an SQL statement.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public string SQLId { get; set; }

        /// <summary>
        /// The start time of the time range for querying the execution history of the slow SQL statement.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
