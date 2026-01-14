// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration information about the endpoint group.</para>
        /// </summary>
        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointGroupsResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class ListCustomRoutingEndpointGroupsResponseBodyEndpointGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The description of the endpoint group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EndpointGroup</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epg-bp14sz7ftcwwjgrdm****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>The endpoint group IP addresses.</para>
            /// </summary>
            [NameInMap("EndpointGroupIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupIpList { get; set; }

            /// <summary>
            /// <para>The ID of the region where the endpoint group is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// <para>The endpoint group IP addresses to be confirmed after the GA instance is upgraded.</para>
            /// </summary>
            [NameInMap("EndpointGroupUnconfirmedIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupUnconfirmedIpList { get; set; }

            /// <summary>
            /// <para>The ID of the custom routing listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the service that manages the instance.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the GA instance is managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The actions that users can perform on the managed instance.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </description></item>
            /// <item><description><para>Users can perform only specific actions on a managed instance.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointGroupsResponseBodyEndpointGroupsServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the action on the managed instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Create</b></description></item>
                /// <item><description><b>Update</b></description></item>
                /// <item><description><b>Delete</b></description></item>
                /// <item><description><b>Associate</b></description></item>
                /// <item><description><b>UserUnmanaged</b></description></item>
                /// <item><description><b>CreateChild</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Update</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The type of the child resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Listener</b>: listener</description></item>
                /// <item><description><b>IpSet</b>: acceleration region</description></item>
                /// <item><description><b>EndpointGroup</b>: endpoint group</description></item>
                /// <item><description><b>ForwardingRule</b>: forwarding rule</description></item>
                /// <item><description><b>Endpoint</b>: endpoint</description></item>
                /// <item><description><b>EndpointGroupDestination</b>: protocol mapping of an endpoint group associated with a custom routing listener</description></item>
                /// <item><description><b>EndpointPolicy</b>: traffic policy of an endpoint associated with a custom routing listener</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter takes effect only if <b>Action</b> is set to <b>CreateChild</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the specified actions are managed.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Users cannot perform the specified actions on the managed instance.</description></item>
                /// <item><description><b>false</b>: Users can perform the specified actions on the managed instance.</description></item>
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
            /// <para>The status of the endpoint group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init</b></description></item>
            /// <item><description><b>active</b></description></item>
            /// <item><description><b>updating</b></description></item>
            /// <item><description><b>deleting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
