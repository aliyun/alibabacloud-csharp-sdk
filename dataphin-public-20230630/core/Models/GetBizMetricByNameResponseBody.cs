// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBizMetricByNameResponseBody : TeaModel {
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
        /// <para>The business metric details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBizMetricByNameResponseBodyData Data { get; set; }
        public class GetBizMetricByNameResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of associated technical metrics.</para>
            /// </summary>
            [NameInMap("AssociatedTechMetrics")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataAssociatedTechMetrics> AssociatedTechMetrics { get; set; }
            public class GetBizMetricByNameResponseBodyDataAssociatedTechMetrics : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>display name</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>guid</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1.a.b</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>metric3</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the technical metric. Valid values: INDEX: Modeling metric. CUSTOM_INDEX: Custom metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM_INDEX</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

            }

            /// <summary>
            /// <para>The name of the business owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SuperAdmin</para>
            /// </summary>
            [NameInMap("BizOwnerName")]
            [Validation(Required=false)]
            public string BizOwnerName { get; set; }

            /// <summary>
            /// <para>The list of associated folders.</para>
            /// </summary>
            [NameInMap("Catalogs")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataCatalogs> Catalogs { get; set; }
            public class GetBizMetricByNameResponseBodyDataCatalogs : TeaModel {
                /// <summary>
                /// <para>The description of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>catalog desc</para>
                /// </summary>
                [NameInMap("CatalogDesc")]
                [Validation(Required=false)]
                public string CatalogDesc { get; set; }

                /// <summary>
                /// <para>The ID of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1561740764851842</para>
                /// </summary>
                [NameInMap("CatalogId")]
                [Validation(Required=false)]
                public long? CatalogId { get; set; }

                /// <summary>
                /// <para>The name of the folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test catalog</para>
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// <para>The ID of the parent folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1561740764851841</para>
                /// </summary>
                [NameInMap("ParentCatalogId")]
                [Validation(Required=false)]
                public long? ParentCatalogId { get; set; }

                /// <summary>
                /// <para>The path of the parent folder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/catalog1/</para>
                /// </summary>
                [NameInMap("ParentPath")]
                [Validation(Required=false)]
                public string ParentPath { get; set; }

                /// <summary>
                /// <para>The ID of the topic to which the folder belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43297700</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <para>The name of the topic to which the folder belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            /// <summary>
            /// <para>The custom attribute list.</para>
            /// </summary>
            [NameInMap("CustomAttribute")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataCustomAttribute> CustomAttribute { get; set; }
            public class GetBizMetricByNameResponseBodyDataCustomAttribute : TeaModel {
                /// <summary>
                /// <para>The custom attribute code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CustomAttributeCode</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The attribute value list: 1. For custom input and drop-down single-select attributes, the first attribute value in the list is used. 2. For drop-down multi-select attributes, all attribute values in the list are used. 3. For hyperlink attributes, the first attribute value in the list is the display text, and the second attribute value is the redirect link.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric Desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric Display Name</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The GUID of the business metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guid</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            /// <summary>
            /// <para>The list of labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>The definition of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric1]+[Metric2]</para>
            /// </summary>
            [NameInMap("MetricDefinition")]
            [Validation(Required=false)]
            public string MetricDefinition { get; set; }

            /// <summary>
            /// <para>The expression of the metric relationship diagram.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric2]*10</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramExpression")]
            [Validation(Required=false)]
            public string MetricRelationDiagramExpression { get; set; }

            /// <summary>
            /// <para>Indicates whether the metric relationship diagram is enabled. Valid values: true: Enabled. false: Disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramSwitchOpen")]
            [Validation(Required=false)]
            public bool? MetricRelationDiagramSwitchOpen { get; set; }

            /// <summary>
            /// <para>The name of the business metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The text content of the usage instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("OperateInstructionContent")]
            [Validation(Required=false)]
            public string OperateInstructionContent { get; set; }

            /// <summary>
            /// <para>Indicates whether the usage instructions are enabled. Valid values: true: Enabled. false: Disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OperateInstructionEnabled")]
            [Validation(Required=false)]
            public bool? OperateInstructionEnabled { get; set; }

            /// <summary>
            /// <para>The list of related business metrics.</para>
            /// </summary>
            [NameInMap("RelatedBizMetrics")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataRelatedBizMetrics> RelatedBizMetrics { get; set; }
            public class GetBizMetricByNameResponseBodyDataRelatedBizMetrics : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>display name</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>guid</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Metric2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The relationship type. Valid values: POSITIVE: Positive correlation. NEGATIVE: Negative correlation. OTHER: Other.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POSITIVE</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

            }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001011</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The visibility scope.</para>
            /// </summary>
            [NameInMap("ViewScope")]
            [Validation(Required=false)]
            public GetBizMetricByNameResponseBodyDataViewScope ViewScope { get; set; }
            public class GetBizMetricByNameResponseBodyDataViewScope : TeaModel {
                /// <summary>
                /// <para>The type of the visibility scope. Valid values: ALL_USERS_CAN_VIEW: Visible to all users. PART_USERS_CAN_VIEW: Visible to specific users. PART_USERS_CAN_NOT_VIEW: Invisible to specific users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PART_USERS_CAN_NOT_VIEW</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>The names of the user groups. This parameter is valid only when the visibility scope of the asset is set to Visible to specific users or Invisible to specific users.</para>
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
