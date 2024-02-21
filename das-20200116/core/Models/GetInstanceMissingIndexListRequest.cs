// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceMissingIndexListRequest : TeaModel {
        /// <summary>
        /// The query condition based on the average cost savings.
        /// </summary>
        [NameInMap("AvgTotalUserCost")]
        [Validation(Required=false)]
        public string AvgTotalUserCost { get; set; }

        /// <summary>
        /// The query condition based on the performance improvement.
        /// </summary>
        [NameInMap("AvgUserImpact")]
        [Validation(Required=false)]
        public string AvgUserImpact { get; set; }

        /// <summary>
        /// The end time of the last seek.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The query condition based on the number of indexes.
        /// </summary>
        [NameInMap("IndexCount")]
        [Validation(Required=false)]
        public string IndexCount { get; set; }

        /// <summary>
        /// The database instance ID.
        /// 
        /// >  Only ApsaraDB RDS for SQL Server instances are supported.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The object name.
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The query condition based on the total number of pages.
        /// </summary>
        [NameInMap("ReservedPages")]
        [Validation(Required=false)]
        public string ReservedPages { get; set; }

        /// <summary>
        /// The query condition based on the table size.
        /// </summary>
        [NameInMap("ReservedSize")]
        [Validation(Required=false)]
        public string ReservedSize { get; set; }

        /// <summary>
        /// The query condition based on the number of table rows.
        /// </summary>
        [NameInMap("RowCount")]
        [Validation(Required=false)]
        public string RowCount { get; set; }

        /// <summary>
        /// The start time of the last seek.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The query condition based on the number of compilations.
        /// </summary>
        [NameInMap("UniqueCompiles")]
        [Validation(Required=false)]
        public string UniqueCompiles { get; set; }

        /// <summary>
        /// The query condition based on the number of scans.
        /// </summary>
        [NameInMap("UserScans")]
        [Validation(Required=false)]
        public string UserScans { get; set; }

        /// <summary>
        /// The query condition based on the number of seeks.
        /// </summary>
        [NameInMap("UserSeeks")]
        [Validation(Required=false)]
        public string UserSeeks { get; set; }

    }

}
