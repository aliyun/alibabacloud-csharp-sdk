// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of assets that are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IgnoreAssetCount")]
        [Validation(Required=false)]
        public int? IgnoreAssetCount { get; set; }

        /// <summary>
        /// <para>The number of domain names that are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IgnoreDomainCount")]
        [Validation(Required=false)]
        public int? IgnoreDomainCount { get; set; }

        /// <summary>
        /// <para>The number of destination IP addresses that are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IgnoreDstIPCount")]
        [Validation(Required=false)]
        public int? IgnoreDstIPCount { get; set; }

        /// <summary>
        /// <para>The number of risky assets with outbound connections over a private network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PrivateRiskAssetCount")]
        [Validation(Required=false)]
        public long? PrivateRiskAssetCount { get; set; }

        /// <summary>
        /// <para>The number of assets with outbound connections over a private network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PrivateTotalAssetCount")]
        [Validation(Required=false)]
        public long? PrivateTotalAssetCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2BD70F4-48BF-5EFD-B103-F0763E27*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of risky assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RiskAssetCount")]
        [Validation(Required=false)]
        public int? RiskAssetCount { get; set; }

        /// <summary>
        /// <para>The number of risky domain names for outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskDomainCount")]
        [Validation(Required=false)]
        public int? RiskDomainCount { get; set; }

        /// <summary>
        /// <para>The number of risky destination IP addresses for outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskDstIPCount")]
        [Validation(Required=false)]
        public int? RiskDstIPCount { get; set; }

        /// <summary>
        /// <para>The number of assets that you follow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SubscribeAssetCount")]
        [Validation(Required=false)]
        public int? SubscribeAssetCount { get; set; }

        /// <summary>
        /// <para>The number of domain names that you follow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SubscribeDomainCount")]
        [Validation(Required=false)]
        public int? SubscribeDomainCount { get; set; }

        /// <summary>
        /// <para>The number of destination IP addresses that you follow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SubscribeDstIPCount")]
        [Validation(Required=false)]
        public int? SubscribeDstIPCount { get; set; }

        /// <summary>
        /// <para>The total number of assets that have outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalAssetCount")]
        [Validation(Required=false)]
        public int? TotalAssetCount { get; set; }

        /// <summary>
        /// <para>The total number of outbound domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalDomainCount")]
        [Validation(Required=false)]
        public int? TotalDomainCount { get; set; }

        /// <summary>
        /// <para>The total number of destination IP addresses for outbound connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>107</para>
        /// </summary>
        [NameInMap("TotalDstIPCount")]
        [Validation(Required=false)]
        public int? TotalDstIPCount { get; set; }

        /// <summary>
        /// <para>The number of outbound connection protocols.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalProtocolCount")]
        [Validation(Required=false)]
        public int? TotalProtocolCount { get; set; }

        /// <summary>
        /// <para>The number of domain names that are not covered by a policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UncoveredAclDomain")]
        [Validation(Required=false)]
        public int? UncoveredAclDomain { get; set; }

        /// <summary>
        /// <para>The number of destination IP addresses that are not covered by a policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UncoveredAclDstIP")]
        [Validation(Required=false)]
        public int? UncoveredAclDstIP { get; set; }

        /// <summary>
        /// <para>The percentage of traffic from unidentified protocols.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20.13</para>
        /// </summary>
        [NameInMap("UnknownProtocolRadio")]
        [Validation(Required=false)]
        public string UnknownProtocolRadio { get; set; }

    }

}
