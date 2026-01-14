// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndpointGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The GA instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>Indicates the status of the binding between the Log Service project and the endpoint group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on:</b> The endpoint group is bound to the Log Service project.</description></item>
        /// <item><description><b>off:</b> The endpoint group is not bound to the Log Service project.</description></item>
        /// <item><description><b>binding:</b> The endpoint group is being bound to the Log Service project.</description></item>
        /// <item><description><b>unbinding:</b> The endpoint group is being unbound from the Log Service project.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AccessLogSwitch")]
        [Validation(Required=false)]
        public string AccessLogSwitch { get; set; }

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
        /// <para>Indicates whether the access log feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAccessLog")]
        [Validation(Required=false)]
        public bool? EnableAccessLog { get; set; }

        /// <summary>
        /// <para>The endpoint group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1dmlohjjz4kqaua****</para>
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
        /// <para>The region ID of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// <para>The endpoint group IP addresses that need to be confirmed after the GA instance is upgraded.</para>
        /// </summary>
        [NameInMap("EndpointGroupUnconfirmedIpList")]
        [Validation(Required=false)]
        public List<string> EndpointGroupUnconfirmedIpList { get; set; }

        /// <summary>
        /// <para>The custom routing listener ID.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the service that manages the GA instance.</para>
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
        /// <para> This parameter takes effect only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Users can perform only specific actions on a managed instance.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeCustomRoutingEndpointGroupResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeCustomRoutingEndpointGroupResponseBodyServiceManagedInfos : TeaModel {
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

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-01</para>
        /// </summary>
        [NameInMap("SlsLogStoreName")]
        [Validation(Required=false)]
        public string SlsLogStoreName { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pn-01</para>
        /// </summary>
        [NameInMap("SlsProjectName")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

        /// <summary>
        /// <para>The region of the logs that are created in Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlsRegion")]
        [Validation(Required=false)]
        public string SlsRegion { get; set; }

        /// <summary>
        /// <para>The status of the endpoint group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init:</b> The endpoint group is being initialized.</description></item>
        /// <item><description><b>active:</b> The endpoint group is running normally.</description></item>
        /// <item><description><b>updating:</b> The endpoint group is being updated.</description></item>
        /// <item><description><b>deleting:</b> The ACL is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
