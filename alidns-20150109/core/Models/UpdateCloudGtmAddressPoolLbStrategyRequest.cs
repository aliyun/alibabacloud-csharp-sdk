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
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US (default): English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Load balancing policy among addresses in the address pool:</para>
        /// <list type="bullet">
        /// <item><description>round_robin: Round-robin, for any source of DNS resolution requests, all addresses are returned. The order of all addresses is rotated each time.</description></item>
        /// <item><description>sequence: Sequential, for any source of DNS resolution requests, the address with the smaller sequence number (the sequence number indicates the priority of address returns, with smaller numbers having higher priority) is returned. If the address with the smaller sequence number is unavailable, the next address with a smaller sequence number is returned.</description></item>
        /// <item><description>weight: Weighted, supports setting different weight values for each address, realizing the return of addresses according to the weight ratio for resolution queries.</description></item>
        /// <item><description>source_nearest: Source-nearest, i.e., intelligent resolution function, where GTM can return different addresses based on the source of different DNS resolution requests, achieving the effect of users accessing nearby.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sequence</para>
        /// </summary>
        [NameInMap("AddressLbStrategy")]
        [Validation(Required=false)]
        public string AddressLbStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the address pool. This ID uniquely identifies the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-89528023225442**16</para>
        /// </summary>
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

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
        /// <para>The mode used if the address with the smallest sequence number is recovered. This parameter is required only when AddressLbStrategy is set to sequence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>preemptive: The address with the smallest sequence number is preferentially used if this address is recovered.</description></item>
        /// <item><description>non_preemptive: The current address is still used even if the address with the smallest sequence number is recovered.</description></item>
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
