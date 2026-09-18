// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListTrusteeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. If NextToken is empty, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0068247C-A454-5FC9-93BF-C41CBB5CD19E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;VerifyStatus&quot;: 0,
        ///     &quot;ShowRefund&quot;: false,
        ///     &quot;CertificateId&quot;: 0,
        ///     &quot;SourceType&quot;: &quot;buy&quot;,
        ///     &quot;IsMix&quot;: false,
        ///     &quot;CertType&quot;: &quot;DV&quot;,
        ///     &quot;PartnerOrderId&quot;: null,
        ///     &quot;ProductId&quot;: 53,
        ///     &quot;StatusCode&quot;: &quot;closed&quot;,
        ///     &quot;KeyProtection&quot;: &quot;UNKNOWN&quot;,
        ///     &quot;BrandName&quot;: &quot;Rapid&quot;,
        ///     &quot;JobStatus&quot;: &quot;editing&quot;,
        ///     &quot;Month&quot;: 6,
        ///     &quot;IsFree&quot;: false,
        ///     &quot;DomainType&quot;: &quot;ONE&quot;,
        ///     &quot;IsRefunding&quot;: false,
        ///     &quot;RevokeReturnCount&quot;: false,
        ///     &quot;JobId&quot;: 440231,
        ///     &quot;DomainCount&quot;: 1,
        ///     &quot;InstanceId&quot;: &quot;cas-ivauto-fe7kv4-15650439-renew&quot;,
        ///     &quot;ProductCode&quot;: &quot;geotrust-dv-1-starter&quot;,
        ///     &quot;WildDomainCount&quot;: 0,
        ///     &quot;OrderId&quot;: 15652305,
        ///     &quot;Algorithm&quot;: &quot;RSA&quot;,
        ///     &quot;Year&quot;: 1,
        ///     &quot;IsRenew&quot;: false,
        ///     &quot;Domain&quot;: &quot;tw.certqa.cn&quot;,
        ///     &quot;AllDomain&quot;: &quot;tw.certqa.cn&quot;,
        ///     &quot;BuyDate&quot;: 1773906251000
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("TrusteeOrderList")]
        [Validation(Required=false)]
        public string TrusteeOrderList { get; set; }

    }

}
