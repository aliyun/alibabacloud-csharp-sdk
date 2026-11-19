// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityWatchTasksRequest : TeaModel {
        /// <summary>
        /// <para>The paging conditions for the paged query.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityWatchTasksRequestListQuery ListQuery { get; set; }
        public class ListQualityWatchTasksRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The business date filter. The format is YYYY-MM-DD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>The business unit names.</para>
            /// </summary>
            [NameInMap("BizUnitNameList")]
            [Validation(Required=false)]
            public List<string> BizUnitNameList { get; set; }

            /// <summary>
            /// <para>The monitoring task objects (nodes) for which the current user is responsible.</para>
            /// </summary>
            [NameInMap("CurrentUserOwned")]
            [Validation(Required=false)]
            public bool? CurrentUserOwned { get; set; }

            /// <summary>
            /// <para>The data source IDs.</para>
            /// </summary>
            [NameInMap("DataSourceIdList")]
            [Validation(Required=false)]
            public List<string> DataSourceIdList { get; set; }

            /// <summary>
            /// <para>The data source owners.</para>
            /// </summary>
            [NameInMap("DataSourceOwnerList")]
            [Validation(Required=false)]
            public List<string> DataSourceOwnerList { get; set; }

            /// <summary>
            /// <para>The data source scope. Valid values: STREAMING (real-time only), OFFLINE (offline only), and ALL (real-time and offline).</para>
            /// </summary>
            [NameInMap("DataSourceScopeList")]
            [Validation(Required=false)]
            public List<string> DataSourceScopeList { get; set; }

            /// <summary>
            /// <para>The data source types, such as MAX_COMPUTE, HADOOP, and MYSQL.</para>
            /// </summary>
            [NameInMap("DataSourceTypeList")]
            [Validation(Required=false)]
            public List<string> DataSourceTypeList { get; set; }

            /// <summary>
            /// <para>The rule exception type. Valid values: STRONG (strong) and WEAK (weak).</para>
            /// </summary>
            [NameInMap("ErrorRuleStrengthList")]
            [Validation(Required=false)]
            public List<string> ErrorRuleStrengthList { get; set; }

            /// <summary>
            /// <para>The search keyword, such as the name of the monitored table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The project names.</para>
            /// </summary>
            [NameInMap("ProjectNameList")]
            [Validation(Required=false)]
            public List<string> ProjectNameList { get; set; }

            /// <summary>
            /// <para>The quality owners.</para>
            /// </summary>
            [NameInMap("QualityOwnerList")]
            [Validation(Required=false)]
            public List<string> QualityOwnerList { get; set; }

            /// <summary>
            /// <para>The task status. Valid values: NOT_RUN (not run), WAITING (waiting), RUNNING (running), SUCCESS (successful), FAILED (failed), CANCEL (canceled), TIMEOUT (timed out), and OFFLINE (offline).</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The table owners.</para>
            /// </summary>
            [NameInMap("TableOwnerList")]
            [Validation(Required=false)]
            public List<string> TableOwnerList { get; set; }

            /// <summary>
            /// <para>The table type. Valid values: LOGIC_DIM_TABLE (logical dimension table), LOGIC_FACT_TABLE (logical fact table), LOGIC_SUM_TABLE (logical aggregate table), LOGIC_LABEL_TABLE (logical label table), PHYSICAL_TABLE (physical table), and REALTIME_LOGICAL_TABLE (real-time metatable).</para>
            /// </summary>
            [NameInMap("TableTypeList")]
            [Validation(Required=false)]
            public List<string> TableTypeList { get; set; }

            /// <summary>
            /// <para>The monitored object type. Valid values: TABLE (Dataphin table), DATASOURCE_TABLE (global table), DATASOURCE (data source), INDEX (metric), and REALTIME_LOGICAL_TABLE (real-time metatable).</para>
            /// </summary>
            [NameInMap("WatchTypeList")]
            [Validation(Required=false)]
            public List<string> WatchTypeList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
