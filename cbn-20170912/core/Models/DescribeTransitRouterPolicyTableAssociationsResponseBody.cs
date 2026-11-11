// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterPolicyTableAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The associate relationships between the policy routing table and network connectivity instances.</para>
        /// </summary>
        [NameInMap("Associations")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterPolicyTableAssociationsResponseBodyAssociations> Associations { get; set; }
        public class DescribeTransitRouterPolicyTableAssociationsResponseBodyAssociations : TeaModel {
            /// <summary>
            /// <para>The ID of the association between the policy route table and the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pta-vfan3mbxoespx7xvyt</para>
            /// </summary>
            [NameInMap("AssociationId")]
            [Validation(Required=false)]
            public string AssociationId { get; set; }

            /// <summary>
            /// <para>The ID of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-123qsrads</para>
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <para>The policy routing table instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ptbl-123adfzcx</para>
            /// </summary>
            [NameInMap("PolicyTableId")]
            [Validation(Required=false)]
            public string PolicyTableId { get; set; }

            /// <summary>
            /// <para>The status of the association. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Active</b>: active.</description></item>
            /// <item><description><b>Associating</b>: associating.</description></item>
            /// <item><description><b>Dissociating</b>: dissociating.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13526224-5780-4426-8BDF-BC8B08700F22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
