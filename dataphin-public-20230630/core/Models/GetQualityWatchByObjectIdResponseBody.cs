// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetQualityWatchByObjectIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error details from the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The details of the monitored object.</para>
        /// </summary>
        [NameInMap("QualityWatchInfo")]
        [Validation(Required=false)]
        public GetQualityWatchByObjectIdResponseBodyQualityWatchInfo QualityWatchInfo { get; set; }
        public class GetQualityWatchByObjectIdResponseBodyQualityWatchInfo : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The datasource details.</para>
            /// </summary>
            [NameInMap("DataSourceInfo")]
            [Validation(Required=false)]
            public GetQualityWatchByObjectIdResponseBodyQualityWatchInfoDataSourceInfo DataSourceInfo { get; set; }
            public class GetQualityWatchByObjectIdResponseBodyQualityWatchInfoDataSourceInfo : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The environment identifier. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PROD</description></item>
                /// <item><description>DEV.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The datasource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The datasource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The name of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The datasource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MAX_COMPUTE</description></item>
                /// <item><description>HADOOP.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MAX_COMPUTE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The number of enabled rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnabledRuleCount")]
            [Validation(Required=false)]
            public long? EnabledRuleCount { get; set; }

            /// <summary>
            /// <para>The monitoring ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The metric details.</para>
            /// </summary>
            [NameInMap("IndexInfo")]
            [Validation(Required=false)]
            public GetQualityWatchByObjectIdResponseBodyQualityWatchInfoIndexInfo IndexInfo { get; set; }
            public class GetQualityWatchByObjectIdResponseBodyQualityWatchInfoIndexInfo : TeaModel {
                /// <summary>
                /// <para>The business unit ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The business unit name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <para>The metric catalog.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The name of the cell aggregate table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dws_all</para>
                /// </summary>
                [NameInMap("CellSumLogicTableName")]
                [Validation(Required=false)]
                public string CellSumLogicTableName { get; set; }

                /// <summary>
                /// <para>The computation type of the metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AUTO</description></item>
                /// <item><description>CUSTOM</description></item>
                /// <item><description>MOUNT</description></item>
                /// <item><description>COMBINE.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AUTO</para>
                /// </summary>
                [NameInMap("ComputeType")]
                [Validation(Required=false)]
                public string ComputeType { get; set; }

                /// <summary>
                /// <para>The data type of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("DateType")]
                [Validation(Required=false)]
                public string DateType { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logic</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The display name of the statistical granularity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>全站汇总表</para>
                /// </summary>
                [NameInMap("GranularityDisplayName")]
                [Validation(Required=false)]
                public string GranularityDisplayName { get; set; }

                /// <summary>
                /// <para>The statistical granularity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18755764</para>
                /// </summary>
                [NameInMap("GranularityId")]
                [Validation(Required=false)]
                public long? GranularityId { get; set; }

                /// <summary>
                /// <para>The metric GUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>The metric ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logic</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The name of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The metric type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INDEX.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INDEX</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The ID of the most recent quality watchtask for the monitored object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LatestWatchTaskId")]
            [Validation(Required=false)]
            public long? LatestWatchTaskId { get; set; }

            /// <summary>
            /// <para>The status of the most recent quality watchtask for the monitored object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("LatestWatchTaskStatus")]
            [Validation(Required=false)]
            public string LatestWatchTaskStatus { get; set; }

            /// <summary>
            /// <para>The user ID of the last modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The monitoring name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The user ID of the quality owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("QualityOwner")]
            [Validation(Required=false)]
            public string QualityOwner { get; set; }

            /// <summary>
            /// <para>The display name of the quality owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QualityOwnerName")]
            [Validation(Required=false)]
            public string QualityOwnerName { get; set; }

            /// <summary>
            /// <para>The number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public long? RuleCount { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ENABLE</description></item>
            /// <item><description>DISABLE.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The monitored table object.</para>
            /// </summary>
            [NameInMap("TableInfo")]
            [Validation(Required=false)]
            public GetQualityWatchByObjectIdResponseBodyQualityWatchInfoTableInfo TableInfo { get; set; }
            public class GetQualityWatchByObjectIdResponseBodyQualityWatchInfoTableInfo : TeaModel {
                /// <summary>
                /// <para>The business unit ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The business unit name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <para>The table catalog.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The datasource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                /// <summary>
                /// <para>The datasource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MAX_COMPUTE</para>
                /// </summary>
                [NameInMap("DataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The environment identifier. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DEV</description></item>
                /// <item><description>PROD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the table is a partitioned table.</para>
                /// </summary>
                [NameInMap("IsPartitionTable")]
                [Validation(Required=false)]
                public bool? IsPartitionTable { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The name of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>LOGIC_DIM_TABLE: logical dimension table.</description></item>
                /// <item><description>LOGIC_FACT_TABLE: logical fact table.</description></item>
                /// <item><description>LOGIC_SUM_TABLE: logical aggregate table.</description></item>
                /// <item><description>LOGIC_LABEL_TABLE: logical label table.</description></item>
                /// <item><description>PHYSICAL_TABLE: physical table.</description></item>
                /// <item><description>REALTIME_LOGICAL_TABLE: real-time meta table.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LOGIC_DIM_TABLE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The monitored object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: Dataphin table.</description></item>
            /// <item><description>DATASOURCE_TABLE: global table.</description></item>
            /// <item><description>DATASOURCE: datasource.</description></item>
            /// <item><description>INDEX: metric.</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE: real-time meta table.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
