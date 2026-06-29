// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityWatchTasksRequest : TeaModel {
        /// <summary>
        /// <para>The paged query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityWatchTasksRequestListQuery ListQuery { get; set; }
        public class ListQualityWatchTasksRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The business date filter.</para>
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
            /// <para>Specifies whether to query only the quality monitoring node objects owned by the current user.</para>
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
            /// <para>The data source scopes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STREAMING: real-time only.</description></item>
            /// <item><description>OFFLINE: offline only.</description></item>
            /// <item><description>ALL: real-time and offline.</description></item>
            /// </list>
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
            /// <para>The rule exception types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STRONG: strong.</description></item>
            /// <item><description>WEAK: weak.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ErrorRuleStrengthList")]
            [Validation(Required=false)]
            public List<string> ErrorRuleStrengthList { get; set; }

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
            /// <para>The task statuses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: not executed.</description></item>
            /// <item><description>WAITING: waiting.</description></item>
            /// <item><description>RUNNING: running.</description></item>
            /// <item><description>SUCCESS: succeeded.</description></item>
            /// <item><description>FAILED: failed.</description></item>
            /// <item><description>CANCEL: canceled.</description></item>
            /// <item><description>TIMEOUT: timed out.</description></item>
            /// <item><description>OFFLINE: offline.</description></item>
            /// </list>
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
            /// <para>The table types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LOGIC_DIM_TABLE: logical dimension table.</description></item>
            /// <item><description>LOGIC_FACT_TABLE: logical fact table.</description></item>
            /// <item><description>LOGIC_SUM_TABLE: logical aggregate table.</description></item>
            /// <item><description>LOGIC_LABEL_TABLE: logical label table.</description></item>
            /// <item><description>PHYSICAL_TABLE: physical table.</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE: real-time meta table.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("TableTypeList")]
            [Validation(Required=false)]
            public List<string> TableTypeList { get; set; }

            /// <summary>
            /// <para>The monitored object types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: Dataphin table.</description></item>
            /// <item><description>DATASOURCE_TABLE: global table.</description></item>
            /// <item><description>DATASOURCE: data source.</description></item>
            /// <item><description>INDEX: metric.</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE: real-time meta table.</description></item>
            /// </list>
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

    }

}
