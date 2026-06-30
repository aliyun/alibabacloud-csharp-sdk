// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeIpSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the acceleration region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AccelerateRegionId")]
        [Validation(Required=false)]
        public string AccelerateRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1yeeq8yfoyszmqy****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The bandwidth that is allocated to the acceleration region. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The list of accelerated IP addresses in the acceleration region.</para>
        /// </summary>
        [NameInMap("IpAddressList")]
        [Validation(Required=false)]
        public List<string> IpAddressList { get; set; }

        /// <summary>
        /// <para>The ID of the acceleration region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ips-bp11ilwqjdkjeg9r7****</para>
        /// </summary>
        [NameInMap("IpSetId")]
        [Validation(Required=false)]
        public string IpSetId { get; set; }

        /// <summary>
        /// <para>The IP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IPv4</b></para>
        /// </description></item>
        /// <item><description><para><b>IPv6</b></para>
        /// </description></item>
        /// <item><description><para><b>DUAL_STACK</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The line type of the elastic IP address (EIP) in the acceleration region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BGP</b>: BGP (Multi-ISP) lines. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>BGP_PRO</b>: BGP (Multi-ISP) Pro lines.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("IspType")]
        [Validation(Required=false)]
        public string IspType { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D2BFF54-6AF2-4679-88C4-2F2E187F16CB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the service that manages the instance.</para>
        /// <remarks>
        /// <para>This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</para>
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
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
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
        /// <para>The actions that users can perform on the managed instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>Users can perform only specific actions on a managed instance.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeIpSetResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeIpSetResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// <para>The name of the action on the managed instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Create</b></para>
            /// </description></item>
            /// <item><description><para><b>Update</b></para>
            /// </description></item>
            /// <item><description><para><b>Delete</b></para>
            /// </description></item>
            /// <item><description><para><b>Associate</b></para>
            /// </description></item>
            /// <item><description><para><b>UserUnmanaged</b></para>
            /// </description></item>
            /// <item><description><para><b>CreateChild</b></para>
            /// </description></item>
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
            /// <item><description><para><b>Listener</b>: listener.</para>
            /// </description></item>
            /// <item><description><para><b>IpSet</b>: acceleration region.</para>
            /// </description></item>
            /// <item><description><para><b>EndpointGroup</b>: endpoint group.</para>
            /// </description></item>
            /// <item><description><para><b>ForwardingRule</b>: forwarding rule.</para>
            /// </description></item>
            /// <item><description><para><b>Endpoint</b>: endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>EndpointGroupDestination</b>: protocol mapping of an endpoint group associated with a custom routing listener.</para>
            /// </description></item>
            /// <item><description><para><b>EndpointPolicy</b>: traffic policy of an endpoint associated with a custom routing listener.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only if <b>Action</b> is set to <b>CreateChild</b>.</para>
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
            /// <item><description><para><b>true</b>: The specified actions are managed, and users cannot perform the actions on the managed instance.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The specified actions are not managed, and users can perform the actions on the managed instance.</para>
            /// </description></item>
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
        /// <para>The status of the acceleration region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>init</b>: The acceleration region is being initialized.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: The acceleration region is in the running state.</para>
        /// </description></item>
        /// <item><description><para><b>updating</b>: The acceleration region is being configured.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The GA instance is being deleted.</para>
        /// </description></item>
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
