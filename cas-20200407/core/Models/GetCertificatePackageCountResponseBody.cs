// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCertificatePackageCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The message notification quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{TotalCount=189, RemainCount=94, UsedCount=95}</para>
        /// </summary>
        [NameInMap("NoticeCountDetail")]
        [Validation(Required=false)]
        public string NoticeCountDetail { get; set; }

        /// <summary>
        /// <para>The details of certificate brand products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;BrandName&quot;: &quot;CFCA&quot;,
        ///     &quot;TotalCount&quot;: 14,
        ///     &quot;DomainType&quot;: &quot;ONE&quot;,
        ///     &quot;RemainCount&quot;: 14,
        ///     &quot;ProductCode&quot;: &quot;cfca-ev-1-advanced&quot;,
        ///     &quot;CertType&quot;: &quot;EV&quot;,
        ///     &quot;ProductId&quot;: 8,
        ///     &quot;UsedCount&quot;: 0
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("ProductCountList")]
        [Validation(Required=false)]
        public string ProductCountList { get; set; }

        /// <summary>
        /// <para>The acceleration gateway forwarding quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{TotalCount=116900, RemainCount=90448, AutoPay=0, AutoPayCount=5000, UsedCount=26452}</para>
        /// </summary>
        [NameInMap("ProxyCountDetail")]
        [Validation(Required=false)]
        public string ProxyCountDetail { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08F45EA0-66A7-4504-9B31-3589F5CE308D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of domain names bound to certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{TotalCount=573, RemainCount=243, FreeQuota=10, UsedCount=330}</para>
        /// </summary>
        [NameInMap("TotalCountDetail")]
        [Validation(Required=false)]
        public string TotalCountDetail { get; set; }

        /// <summary>
        /// <para>The usage of the hosting quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{TotalCount=177, ValidCount=6, RemainCount=129, UsedCount=48}</para>
        /// </summary>
        [NameInMap("TrusteeCountDetail")]
        [Validation(Required=false)]
        public string TrusteeCountDetail { get; set; }

    }

}
