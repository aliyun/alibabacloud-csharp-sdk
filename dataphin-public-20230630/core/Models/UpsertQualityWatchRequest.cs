// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityWatchRequest : TeaModel {
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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The upsert command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityWatchRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityWatchRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <para>The data source details.</para>
            /// </summary>
            [NameInMap("DataSourceInfo")]
            [Validation(Required=false)]
            public UpsertQualityWatchRequestUpsertCommandDataSourceInfo DataSourceInfo { get; set; }
            public class UpsertQualityWatchRequestUpsertCommandDataSourceInfo : TeaModel {
                /// <summary>
                /// <para>The data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The monitored object ID. If you specify this parameter, the operation updates the object. If you do not specify this parameter, the operation creates a new object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The monitored metric object.</para>
            /// </summary>
            [NameInMap("IndexInfo")]
            [Validation(Required=false)]
            public UpsertQualityWatchRequestUpsertCommandIndexInfo IndexInfo { get; set; }
            public class UpsertQualityWatchRequestUpsertCommandIndexInfo : TeaModel {
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
                /// <para>The name of the unit aggregate table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dws_all</para>
                /// </summary>
                [NameInMap("CellSumLogicTableName")]
                [Validation(Required=false)]
                public string CellSumLogicTableName { get; set; }

                /// <summary>
                /// <para>The computation type of the metric. Valid values: AUTO, CUSTOM, MOUNT, and COMBINE.</para>
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
                /// <para>The name of the statistical granularity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Site-wide aggregate table</para>
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
                /// <para>test_idx_</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
                /// <para>The type of the metric. Valid value: INDEX.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INDEX</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The quality owner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001011</para>
            /// </summary>
            [NameInMap("QualityOwner")]
            [Validation(Required=false)]
            public string QualityOwner { get; set; }

            /// <summary>
            /// <para>The monitored table object.</para>
            /// </summary>
            [NameInMap("TableInfo")]
            [Validation(Required=false)]
            public UpsertQualityWatchRequestUpsertCommandTableInfo TableInfo { get; set; }
            public class UpsertQualityWatchRequestUpsertCommandTableInfo : TeaModel {
                /// <summary>
                /// <para>The table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The monitored object type. Valid values: TABLE (Dataphin table), DATASOURCE_TABLE (global table), DATASOURCE (data source), INDEX (metric), and REALTIME_LOGICAL_TABLE (real-time metatable).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
