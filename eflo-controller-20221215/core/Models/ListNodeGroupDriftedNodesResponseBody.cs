// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNodeGroupDriftedNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page for a single query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned by this call. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a6b93229825ac667104463b56790c91</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of nodes that are inconsistent with the node group configuration (paginated).</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ListNodeGroupDriftedNodesResponseBodyNodes> Nodes { get; set; }
        public class ListNodeGroupDriftedNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node-001</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The list of inconsistent properties for this node.</para>
            /// </summary>
            [NameInMap("PropertyDrifts")]
            [Validation(Required=false)]
            public List<ListNodeGroupDriftedNodesResponseBodyNodesPropertyDrifts> PropertyDrifts { get; set; }
            public class ListNodeGroupDriftedNodesResponseBodyNodesPropertyDrifts : TeaModel {
                /// <summary>
                /// <para>The current value of the node property. Complex types are serialized as JSON strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>old-role</para>
                /// </summary>
                [NameInMap("ActualValue")]
                [Validation(Required=false)]
                public string ActualValue { get; set; }

                /// <summary>
                /// <para>The minimum action required to apply the TargetValue: Refresh / Reboot / Reimage. For more information, refer to the MaxDisruptiveAction parameter description in the RefreshNodeGroupNodes operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Refresh</para>
                /// </summary>
                [NameInMap("MinRequiredAction")]
                [Validation(Required=false)]
                public string MinRequiredAction { get; set; }

                /// <summary>
                /// <para>The property path in dot notation (such as a.b.c), compatible with both flat and nested properties.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RamRoleName</para>
                /// </summary>
                [NameInMap("PropertyPath")]
                [Validation(Required=false)]
                public string PropertyPath { get; set; }

                /// <summary>
                /// <para>The target value of the node property. Complex types are serialized as JSON strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>new-role</para>
                /// </summary>
                [NameInMap("TargetValue")]
                [Validation(Required=false)]
                public string TargetValue { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>887FA855-89F4-5DB3-B305-C5879EC480E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
