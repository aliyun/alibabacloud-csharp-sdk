// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointGroupDestinationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The destination configurations of the endpoint group.</para>
        /// </summary>
        [NameInMap("Destinations")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinations> Destinations { get; set; }
        public class ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinations : TeaModel {
            /// <summary>
            /// <para>The instance ID of the Alibaba Cloud Global Accelerator (GA) instance to which the endpoint group destination configuration belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint group destination configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dst-123abc****</para>
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint group to which the destination configuration belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epg-bp14sz7ftcwwjgrdm****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>The start port of the backend service of the endpoint group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// <para>The ID of the listener to which the endpoint group destination configuration belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The Protocol Type of the backend service of the endpoint group.</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b>: TCP protocol.</para>
            /// </description></item>
            /// <item><description><para><b>UDP</b>: UDP protocol.</para>
            /// </description></item>
            /// <item><description><para><b>TCP,UDP</b>: TCP and UDP protocols.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// <para>The ID of the service to which the managed instance belongs.</para>
            /// <remarks>
            /// <para>This parameter is valid only when <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is managed. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><para>true: The instance is managed.  </para>
            /// </description></item>
            /// <item><description><para>false: The instance is not managed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The list of action policies that the user can execute on the managed instance.</para>
            /// <remarks>
            /// <para>This parameter is valid only when <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// <list type="bullet">
            /// <item><description>When the instance is in the managed state, user operations on the instance are restricted, and certain operations are prohibited.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinationsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointGroupDestinationsResponseBodyDestinationsServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the managed policy action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Create</b>: Create an instance.</description></item>
                /// <item><description><b>Update</b>: Update the current instance.</description></item>
                /// <item><description><b>Delete</b>: Delete the current instance.</description></item>
                /// <item><description><b>Associate</b>: Reference or be referenced by the current instance.</description></item>
                /// <item><description><b>UserUnmanaged</b>: Unmanage the instance.</description></item>
                /// <item><description><b>CreateChild</b>: Create a child resource under the current instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Create</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The type of the child resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Listener</b>: listener resource.</description></item>
                /// <item><description><b>IpSet</b>: acceleration region resource.</description></item>
                /// <item><description><b>EndpointGroup</b>: endpoint group resource.</description></item>
                /// <item><description><b>ForwardingRule</b>: forwarding rule resource.</description></item>
                /// <item><description><b>Endpoint</b>: endpoint resource.</description></item>
                /// <item><description><b>EndpointGroupDestination</b>: protocol mapping resource of the endpoint group under a custom routing listener.</description></item>
                /// <item><description><b>EndpointPolicy</b>: endpoint traffic policy resource under a custom routing listener.<remarks>
                /// <para>This parameter is valid only when <b>Action</b> is set to <b>CreateChild</b>.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the managed policy action is managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The managed policy action is managed. The user cannot perform the action specified by Action on the managed instance.</description></item>
                /// <item><description><b>false</b>: The managed policy action is not managed. The user can perform the action specified by Action on the managed instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// <para>The end port of the backend service of the endpoint group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
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

    }

}
