// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBizMetricByNameResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBizMetricByNameResponseBodyData Data { get; set; }
        public class GetBizMetricByNameResponseBodyData : TeaModel {
            [NameInMap("AssociatedTechMetrics")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataAssociatedTechMetrics> AssociatedTechMetrics { get; set; }
            public class GetBizMetricByNameResponseBodyDataAssociatedTechMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
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
                /// <b>Example:</b>
                /// <para>metric3</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CUSTOM_INDEX</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SuperAdmin</para>
            /// </summary>
            [NameInMap("BizOwnerName")]
            [Validation(Required=false)]
            public string BizOwnerName { get; set; }

            [NameInMap("Catalogs")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataCatalogs> Catalogs { get; set; }
            public class GetBizMetricByNameResponseBodyDataCatalogs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>catalog desc</para>
                /// </summary>
                [NameInMap("CatalogDesc")]
                [Validation(Required=false)]
                public string CatalogDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1561740764851842</para>
                /// </summary>
                [NameInMap("CatalogId")]
                [Validation(Required=false)]
                public long? CatalogId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test catalog</para>
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1561740764851841</para>
                /// </summary>
                [NameInMap("ParentCatalogId")]
                [Validation(Required=false)]
                public long? ParentCatalogId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/catalog1/</para>
                /// </summary>
                [NameInMap("ParentPath")]
                [Validation(Required=false)]
                public string ParentPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>43297700</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            [NameInMap("CustomAttribute")]
            [Validation(Required=false)]
            public List<GetBizMetricByNameResponseBodyDataCustomAttribute> CustomAttribute { get; set; }
            public class GetBizMetricByNameResponseBodyDataCustomAttribute : TeaModel {
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
            /// <para>Metric Display Name</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>guid</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[Metric1]+[Metric2]</para>
            /// </summary>
            [NameInMap("MetricDefinition")]
            [Validation(Required=false)]
            public string MetricDefinition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[Metric2]*10</para>
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
            /// <b>Example:</b>
            /// <para>Metric1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>content</para>
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
            public List<GetBizMetricByNameResponseBodyDataRelatedBizMetrics> RelatedBizMetrics { get; set; }
            public class GetBizMetricByNameResponseBodyDataRelatedBizMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>30001011</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            [NameInMap("ViewScope")]
            [Validation(Required=false)]
            public GetBizMetricByNameResponseBodyDataViewScope ViewScope { get; set; }
            public class GetBizMetricByNameResponseBodyDataViewScope : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PART_USERS_CAN_NOT_VIEW</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
