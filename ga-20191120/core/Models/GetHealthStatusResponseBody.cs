// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the endpoint groups.</para>
        /// </summary>
        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<GetHealthStatusResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class GetHealthStatusResponseBodyEndpointGroups : TeaModel {
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
            /// <para>The type of the endpoint group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default:</b> the default endpoint group.</description></item>
            /// <item><description><b>virtual:</b> a virtual endpoint group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            /// <summary>
            /// <para>The information about the endpoints.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<GetHealthStatusResponseBodyEndpointGroupsEndpoints> Endpoints { get; set; }
            public class GetHealthStatusResponseBodyEndpointGroupsEndpoints : TeaModel {
                /// <summary>
                /// <para>The IP address of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.0.XX.XX</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The ID of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-hp33b2e43fays7s8****</para>
                /// </summary>
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                /// <summary>
                /// <para>The health check details of the endpoint.</para>
                /// <remarks>
                /// <para> This parameter is unavailable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("HealthDetail")]
                [Validation(Required=false)]
                public string HealthDetail { get; set; }

                /// <summary>
                /// <para>The health status of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>init:</b> The endpoint is being initialized.</description></item>
                /// <item><description><b>normal:</b> The endpoint is normal.</description></item>
                /// <item><description><b>abnormal:</b> The endpoint is abnormal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// <para>The port that is used to connect to the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// <para>The type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Domain:</b> a custom domain name.</description></item>
                /// <item><description><b>Ip:</b> a custom IP address.</description></item>
                /// <item><description><b>PublicIp:</b> a public IP address provided by Alibaba Cloud.</description></item>
                /// <item><description><b>ECS:</b> an Elastic Compute Service (ECS) instance.</description></item>
                /// <item><description><b>SLB:</b> a Classic Load Balancer (CLB) instance.</description></item>
                /// <item><description><b>ALB:</b> an Application Load Balancer (ALB) instance.</description></item>
                /// <item><description><b>OSS:</b> an Object Storage Service (OSS) bucket.</description></item>
                /// <item><description><b>ENI:</b> an elastic network interface (ENI).</description></item>
                /// <item><description><b>NLB:</b> a Network Load Balancer (NLB) instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Ip</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The IDs of the forwarding rules.</para>
            /// </summary>
            [NameInMap("ForwardingRuleIds")]
            [Validation(Required=false)]
            public List<string> ForwardingRuleIds { get; set; }

            /// <summary>
            /// <para>The health status of the endpoint group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init:</b> The endpoint group is being initialized.</description></item>
            /// <item><description><b>normal:</b> The endpoint group is normal.</description></item>
            /// <item><description><b>abnormal:</b> The endpoint group is abnormal.</description></item>
            /// <item><description><b>partiallyAbnormal:</b> The endpoint group is partially abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

        }

        /// <summary>
        /// <para>The health status of endpoints and endpoint groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b></description></item>
        /// <item><description><b>abnormal</b></description></item>
        /// <item><description><b>partiallyAbnormal</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64ADAB1E-0B7F-4FD8-A404-3BECC0E9CCFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
