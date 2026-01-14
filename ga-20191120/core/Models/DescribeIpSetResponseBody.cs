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
        /// <item><description><b>IPv4</b></description></item>
        /// <item><description><b>IPv6</b></description></item>
        /// <item><description><b>DUAL_STACK</b></description></item>
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
        /// <item><description><b>BGP</b>: BGP (Multi-ISP) lines. This is the default value.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro lines.</description></item>
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
        /// <list type="bullet">
        /// <item><description>This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</description></item>
        /// <item><description>Users can perform only specific actions on a managed instance.</description></item>
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
            /// <item><description><b>Listener</b>: listener.</description></item>
            /// <item><description><b>IpSet</b>: acceleration region.</description></item>
            /// <item><description><b>EndpointGroup</b>: endpoint group.</description></item>
            /// <item><description><b>ForwardingRule</b>: forwarding rule.</description></item>
            /// <item><description><b>Endpoint</b>: endpoint.</description></item>
            /// <item><description><b>EndpointGroupDestination</b>: protocol mapping of an endpoint group associated with a custom routing listener.</description></item>
            /// <item><description><b>EndpointPolicy</b>: traffic policy of an endpoint associated with a custom routing listener.</description></item>
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
            /// <item><description><b>true</b>: The specified actions are managed, and users cannot perform the actions on the managed instance.</description></item>
            /// <item><description><b>false</b>: The specified actions are not managed, and users can perform the actions on the managed instance.</description></item>
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
        /// <item><description><b>init</b>: The acceleration region is being initialized.</description></item>
        /// <item><description><b>active</b>: The acceleration region is in the running state.</description></item>
        /// <item><description><b>updating</b>: The acceleration region is being configured.</description></item>
        /// <item><description><b>deleting</b>: The GA instance is being deleted.</description></item>
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
