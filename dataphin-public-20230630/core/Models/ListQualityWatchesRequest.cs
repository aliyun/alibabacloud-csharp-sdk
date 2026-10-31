// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityWatchesRequest : TeaModel {
        /// <summary>
        /// <para>The paging query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityWatchesRequestListQuery ListQuery { get; set; }
        public class ListQualityWatchesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The name of the business unit.</para>
            /// </summary>
            [NameInMap("BizUnitNameList")]
            [Validation(Required=false)]
            public List<string> BizUnitNameList { get; set; }

            /// <summary>
            /// <para>Specifies whether the monitoring object is owned by the current user.</para>
            /// </summary>
            [NameInMap("CurrentUserOwned")]
            [Validation(Required=false)]
            public bool? CurrentUserOwned { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// </summary>
            [NameInMap("DataSourceIdList")]
            [Validation(Required=false)]
            public List<long?> DataSourceIdList { get; set; }

            /// <summary>
            /// <para>The data source owner.</para>
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
            /// <para>The data source type, such as MAX_COMPUTE, HADOOP, or MYSQL.</para>
            /// </summary>
            [NameInMap("DataSourceTypeList")]
            [Validation(Required=false)]
            public List<string> DataSourceTypeList { get; set; }

            /// <summary>
            /// <para>The metric compute type. Valid values: AUTO (automated coding), CUSTOM (expert coding), MOUNT (external table registration), and COMBINE (specific to derived metrics).</para>
            /// </summary>
            [NameInMap("IndexComputeTypeList")]
            [Validation(Required=false)]
            public List<string> IndexComputeTypeList { get; set; }

            /// <summary>
            /// <para>The metric owner.</para>
            /// </summary>
            [NameInMap("IndexOwnerList")]
            [Validation(Required=false)]
            public List<string> IndexOwnerList { get; set; }

            /// <summary>
            /// <para>The search keyword, which is the name of the monitored table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The task status. Valid values: NOT_RUN (not run), WAITING (waiting), RUNNING (running), SUCCESS (successful), FAILED (failed), CANCEL (canceled), TIMEOUT (timed out), and OFFLINE (offline).</para>
            /// </summary>
            [NameInMap("LatestWatchTaskStatusList")]
            [Validation(Required=false)]
            public List<string> LatestWatchTaskStatusList { get; set; }

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
            /// <para>The name of the project.</para>
            /// </summary>
            [NameInMap("ProjectNameList")]
            [Validation(Required=false)]
            public List<string> ProjectNameList { get; set; }

            /// <summary>
            /// <para>The quality owner.</para>
            /// </summary>
            [NameInMap("QualityOwnerList")]
            [Validation(Required=false)]
            public List<string> QualityOwnerList { get; set; }

            /// <summary>
            /// <para>The effective status of the monitoring object. Valid values: ENABLE (enabled) and DISABLE (disabled).</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The table owner.</para>
            /// </summary>
            [NameInMap("TableOwnerList")]
            [Validation(Required=false)]
            public List<string> TableOwnerList { get; set; }

            /// <summary>
            /// <para>The table type. Valid values: LOGIC_DIM_TABLE (logical dimension table), LOGIC_FACT_TABLE (logical fact table), LOGIC_SUM_TABLE (logical aggregate table), LOGIC_LABEL_TABLE (logical label table), PHYSICAL_TABLE (physical table), and REALTIME_LOGICAL_TABLE (real-time metadata table).</para>
            /// </summary>
            [NameInMap("TableTypeList")]
            [Validation(Required=false)]
            public List<string> TableTypeList { get; set; }

            /// <summary>
            /// <para>The monitoring object type. Valid values: TABLE (Dataphin table), DATASOURCE_TABLE (global table), DATASOURCE (data source), INDEX (metric), and REALTIME_LOGICAL_TABLE (real-time metadata table).</para>
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
        /// <para>The ID of the operating user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
