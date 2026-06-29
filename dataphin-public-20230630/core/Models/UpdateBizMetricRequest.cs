// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateBizMetricRequest : TeaModel {
        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Update request</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateBizMetricCommand")]
        [Validation(Required=false)]
        public UpdateBizMetricRequestUpdateBizMetricCommand UpdateBizMetricCommand { get; set; }
        public class UpdateBizMetricRequestUpdateBizMetricCommand : TeaModel {
            /// <summary>
            /// <para>List of associated technical metrics. Enter the full name of the technical metric in the format of &quot;TableFullName.MetricName&quot;, where &quot;TableFullName&quot; equals &quot;AssetSource.TableName&quot;. A technical metric can only be associated with one business metric and cannot be associated repeatedly</para>
            /// </summary>
            [NameInMap("AssociatedTechMetricFullNames")]
            [Validation(Required=false)]
            public List<string> AssociatedTechMetricFullNames { get; set; }

            /// <summary>
            /// <para>Business owner. Enter the username of the owner account</para>
            /// 
            /// <b>Example:</b>
            /// <para>SuperAdmin</para>
            /// </summary>
            [NameInMap("BizOwnerName")]
            [Validation(Required=false)]
            public string BizOwnerName { get; set; }

            /// <summary>
            /// <para>List of catalog IDs</para>
            /// </summary>
            [NameInMap("CatalogIds")]
            [Validation(Required=false)]
            public List<long?> CatalogIds { get; set; }

            /// <summary>
            /// <para>List of custom attributes. Enter the attribute code and attribute values for each</para>
            /// </summary>
            [NameInMap("CustomAttribute")]
            [Validation(Required=false)]
            public List<UpdateBizMetricRequestUpdateBizMetricCommandCustomAttribute> CustomAttribute { get; set; }
            public class UpdateBizMetricRequestUpdateBizMetricCommandCustomAttribute : TeaModel {
                /// <summary>
                /// <para>Custom attribute code</para>
                /// 
                /// <b>Example:</b>
                /// <para>CustomAttributeCode</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>List of attribute values. 1. For custom input and single-select dropdown attributes, only the first value in the list is read. 2. For multi-select dropdown attributes, all values in the list are read. 3. For hyperlink attributes, the first value is used as the display text and the second value is used as the link URL.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric Desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Display name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric1_DisplayName</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Asset labels</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>Metric definition. To reference other business metrics, enclose the metric name in square brackets [ ]</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric2]+[Metric3]</para>
            /// </summary>
            [NameInMap("MetricDefinition")]
            [Validation(Required=false)]
            public string MetricDefinition { get; set; }

            /// <summary>
            /// <para>This parameter is read only when the metric relationship diagram is enabled. Only a calculation expression composed of metric names selected from related business metrics is supported. Supported operators include +, -, *, /, (), %, and ∑. Each metric name must be enclosed in square brackets [ ]. If no operator is specified between two metrics, the system automatically fills in a placeholder. If no metric relationship expression is configured, the metric relationship diagram switch is automatically disabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric1]+[Metric2]</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramExpression")]
            [Validation(Required=false)]
            public string MetricRelationDiagramExpression { get; set; }

            /// <summary>
            /// <para>Metric relationship diagram switch. Valid values: true (enabled) and false (disabled). This can be enabled only when at least one related business metric exists. Otherwise, it is automatically disabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramSwitchOpen")]
            [Validation(Required=false)]
            public bool? MetricRelationDiagramSwitchOpen { get; set; }

            /// <summary>
            /// <para>Enter the name of the business metric to update</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The new name. Enter this when you need to modify the metric name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric1_new</para>
            /// </summary>
            [NameInMap("NewName")]
            [Validation(Required=false)]
            public string NewName { get; set; }

            /// <summary>
            /// <para>Content of the usage instructions. Only text format is supported</para>
            /// 
            /// <b>Example:</b>
            /// <para>content test</para>
            /// </summary>
            [NameInMap("OperateInstructionContent")]
            [Validation(Required=false)]
            public string OperateInstructionContent { get; set; }

            /// <summary>
            /// <para>Specifies whether the usage instructions are enabled. Valid values: true (enabled) and false (disabled)</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OperateInstructionEnabled")]
            [Validation(Required=false)]
            public bool? OperateInstructionEnabled { get; set; }

            /// <summary>
            /// <para>List of related business metrics</para>
            /// </summary>
            [NameInMap("RelatedBizMetrics")]
            [Validation(Required=false)]
            public List<UpdateBizMetricRequestUpdateBizMetricCommandRelatedBizMetrics> RelatedBizMetrics { get; set; }
            public class UpdateBizMetricRequestUpdateBizMetricCommandRelatedBizMetrics : TeaModel {
                /// <summary>
                /// <para>Business metric name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Metric2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Correlation type. Valid values: POSITIVE (positive correlation), NEGATIVE (negative correlation), and OTHER (other)</para>
                /// 
                /// <b>Example:</b>
                /// <para>POSITIVE</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

            }

            /// <summary>
            /// <para>Visibility scope</para>
            /// </summary>
            [NameInMap("ViewScope")]
            [Validation(Required=false)]
            public UpdateBizMetricRequestUpdateBizMetricCommandViewScope ViewScope { get; set; }
            public class UpdateBizMetricRequestUpdateBizMetricCommandViewScope : TeaModel {
                /// <summary>
                /// <para>Visibility scope type. Valid values: ALL_USERS_CAN_VIEW (visible to all users), PART_USERS_CAN_VIEW (visible to specified users), and PART_USERS_CAN_NOT_VIEW (invisible to specified users)</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALL_USERS_CAN_VIEW</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>Enter user group names. This parameter is read only when the visibility scope is set to PART_USERS_CAN_VIEW or PART_USERS_CAN_NOT_VIEW</para>
                /// </summary>
                [NameInMap("UserGroupNames")]
                [Validation(Required=false)]
                public List<string> UserGroupNames { get; set; }

                /// <summary>
                /// <para>Enter the usernames of individual accounts. This parameter takes effect only when the visibility scope is set to PART_USERS_CAN_VIEW or PART_USERS_CAN_NOT_VIEW</para>
                /// </summary>
                [NameInMap("UserNames")]
                [Validation(Required=false)]
                public List<string> UserNames { get; set; }

            }

        }

    }

}
