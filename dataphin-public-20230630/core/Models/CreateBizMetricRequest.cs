// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateBizMetricRequest : TeaModel {
        /// <summary>
        /// <para>The create request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateBizMetricCommand")]
        [Validation(Required=false)]
        public CreateBizMetricRequestCreateBizMetricCommand CreateBizMetricCommand { get; set; }
        public class CreateBizMetricRequestCreateBizMetricCommand : TeaModel {
            /// <summary>
            /// <para>The list of full names of associated technical metrics. Enter the full name in the format of &quot;OwnerTableFullName.MetricName&quot;, where &quot;OwnerTableFullName&quot; equals &quot;AssetSource.OwnerTableName&quot;. A technical metric can be associated with only one business metric and cannot be associated repeatedly.</para>
            /// </summary>
            [NameInMap("AssociatedTechMetricFullNames")]
            [Validation(Required=false)]
            public List<string> AssociatedTechMetricFullNames { get; set; }

            /// <summary>
            /// <para>The name of the business owner. Enter the username of the owner account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SuperAdmin</para>
            /// </summary>
            [NameInMap("BizOwnerName")]
            [Validation(Required=false)]
            public string BizOwnerName { get; set; }

            /// <summary>
            /// <para>The IDs of the folders to which the metric belongs.</para>
            /// </summary>
            [NameInMap("CatalogIds")]
            [Validation(Required=false)]
            public List<long?> CatalogIds { get; set; }

            /// <summary>
            /// <para>The custom attributes.</para>
            /// </summary>
            [NameInMap("CustomAttribute")]
            [Validation(Required=false)]
            public List<CreateBizMetricRequestCreateBizMetricCommandCustomAttribute> CustomAttribute { get; set; }
            public class CreateBizMetricRequestCreateBizMetricCommandCustomAttribute : TeaModel {
                /// <summary>
                /// <para>The code of the custom attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CustomAttributeCode</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The list of attribute values. 1. For custom input and single-select dropdown attributes, only the first value in the list is read. 2. For multi-select dropdown attributes, all values in the list are read. 3. For hyperlink attributes, the first value is used as the display text and the second value is used as the redirect link.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MetricDesc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MetricDisplayName</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The asset labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>The metric definition. To reference other business metrics, enclose the metric name in square brackets [ ].</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric1]+[Metric2]</para>
            /// </summary>
            [NameInMap("MetricDefinition")]
            [Validation(Required=false)]
            public string MetricDefinition { get; set; }

            /// <summary>
            /// <para>This parameter is read only when the metric relationship diagram is enabled. Enter a calculation expression composed of metric names selected from the related business metrics. Supported operators include +, -, *, /, (, ), %, and ∑. Each metric name must be enclosed in square brackets [ ]. If no operator is specified between two metrics, the system automatically inserts a padding placeholder. If no metric relational expression is configured, the metric relationship diagram switch is automatically shutdown.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric1]+[Metric2]</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramExpression")]
            [Validation(Required=false)]
            public string MetricRelationDiagramExpression { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the metric relationship diagram. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// <para>This parameter can be set to true only when at least one related business metric exists. Otherwise, the diagram is automatically disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramSwitchOpen")]
            [Validation(Required=false)]
            public bool? MetricRelationDiagramSwitchOpen { get; set; }

            /// <summary>
            /// <para>The name of the business metric. The name must be unique within the tenant. The name can contain letters, digits, and the following special characters: -_/\·#$^&amp;*()%+=. The name can be up to 256 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The content of the operation instructions. Only text format is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("OperateInstructionContent")]
            [Validation(Required=false)]
            public string OperateInstructionContent { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the operation instructions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OperateInstructionEnabled")]
            [Validation(Required=false)]
            public bool? OperateInstructionEnabled { get; set; }

            /// <summary>
            /// <para>The list of related business metrics. Enter the names of related business metrics and their relationships.</para>
            /// </summary>
            [NameInMap("RelatedBizMetrics")]
            [Validation(Required=false)]
            public List<CreateBizMetricRequestCreateBizMetricCommandRelatedBizMetrics> RelatedBizMetrics { get; set; }
            public class CreateBizMetricRequestCreateBizMetricCommandRelatedBizMetrics : TeaModel {
                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Metric2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The relationship type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>POSITIVE: positive correlation.</description></item>
                /// <item><description>NEGATIVE: negative correlation.</description></item>
                /// <item><description>OTHER: other.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>POSITIVE</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

            }

            /// <summary>
            /// <para>The visibility scope.</para>
            /// </summary>
            [NameInMap("ViewScope")]
            [Validation(Required=false)]
            public CreateBizMetricRequestCreateBizMetricCommandViewScope ViewScope { get; set; }
            public class CreateBizMetricRequestCreateBizMetricCommandViewScope : TeaModel {
                /// <summary>
                /// <para>The visibility scope type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALL_USERS_CAN_VIEW: visible to all users.</description></item>
                /// <item><description>PART_USERS_CAN_VIEW: visible to specified users.</description></item>
                /// <item><description>PART_USERS_CAN_NOT_VIEW: not visible to specified users.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PART_USERS_CAN_VIEW</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>The names of user groups. This parameter is read only when the visibility scope is set to PART_USERS_CAN_VIEW or PART_USERS_CAN_NOT_VIEW.</para>
                /// </summary>
                [NameInMap("UserGroupNames")]
                [Validation(Required=false)]
                public List<string> UserGroupNames { get; set; }

                /// <summary>
                /// <para>The usernames of individual accounts. This parameter takes effect only when the visibility scope is set to PART_USERS_CAN_VIEW or PART_USERS_CAN_NOT_VIEW.</para>
                /// </summary>
                [NameInMap("UserNames")]
                [Validation(Required=false)]
                public List<string> UserNames { get; set; }

            }

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
