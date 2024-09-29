// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListResourceGroupsResponseBodyData> Data { get; set; }
        public class ListResourceGroupsResponseBodyData : TeaModel {
            [NameInMap("associatedClusterTemplates")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyDataAssociatedClusterTemplates> AssociatedClusterTemplates { get; set; }
            public class ListResourceGroupsResponseBodyDataAssociatedClusterTemplates : TeaModel {
                [NameInMap("clusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>78723f0dc36。</para>
                /// </summary>
                [NameInMap("templateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("templateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            [NameInMap("associatedClusters")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyDataAssociatedClusters> AssociatedClusters { get; set; }
            public class ListResourceGroupsResponseBodyDataAssociatedClusters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>c-3cd8ba94b36cxxxx</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("clusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("clusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

            }

            [NameInMap("associatedWorkspaces")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyDataAssociatedWorkspaces> AssociatedWorkspaces { get; set; }
            public class ListResourceGroupsResponseBodyDataAssociatedWorkspaces : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1200827。</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                [NameInMap("workspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-26T02:10:04Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2。</para>
            /// </summary>
            [NameInMap("nodeMaxCount")]
            [Validation(Required=false)]
            public int? NodeMaxCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1。</para>
            /// </summary>
            [NameInMap("nodeMinCount")]
            [Validation(Required=false)]
            public int? NodeMinCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EMR_W1_SMALL。</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-acfm4ewqrznxxxx</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("resourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLUSTER_RESOURCE_GROUP。</para>
            /// </summary>
            [NameInMap("resourceGroupType")]
            [Validation(Required=false)]
            public string ResourceGroupType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10。</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1。</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
