// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointTrafficPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A list of traffic policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The ID of the GA instance to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The IP addresses of the traffic policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint group to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint to which the traffic policy belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp14sz7ftcwwjgrdm****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the custom routing listener to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The ID of the traffic policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ply-bp1dmlohjjz4kqaun****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The port range of the traffic policy.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesPortRanges> PortRanges { get; set; }
            public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesPortRanges : TeaModel {
                /// <summary>
                /// <para>The first port of the port range used by the traffic destination to process requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// <para>The last port of the port range used by the traffic destination to process requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            /// <summary>
            /// <para>The ID of the service that manages the instance.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The GA instance is managed.</description></item>
            /// <item><description><b>false</b>: The GA instance is not managed.</description></item>
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
            /// <list type="bullet">
            /// <item><description>This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</description></item>
            /// <item><description>Users can perform only specific actions on a managed instance.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointTrafficPoliciesResponseBodyPoliciesServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the action on the managed instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Create</b>: Create an instance.</description></item>
                /// <item><description><b>Update</b>: Update the current instance.</description></item>
                /// <item><description><b>Delete</b>: Delete the current instance.</description></item>
                /// <item><description><b>Associate</b>: Reference the current instance.</description></item>
                /// <item><description><b>UserUnmanaged</b>: Unmanage the instance.</description></item>
                /// <item><description><b>CreateChild</b>: Create a child resource in the current instance.</description></item>
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
                /// <item><description><b>Listener</b>: listener.</description></item>
                /// <item><description><b>IpSet</b>: acceleration region.</description></item>
                /// <item><description><b>EndpointGroup</b>: endpoint group.</description></item>
                /// <item><description><b>ForwardingRule</b>: forwarding rule.</description></item>
                /// <item><description><b>Endpoint</b>: endpoint.</description></item>
                /// <item><description><b>EndpointGroupDestination</b>: protocol mapping of an endpoint group associated with a custom routing listener.</description></item>
                /// <item><description><b>EndpointPolicy</b>: traffic policy of an endpoint associated with a custom routing listener.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only if the value of <b>Action</b> is <b>CreateChild</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the specified actions are managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The specified actions are managed, and users cannot perform the specified actions on the managed instance.</description></item>
                /// <item><description><b>false</b>: The specified actions are not managed, and users can perform the specified actions on the managed instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

        }

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
