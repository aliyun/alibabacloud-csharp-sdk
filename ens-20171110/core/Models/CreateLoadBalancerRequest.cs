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
        /// <para>Ensures the idempotency of the request to avoid duplicate operations caused by multiple retries.</para>
        /// <list type="bullet">
        /// <item><description><para>Generate a parameter value from your client and ensure that the value is unique across different requests. The ClientToken value supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>If you use a ClientToken that has been used before and the other request parameters remain unchanged, the client receives the same result as the first submission, with no impact on your server-side state.</para>
        /// </description></item>
        /// <item><description><para>You can retry when the API times out or returns the PROCESSING error code, and idempotency takes effect. If the return result is an HTTP 200 status code, the retry returns the same result as the previous call with no impact on your server-side state. If the return result is an HTTP 4xx status code and the error code is not PROCESSING, idempotency does not take effect.</para>
        /// </description></item>
        /// <item><description><para>The ClientToken is valid for 10 minutes.</para>
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
        /// <para>The ID of the ENS edge zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The name of the load balancing instance. The name must be 1 to 80 characters in length and can contain letters and Chinese characters. If you do not specify this parameter, the system automatically assigns an instance name.</para>
        /// <remarks>
        /// <para>The name cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The type of the Edge Load Balancing instance.</para>
        /// <list type="bullet">
        /// <item><description>CLB: Classic Load Balancing instance.</description></item>
        /// <item><description>InternetDR: Public pattern load balancing instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLB</para>
        /// </summary>
        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// <para>The network ID of the Edge Load Balancing (ELB) instance to create.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-5sax03dh2eyagujgsn7z9****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The billing type. PostPaid (currently the only supported type): pay-as-you-go.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the VPC instance belongs.</para>
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
