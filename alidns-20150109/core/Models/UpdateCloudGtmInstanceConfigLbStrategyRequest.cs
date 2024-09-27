// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmInstanceConfigLbStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the returned results are displayed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Chinese</description></item>
        /// <item><description><b>en-US</b> (default): English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The new policy for load balancing between address pools. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>round_robin: All address pools are returned for Domain Name System (DNS) requests from any source. All address pools are sorted in round-robin mode each time they are returned.</description></item>
        /// <item><description>sequence: The address pool with the smallest sequence number is preferentially returned for DNS requests from any source. The sequence number indicates the priority for returning the address pool. A smaller sequence number indicates a higher priority. If the address pool with the smallest sequence number is unavailable, the address pool with the second smallest sequence number is returned.</description></item>
        /// <item><description>weight: You can set a different weight value for each address pool. This way, address pools are returned based on the weight values.</description></item>
        /// <item><description>source_nearest: GTM returns different address pools based on the sources of DNS requests. This way, users can access nearby address pools.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sequence</para>
        /// </summary>
        [NameInMap("AddressPoolLbStrategy")]
        [Validation(Required=false)]
        public string AddressPoolLbStrategy { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration ID of the access domain name. Two configuration IDs exist when the access domain name is bound to the same GTM instance but an A record and an AAAA record are configured for the access domain name. The configuration ID uniquely identifies a configuration.</para>
        /// <para>You can call the <a href="~~ListCloudGtmInstanceConfigs~~">ListCloudGtmInstanceConfigs</a> operation to query the configuration ID of the desired access domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000**11</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the GTM 3.0 instance for which you want to modify the load balancing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The mode used if the address pool with the smallest sequence number is recovered. This parameter is required when AddressPoolLbStrategy is set to sequence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>preemptive: The address pool with the smallest sequence number is preferentially used if this address pool is recovered.</description></item>
        /// <item><description>non_preemptive: The current address pool is still used even if the address pool with the smallest sequence number is recovered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>preemptive</para>
        /// </summary>
        [NameInMap("SequenceLbStrategyMode")]
        [Validation(Required=false)]
        public string SequenceLbStrategyMode { get; set; }

    }

}
