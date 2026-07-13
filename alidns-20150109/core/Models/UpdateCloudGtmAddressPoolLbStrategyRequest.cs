// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmAddressPoolLbStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US (default): English</para>
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
        /// <para>The load balancing policy for the addresses in the address pool.</para>
        /// <list type="bullet">
        /// <item><description><para>round_robin: Round robin. For each DNS query, all addresses are returned in a rotating order.</para>
        /// </description></item>
        /// <item><description><para>sequence: Sequence. The address with the highest priority is returned. Priority is determined by the ordinal number of an address. A smaller ordinal number indicates a higher priority. If an address is unavailable, the address with the next highest priority is returned.</para>
        /// </description></item>
        /// <item><description><para>weight: Weight. DNS queries are resolved based on the weight that you set for each address.</para>
        /// </description></item>
        /// <item><description><para>source_nearest: Source nearest. This is an intelligent DNS resolution feature. GTM returns an address based on the source of the DNS query. This directs users to the nearest resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sequence</para>
        /// </summary>
        [NameInMap("AddressLbStrategy")]
        [Validation(Required=false)]
        public string AddressLbStrategy { get; set; }

        /// <summary>
        /// <para>The unique ID of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-89528023225442****</para>
        /// </summary>
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. The token must be unique for each request and can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The recovery mode when the load balancing policy is \<c>sequence\\</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>preemptive: Preemptive mode. If a higher-priority address recovers, it is used preferentially.</para>
        /// </description></item>
        /// <item><description><para>non_preemptive: Non-preemptive mode. If a higher-priority address recovers, the current address continues to be used.</para>
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
