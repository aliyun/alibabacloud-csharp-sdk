// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateBizMetricRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateBizMetricCommand")]
        [Validation(Required=false)]
        public UpdateBizMetricRequestUpdateBizMetricCommand UpdateBizMetricCommand { get; set; }
        public class UpdateBizMetricRequestUpdateBizMetricCommand : TeaModel {
            [NameInMap("AssociatedTechMetricFullNames")]
            [Validation(Required=false)]
            public List<string> AssociatedTechMetricFullNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SuperAdmin</para>
            /// </summary>
            [NameInMap("BizOwnerName")]
            [Validation(Required=false)]
            public string BizOwnerName { get; set; }

            [NameInMap("CatalogIds")]
            [Validation(Required=false)]
            public List<long?> CatalogIds { get; set; }

            [NameInMap("CustomAttribute")]
            [Validation(Required=false)]
            public List<UpdateBizMetricRequestUpdateBizMetricCommandCustomAttribute> CustomAttribute { get; set; }
            public class UpdateBizMetricRequestUpdateBizMetricCommandCustomAttribute : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CustomAttributeCode</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Metric Desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Metric1_DisplayName</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[Metric2]+[Metric3]</para>
            /// </summary>
            [NameInMap("MetricDefinition")]
            [Validation(Required=false)]
            public string MetricDefinition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[Metric1]+[Metric2]</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramExpression")]
            [Validation(Required=false)]
            public string MetricRelationDiagramExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramSwitchOpen")]
            [Validation(Required=false)]
            public bool? MetricRelationDiagramSwitchOpen { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Metric1_new</para>
            /// </summary>
            [NameInMap("NewName")]
            [Validation(Required=false)]
            public string NewName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>content test</para>
            /// </summary>
            [NameInMap("OperateInstructionContent")]
            [Validation(Required=false)]
            public string OperateInstructionContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OperateInstructionEnabled")]
            [Validation(Required=false)]
            public bool? OperateInstructionEnabled { get; set; }

            [NameInMap("RelatedBizMetrics")]
            [Validation(Required=false)]
            public List<UpdateBizMetricRequestUpdateBizMetricCommandRelatedBizMetrics> RelatedBizMetrics { get; set; }
            public class UpdateBizMetricRequestUpdateBizMetricCommandRelatedBizMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Metric2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>POSITIVE</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

            }

            [NameInMap("ViewScope")]
            [Validation(Required=false)]
            public UpdateBizMetricRequestUpdateBizMetricCommandViewScope ViewScope { get; set; }
            public class UpdateBizMetricRequestUpdateBizMetricCommandViewScope : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ALL_USERS_CAN_VIEW</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                [NameInMap("UserGroupNames")]
                [Validation(Required=false)]
                public List<string> UserGroupNames { get; set; }

                [NameInMap("UserNames")]
                [Validation(Required=false)]
                public List<string> UserNames { get; set; }

            }

        }

    }

}
