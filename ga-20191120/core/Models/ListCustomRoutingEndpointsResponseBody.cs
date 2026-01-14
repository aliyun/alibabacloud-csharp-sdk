// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the endpoints.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListCustomRoutingEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListCustomRoutingEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The ID of the GA instance with which the endpoint is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The name of the vSwitch that is specified as an endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-test01</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint group to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epg-bp16jdc00bhe97sr5****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>The endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp14sz7ftcwwjgrdm****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the listener to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The ID of the service that manages the GA instance.</para>
            /// <remarks>
            /// <para> This parameter is valid only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
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
            /// <para> This parameter is valid only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Users can perform only specific actions on a managed instance.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListCustomRoutingEndpointsResponseBodyEndpointsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListCustomRoutingEndpointsResponseBodyEndpointsServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the action performed on the managed instance. Valid values:</para>
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
                /// <para> This parameter is valid only if <b>Action</b> is set to <b>CreateChild</b>.</para>
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
                /// <item><description><b>true</b>: The specified actions are managed, and users cannot perform the specified actions on the managed resource.</description></item>
                /// <item><description><b>false</b>: The specified actions are not managed, and users can perform the specified actions on the managed resource.</description></item>
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
            /// <para>The access policy of traffic that is destined for the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AllowAll</b>: allows all traffic to the endpoint.</description></item>
            /// <item><description><b>DenyAll</b>: denies all traffic to the endpoint.</description></item>
            /// <item><description><b>AllowCustom</b>: allows traffic only to specified destinations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DenyAll</para>
            /// </summary>
            [NameInMap("TrafficToEndpointPolicy")]
            [Validation(Required=false)]
            public string TrafficToEndpointPolicy { get; set; }

            /// <summary>
            /// <para>The backend service type of the endpoint.</para>
            /// <para>Only <b>PrivateSubNet</b> may be returned, which indicates a private CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrivateSubNet</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
