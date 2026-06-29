// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBizMetricByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the business metric.</para>
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
                /// <para>The GUID.</para>
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
                /// <para>The type of the technical metric. Valid values: INDEX (modeling metric) and CUSTOM_INDEX (custom metric).</para>
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
            /// <para>The list of affiliated catalogs.</para>
            /// </summary>
            [NameInMap("Catalogs")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataCatalogs> Catalogs { get; set; }
            public class GetBizMetricByNameResponseBodyDataCatalogs : TeaModel {
                /// <summary>
                /// <para>The catalog description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>catalog desc</para>
                /// </summary>
                [NameInMap("CatalogDesc")]
                [Validation(Required=false)]
                public string CatalogDesc { get; set; }

                /// <summary>
                /// <para>The catalog ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1561740764851842</para>
                /// </summary>
                [NameInMap("CatalogId")]
                [Validation(Required=false)]
                public long? CatalogId { get; set; }

                /// <summary>
                /// <para>The catalog name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test catalog</para>
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// <para>The parent catalog ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1561740764851841</para>
                /// </summary>
                [NameInMap("ParentCatalogId")]
                [Validation(Required=false)]
                public long? ParentCatalogId { get; set; }

                /// <summary>
                /// <para>The parent path of the catalog.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/catalog1/</para>
                /// </summary>
                [NameInMap("ParentPath")]
                [Validation(Required=false)]
                public string ParentPath { get; set; }

                /// <summary>
                /// <para>The topic ID to which the catalog belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43297700</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <para>The topic name to which the catalog belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            /// <summary>
            /// <para>The list of custom attributes.</para>
            /// </summary>
            [NameInMap("CustomAttribute")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataCustomAttribute> CustomAttribute { get; set; }
            public class GetBizMetricByNameResponseBodyDataCustomAttribute : TeaModel {
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
                /// <para>The list of attribute values. 1. For custom input and single-select dropdown attributes, the first value in the list is used. 2. For multi-select dropdown attributes, all values in the list are used. 3. For hyperlink attributes, the first value is the display text and the second value is the link URL.</para>
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
            /// <para>The metric definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric1]+[Metric2]</para>
            /// </summary>
            [NameInMap("MetricDefinition")]
            [Validation(Required=false)]
            public string MetricDefinition { get; set; }

            /// <summary>
            /// <para>The expression of the metric relation diagram.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Metric2]*10</para>
            /// </summary>
            [NameInMap("MetricRelationDiagramExpression")]
            [Validation(Required=false)]
            public string MetricRelationDiagramExpression { get; set; }

            /// <summary>
            /// <para>Indicates whether the metric relation diagram is enabled. A value of true indicates that the diagram is enabled. A value of false indicates that the diagram is disabled.</para>
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
            /// <para>The text content of the operation instruction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("OperateInstructionContent")]
            [Validation(Required=false)]
            public string OperateInstructionContent { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation instruction is enabled. A value of true indicates that the operation instruction is enabled. A value of false indicates that the operation instruction is disabled.</para>
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
                /// <para>The GUID.</para>
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
                /// <para>The relation type. Valid values: POSITIVE (positive correlation), NEGATIVE (negative correlation), and OTHER (other).</para>
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
            /// <para>The view scope.</para>
            /// </summary>
            [NameInMap("ViewScope")]
            [Validation(Required=false)]
            public GetBizMetricByNameResponseBodyDataViewScope ViewScope { get; set; }
            public class GetBizMetricByNameResponseBodyDataViewScope : TeaModel {
                /// <summary>
                /// <para>The type of view scope. Valid values: ALL_USERS_CAN_VIEW (visible to all users), PART_USERS_CAN_VIEW (visible to specific users), and PART_USERS_CAN_NOT_VIEW (invisible to specific users).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PART_USERS_CAN_NOT_VIEW</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>The names of user groups. This parameter takes effect only when the view scope is set to PART_USERS_CAN_VIEW or PART_USERS_CAN_NOT_VIEW.</para>
                /// </summary>
                [NameInMap("UserGroupNames")]
                [Validation(Required=false)]
                public List<string> UserGroupNames { get; set; }

                /// <summary>
                /// <para>The usernames of individual accounts. This parameter is valid only when the view scope is set to PART_USERS_CAN_VIEW or PART_USERS_CAN_NOT_VIEW.</para>
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
        /// <para>The error message.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
