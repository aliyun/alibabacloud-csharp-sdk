// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of accelerated domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<ListDomainsResponseBodyDomains> Domains { get; set; }
        public class ListDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>A list of GA instances.</para>
            /// </summary>
            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<ListDomainsResponseBodyDomainsAccelerators> Accelerators { get; set; }
            public class ListDomainsResponseBodyDomainsAccelerators : TeaModel {
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
                /// <para>The name of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Accelerator</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
                /// <para>The actions that you can perform on the managed instance.</para>
                /// <remarks>
                /// <para> This parameter takes effect only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>You can perform only specific actions on a managed instance.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ServiceManagedInfos")]
                [Validation(Required=false)]
                public List<ListDomainsResponseBodyDomainsAcceleratorsServiceManagedInfos> ServiceManagedInfos { get; set; }
                public class ListDomainsResponseBodyDomainsAcceleratorsServiceManagedInfos : TeaModel {
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
                    /// <item><description><b>true</b>: The specified actions are managed, and you cannot perform the specified actions on the managed instance.</description></item>
                    /// <item><description><b>false</b>: The specified actions are not managed, and you can perform the specified actions on the managed instance.</description></item>
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
            /// <para>The accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The ICP filing status of the accelerated domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>illegal:</b> The domain name is illegal.</description></item>
            /// <item><description><b>inactive:</b> The domain name has not completed ICP filing.</description></item>
            /// <item><description><b>active:</b> The domain name has a valid ICP number.</description></item>
            /// <item><description><b>unknown:</b> The ICP filing status is unknown.</description></item>
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
        /// <para>The number of entries returned per page.</para>
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
