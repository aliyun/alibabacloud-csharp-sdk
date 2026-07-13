// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmInstanceConfigLbStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-CN</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en-US</b>: English. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The load balancing policy for the address pools. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>round_robin: Returns all address pools for any DNS request. The address pools are rotated for each request.</para>
        /// </description></item>
        /// <item><description><para>sequence: Returns the address pool with the smallest ordinal number. The smaller the ordinal number, the higher the priority. If the primary address pool is unavailable, the next address pool in the sequence is used.</para>
        /// </description></item>
        /// <item><description><para>weight: Distributes DNS requests to address pools based on their configured weights.</para>
        /// </description></item>
        /// <item><description><para>source_nearest: Returns an address pool based on the proximity of the DNS request source. This implements intelligent DNS resolution and directs users to the nearest access point.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sequence</para>
        /// </summary>
        [NameInMap("AddressPoolLbStrategy")]
        [Validation(Required=false)]
        public string AddressPoolLbStrategy { get; set; }

        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. The token must be unique among different requests. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the instance configuration. A GTM instance can have multiple configurations for the same domain name, such as one for A records and another for AAAA records. The ConfigId uniquely identifies the configuration that you want to modify.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2797349.html">ListCloudGtmInstanceConfigs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the Global Traffic Manager (GTM) 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3h***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The recovery mode for a primary address pool when the load balancing policy is set to sequence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>preemptive: The system switches back to the primary address pool as soon as it recovers.</para>
        /// </description></item>
        /// <item><description><para>non_preemptive: The system continues to use the current address pool even after the primary address pool recovers.</para>
        /// </description></item>
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
