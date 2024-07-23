// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceMissingIndexListRequest : TeaModel {
        /// <summary>
        /// <para>The query condition based on the average cost savings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&lt;=|8</para>
        /// </summary>
        [NameInMap("AvgTotalUserCost")]
        [Validation(Required=false)]
        public string AvgTotalUserCost { get; set; }

        /// <summary>
        /// <para>The query condition based on the performance improvement.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>|10000</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AvgUserImpact")]
        [Validation(Required=false)]
        public string AvgUserImpact { get; set; }

        /// <summary>
        /// <para>The end time of the last seek.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681869544000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The query condition based on the number of indexes.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=|8</para>
        /// </remarks>
        /// </summary>
        [NameInMap("IndexCount")]
        [Validation(Required=false)]
        public string IndexCount { get; set; }

        /// <summary>
        /// <para>The database instance ID.</para>
        /// <remarks>
        /// <para> Only ApsaraDB RDS for SQL Server instances are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-************</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The object name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bas_customer</para>
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The query condition based on the total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=|100</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ReservedPages")]
        [Validation(Required=false)]
        public string ReservedPages { get; set; }

        /// <summary>
        /// <para>The query condition based on the table size.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=|100</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ReservedSize")]
        [Validation(Required=false)]
        public string ReservedSize { get; set; }

        /// <summary>
        /// <para>The query condition based on the number of table rows.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=|100000</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RowCount")]
        [Validation(Required=false)]
        public string RowCount { get; set; }

        /// <summary>
        /// <para>The start time of the last seek.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679414400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The query condition based on the number of compilations.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=|10000</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UniqueCompiles")]
        [Validation(Required=false)]
        public string UniqueCompiles { get; set; }

        /// <summary>
        /// <para>The query condition based on the number of scans.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=|10000</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UserScans")]
        [Validation(Required=false)]
        public string UserScans { get; set; }

        /// <summary>
        /// <para>The query condition based on the number of seeks.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=|1000</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UserSeeks")]
        [Validation(Required=false)]
        public string UserSeeks { get; set; }

    }

}
