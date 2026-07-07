// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PurchaseCacheReserveRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables automatic payment.</description></item>
        /// <item><description>false: Disables automatic payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables auto-renewal.</description></item>
        /// <item><description>false: Disables auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PREPAY: upfront.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The cache reserve region.</para>
        /// <list type="bullet">
        /// <item><description>HK: Hong Kong (China)</description></item>
        /// <item><description>CN-beijing: Chinese mainland - Beijing</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HK</para>
        /// </summary>
        [NameInMap("CrRegion")]
        [Validation(Required=false)]
        public string CrRegion { get; set; }

        /// <summary>
        /// <para>The purchase period. Unit: months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The cache reserve specification. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512000</para>
        /// </summary>
        [NameInMap("QuotaGb")]
        [Validation(Required=false)]
        public long? QuotaGb { get; set; }

    }

}
