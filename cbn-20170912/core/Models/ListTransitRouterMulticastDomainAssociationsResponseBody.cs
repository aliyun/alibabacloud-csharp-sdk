// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastDomainAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, it indicates that no subsequent query is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CD0969B-A605-5D2D-BFF0-699FD182FB7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information about the resource associated with the multicast domain.</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastAssociations")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastDomainAssociationsResponseBodyTransitRouterMulticastAssociations> TransitRouterMulticastAssociations { get; set; }
        public class ListTransitRouterMulticastDomainAssociationsResponseBodyTransitRouterMulticastAssociations : TeaModel {
            /// <summary>
            /// <para>The ID of the resource associated with the multicast domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-p0w9b7g9l90yofr0n****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource associated with the multicast domain belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456123456</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The type of resource associated with the multicast domain.</para>
            /// <para>Valid value: <b>VPC</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The association status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Associated</b>: The resource is associated with the multicast domain.</description></item>
            /// <item><description><b>Associating</b>: The resource is being associated with the multicast domain.</description></item>
            /// <item><description><b>Dissociating</b>: The resource is being disassociated from the multicast domain.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Dissociating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-p90y3ymbbwuvy5****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The ID of the multicast domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-mcast-domain-91wpg6wbhchjeq****</para>
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-p0wxk12u6okfkr8xy****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

    }

}
