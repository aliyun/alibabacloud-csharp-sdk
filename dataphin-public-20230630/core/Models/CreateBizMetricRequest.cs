// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateBizMetricRequest : TeaModel {
        /// <summary>
        /// <para>The creation request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateBizMetricCommand")]
        [Validation(Required=false)]
        public CreateBizMetricRequestCreateBizMetricCommand CreateBizMetricCommand { get; set; }
        public class CreateBizMetricRequestCreateBizMetricCommand : TeaModel {
            /// <summary>
            /// <para>The list of full names of associated technical metrics. Enter the technical metric in the format of &quot;Full table name.Metric name&quot;, where &quot;Full table name&quot; is equal to &quot;Asset source.Table name&quot;. A technical metric can be associated with only one business metric and cannot be associated repeatedly.</para>
            /// </summary>
            [NameInMap("AssociatedTechMetricFullNames")]
            [Validation(Required=false)]
            public List<string> AssociatedTechMetricFullNames { get; set; }

            /// <summary>
            /// <para>The name of the business owner. Enter the username of the owner\&quot;s account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SuperAdmin</para>
            /// </summary>
            [NameInMap("BizOwnerName")]
            [Validation(Required=false)]
            public string BizOwnerName { get; set; }

            /// <summary>
            /// <para>The IDs of the parent folders.</para>
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
                /// <para>The list of attribute values. Rules: 1. For custom input and drop-down single-select attributes, only the first attribute value in the list is read. 2. For drop-down multi-select attributes, all attribute values in the list are read. 3. For hyperlink attributes, the first attribute value in the list is read as the display text, and the second attribute value is read as the redirect URL.</para>
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
            /// <para>The metric definition. To reference other business metrics, enclose the metric names in half-width square brackets [ ].</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric1]+[Metric2]</para>
            /// </summary>
            [NameInMap("MetricDefinition")]
            [Validation(Required=false)]
            public string MetricDefinition { get; set; }

            /// <summary>
            /// <para>The expression for the metric relationship diagram. This information is read only when the metric relationship diagram is enabled. You can only enter a calculation expression composed of metric names selected from the related business metrics. The supported operators are +, -, *, /, (), %, and ∑. Each metric name must be enclosed in half-width square brackets [ ]. If no operator is specified between two metrics, the system automatically adds padding as a placeholder. If the metric relational expression is not configured, the metric relationship diagram switch is automatically set to shutdown.</para>
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
            /// <item><description>false: Disabled.
            /// This switch can be enabled only when at least one related business metric exists. Otherwise, it is automatically disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramSwitchOpen")]
            [Validation(Required=false)]
            public bool? MetricRelationDiagramSwitchOpen { get; set; }

            /// <summary>
            /// <para>The name of the business metric. The name must be unique within the tenant. Only English letters, digits, and specific special characters (-_/\·#$^&amp;*()%+=) are supported. Maximum length: 256 characters.</para>
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
            /// <para>Specifies whether to enable operation instructions. Valid values:</para>
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
            /// <para>The list of related business metrics. Enter the names of the related business metrics and their relationships.</para>
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
                /// <item><description>POSITIVE: Positive correlation.</description></item>
                /// <item><description>NEGATIVE: Negative correlation.</description></item>
                /// <item><description>OTHER: Other.</description></item>
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
                /// <item><description>ALL_USERS_CAN_VIEW: Visible to all users.</description></item>
                /// <item><description>PART_USERS_CAN_VIEW: Visible to specific users.</description></item>
                /// <item><description>PART_USERS_CAN_NOT_VIEW: Invisible to specific users.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PART_USERS_CAN_VIEW</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>The names of the user groups. This information is read only when the visibility scope of the asset is set to Visible to specific users or Invisible to specific users.</para>
                /// </summary>
                [NameInMap("UserGroupNames")]
                [Validation(Required=false)]
                public List<string> UserGroupNames { get; set; }

                /// <summary>
                /// <para>The usernames of individual accounts. This parameter is valid only when the visibility scope of the asset is set to Visible to specific users or Invisible to specific users.</para>
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

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
