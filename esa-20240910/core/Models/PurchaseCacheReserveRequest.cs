// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurchaseCacheReserveRequest : TeaModel {
        /// <summary>
        /// <para>Whether to automatically pay. The default value is false.</para>
        /// <list type="bullet">
        /// <item><description>true: Automatically pay.</description></item>
        /// <item><description>false: Do not automatically pay.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Whether to auto-renew:</para>
        /// <list type="bullet">
        /// <item><description>true: Auto-renew.</description></item>
        /// <item><description>false: Do not auto-renew.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Billing type</para>
        /// <list type="bullet">
        /// <item><description>PREPAY: Prepaid.</description></item>
        /// <item><description>POSTPAY: Postpaid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Cache retention region</para>
        /// <list type="bullet">
        /// <item><description>HK: Hong Kong, China</description></item>
        /// <item><description>CN-beijing: Mainland China - Beijing</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HK</para>
        /// </summary>
        [NameInMap("CrRegion")]
        [Validation(Required=false)]
        public string CrRegion { get; set; }

        /// <summary>
        /// <para>Purchase period (unit: month).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>Cache retention specification (unit: GB).</para>
        /// 
        /// <b>Example:</b>
        /// <para>512000</para>
        /// </summary>
        [NameInMap("QuotaGb")]
        [Validation(Required=false)]
        public long? QuotaGb { get; set; }

    }

}
