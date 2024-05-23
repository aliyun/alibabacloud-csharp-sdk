// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLHistoryListRequest : TeaModel {
        /// <summary>
        /// The end time of the time range for querying the SQL execution history.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.   
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// SQLID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public string SQLId { get; set; }

        /// <summary>
        /// The start time of the time range for querying the SQL execution history.   
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
