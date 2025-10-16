// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingStatisticResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IgnoreAssetCount")]
        [Validation(Required=false)]
        public int? IgnoreAssetCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IgnoreDomainCount")]
        [Validation(Required=false)]
        public int? IgnoreDomainCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IgnoreDstIPCount")]
        [Validation(Required=false)]
        public int? IgnoreDstIPCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PrivateRiskAssetCount")]
        [Validation(Required=false)]
        public long? PrivateRiskAssetCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PrivateTotalAssetCount")]
        [Validation(Required=false)]
        public long? PrivateTotalAssetCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E2BD70F4-48BF-5EFD-B103-F0763E27*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RiskAssetCount")]
        [Validation(Required=false)]
        public int? RiskAssetCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskDomainCount")]
        [Validation(Required=false)]
        public int? RiskDomainCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskDstIPCount")]
        [Validation(Required=false)]
        public int? RiskDstIPCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SubscribeAssetCount")]
        [Validation(Required=false)]
        public int? SubscribeAssetCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SubscribeDomainCount")]
        [Validation(Required=false)]
        public int? SubscribeDomainCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SubscribeDstIPCount")]
        [Validation(Required=false)]
        public int? SubscribeDstIPCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalAssetCount")]
        [Validation(Required=false)]
        public int? TotalAssetCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalDomainCount")]
        [Validation(Required=false)]
        public int? TotalDomainCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>107</para>
        /// </summary>
        [NameInMap("TotalDstIPCount")]
        [Validation(Required=false)]
        public int? TotalDstIPCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalProtocolCount")]
        [Validation(Required=false)]
        public int? TotalProtocolCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UncoveredAclDomain")]
        [Validation(Required=false)]
        public int? UncoveredAclDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UncoveredAclDstIP")]
        [Validation(Required=false)]
        public int? UncoveredAclDstIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20.13</para>
        /// </summary>
        [NameInMap("UnknownProtocolRadio")]
        [Validation(Required=false)]
        public string UnknownProtocolRadio { get; set; }

    }

}
