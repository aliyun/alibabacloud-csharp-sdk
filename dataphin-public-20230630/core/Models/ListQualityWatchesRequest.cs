// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityWatchesRequest : TeaModel {
        /// <summary>
        /// <para>The paged query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityWatchesRequestListQuery ListQuery { get; set; }
        public class ListQualityWatchesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The business unit names.</para>
            /// </summary>
            [NameInMap("BizUnitNameList")]
            [Validation(Required=false)]
            public List<string> BizUnitNameList { get; set; }

            /// <summary>
            /// <para>Specifies whether to query only monitored objects owned by the current user.</para>
            /// </summary>
            [NameInMap("CurrentUserOwned")]
            [Validation(Required=false)]
            public bool? CurrentUserOwned { get; set; }

            /// <summary>
            /// <para>The data source IDs.</para>
            /// </summary>
            [NameInMap("DataSourceIdList")]
            [Validation(Required=false)]
            public List<long?> DataSourceIdList { get; set; }

            /// <summary>
            /// <para>The data source owners.</para>
            /// </summary>
            [NameInMap("DataSourceOwnerList")]
            [Validation(Required=false)]
            public List<string> DataSourceOwnerList { get; set; }

            /// <summary>
            /// <para>The data source scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STREAMING: real-time only</description></item>
            /// <item><description>OFFLINE: offline only</description></item>
            /// <item><description>ALL: real-time and offline.</description></item>
            /// </list>
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
            /// <para>The metric computation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AUTO: automated coding</description></item>
            /// <item><description>CUSTOM: expert coding</description></item>
            /// <item><description>MOUNT: external table registration</description></item>
            /// <item><description>COMBINE: derived metric specific.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IndexComputeTypeList")]
            [Validation(Required=false)]
            public List<string> IndexComputeTypeList { get; set; }

            /// <summary>
            /// <para>The metric owners.</para>
            /// </summary>
            [NameInMap("IndexOwnerList")]
            [Validation(Required=false)]
            public List<string> IndexOwnerList { get; set; }

            /// <summary>
            /// <para>The search keyword. This is the name of the monitored table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: not executed</description></item>
            /// <item><description>WAITING: waiting</description></item>
            /// <item><description>RUNNING: executing</description></item>
            /// <item><description>SUCCESS: executed successfully</description></item>
            /// <item><description>FAILED: execution failed</description></item>
            /// <item><description>CANCEL: canceled</description></item>
            /// <item><description>TIMEOUT: timed out</description></item>
            /// <item><description>OFFLINE: offline.</description></item>
            /// </list>
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
            /// <para>The number of records per page. Default value: 20.</para>
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
            /// <para>The status of the monitored object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ENABLE: enabled</description></item>
            /// <item><description>DISABLE: disabled.</description></item>
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
            /// <para>The table type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LOGIC_DIM_TABLE: logical dimension table</description></item>
            /// <item><description>LOGIC_FACT_TABLE: logical fact table</description></item>
            /// <item><description>LOGIC_SUM_TABLE: logical aggregate table</description></item>
            /// <item><description>LOGIC_LABEL_TABLE: logical label table</description></item>
            /// <item><description>PHYSICAL_TABLE: physical table</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE: real-time meta table.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("TableTypeList")]
            [Validation(Required=false)]
            public List<string> TableTypeList { get; set; }

            /// <summary>
            /// <para>The monitored object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: Dataphin table</description></item>
            /// <item><description>DATASOURCE_TABLE: full-domain table</description></item>
            /// <item><description>DATASOURCE: data source</description></item>
            /// <item><description>INDEX: metric</description></item>
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
