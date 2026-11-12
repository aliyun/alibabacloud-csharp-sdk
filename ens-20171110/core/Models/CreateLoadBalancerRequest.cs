// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The billing cycle of the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. This prevents duplicate operations caused by multiple retries.</para>
        /// <list type="bullet">
        /// <item><description><para>Generate the value from your client and ensure that it is unique among different requests. The client token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>If you resubmit a request with a used client token and all other request parameters remain unchanged, the client receives the same response as the first request, and the server state remains unaffected.</para>
        /// </description></item>
        /// <item><description><para>You can retry the request when the operation times out or the error code is PROCESSING, and the idempotence remains valid. If the HTTP status code 200 is returned, the client receives the same response after a retry, and the server state remains unaffected. If an HTTP 4xx status code is returned and the error code is not PROCESSING, the idempotence is invalid.</para>
        /// </description></item>
        /// <item><description><para>The client token is valid for 10 minutes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>26C28756-2586-17AF-B802-0DC50D8FDEBB</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ENS edge zone ID. Not all ENS edge zones support creating an Edge Load Balancer (ELB) instance. Before calling this operation, verify that the target edge zone supports this feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The name of the load balancing instance. The name must be 1 to 80 characters in length, and can contain English letters and Chinese characters. If you do not specify this parameter, the system randomly allocates a name to the instance.</para>
        /// <remarks>
        /// <para>The name cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gcs-pre-websocket-eslb-telecom</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The specification of the load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elb.s2.medium</para>
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// <para>The type of the edge load balancing (ELB) instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CLB: traditional load balancing instance.</description></item>
        /// <item><description>InternetDR: public pattern load balancing instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLB</para>
        /// </summary>
        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// <para>The network ID of the edge load balancing (ELB) instance to be created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-5sax03dh2eyagujgsn7z9****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The billing method. Currently, only PostPaid (pay-as-you-go) is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the VPC-connected instance belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5s78haoys9oylle6ln71m****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
