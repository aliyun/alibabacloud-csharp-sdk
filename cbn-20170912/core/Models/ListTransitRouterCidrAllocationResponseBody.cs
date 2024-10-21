// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrAllocationResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// <list type="bullet">
        /// <item><description>If no value is specified for <b>MaxResults</b>, query results are returned in one batch. The value of <b>MaxResults</b> indicates the total number of entries.</description></item>
        /// <item><description>If a value is specified for <b>MaxResults</b>, query results are returned in batches. The value of <b>MaxResults</b> in the response indicates the number of entries in the current batch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> was not returned, it indicates that no additional results exist.</description></item>
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
        /// <para>0876E54E-3E36-5C31-89F0-9EE8A9266F9A</para>
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
        /// <para>The information about the CIDR blocks that have IP addresses allocated to network instances.</para>
        /// </summary>
        [NameInMap("TransitRouterCidrAllocations")]
        [Validation(Required=false)]
        public List<ListTransitRouterCidrAllocationResponseBodyTransitRouterCidrAllocations> TransitRouterCidrAllocations { get; set; }
        public class ListTransitRouterCidrAllocationResponseBodyTransitRouterCidrAllocations : TeaModel {
            /// <summary>
            /// <para>The CIDR blocks that have IP addresses allocated to network instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/28</para>
            /// </summary>
            [NameInMap("AllocatedCidrBlock")]
            [Validation(Required=false)]
            public string AllocatedCidrBlock { get; set; }

            /// <summary>
            /// <para>The ID of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-2nalp6yksc805w****</para>
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <para>The name of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>The CIDR block of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.0/24</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The ID of the CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cidr-0zv0q9crqpntzz****</para>
            /// </summary>
            [NameInMap("TransitRouterCidrId")]
            [Validation(Required=false)]
            public string TransitRouterCidrId { get; set; }

        }

    }

}
