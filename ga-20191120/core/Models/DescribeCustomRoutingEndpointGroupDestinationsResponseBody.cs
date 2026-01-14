// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndpointGroupDestinationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint group mapping configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dst-123abc****</para>
        /// </summary>
        [NameInMap("DestinationId")]
        [Validation(Required=false)]
        public string DestinationId { get; set; }

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
        /// <para>The start port of the backend service port range of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("FromPort")]
        [Validation(Required=false)]
        public int? FromPort { get; set; }

        /// <summary>
        /// <para>The ID of the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The backend service protocol of the endpoint group.</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b>: TCP</description></item>
        /// <item><description><b>UDP</b>: UDP</description></item>
        /// <item><description><b>TCP,UDP</b>: TCP and UDP</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

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
        /// <para>The service ID to which the managed instance belongs.</para>
        /// <remarks>
        /// <para> Valid only when the ServiceManaged parameter is True.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALB</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>Is it a managed instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>A list of action policies that users can execute on this managed instance.</para>
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeCustomRoutingEndpointGroupDestinationsResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeCustomRoutingEndpointGroupDestinationsResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// <para>Managed policy action name, Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Create</description></item>
            /// <item><description>Update</description></item>
            /// <item><description>Delete</description></item>
            /// <item><description>Associate</description></item>
            /// <item><description>UserUnmanaged</description></item>
            /// <item><description>CreateChild</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Update</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>Sub resource type, Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Listener</description></item>
            /// <item><description>IpSet</description></item>
            /// <item><description>EndpointGroup</description></item>
            /// <item><description>ForwardingRule</description></item>
            /// <item><description>Endpoint</description></item>
            /// <item><description>EndpointGroupDestination</description></item>
            /// <item><description>EndpointPolicy</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only valid when the Action parameter is CreateChild.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Listener</para>
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// <para>Is the managed policy action managed, Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The managed policy action is managed, and users do not have permission to perform the operation specified in the Action on the managed instance.</para>
            /// </description></item>
            /// <item><description><para>false: The managed policy action is not managed, and users have permission to perform the operation specified in the Action on the managed instance.</para>
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
        /// <para>The status of the endpoint group mapping configuration.</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: being initialized.</description></item>
        /// <item><description><b>active</b>: normal.</description></item>
        /// <item><description><b>updating</b>: being updated.</description></item>
        /// <item><description><b>deleting</b>: being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The end port of the backend service port range of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ToPort")]
        [Validation(Required=false)]
        public int? ToPort { get; set; }

    }

}
