// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderRenewRequest : TeaModel {
        /// <summary>
        /// <para>The coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312412</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The language of the error messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The parameters for each domain name to be renewed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderRenewParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderRenewRequestOrderRenewParam> OrderRenewParam { get; set; }
        public class SaveBatchTaskForCreatingOrderRenewRequestOrderRenewParam : TeaModel {
            /// <summary>
            /// <para>The current expiration date of the domain name, expressed in milliseconds since 00:00:00 UTC on January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1522080000000</para>
            /// </summary>
            [NameInMap("CurrentExpirationDate")]
            [Validation(Required=false)]
            public long? CurrentExpirationDate { get; set; }

            /// <summary>
            /// <para>The domain name that you want to renew. You can obtain a list of your domain names by calling the <a href="https://help.aliyun.com/document_detail/67712.html">QueryDomainList</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow the renewal of premium domain names. Default value: false.</para>
            /// </summary>
            [NameInMap("PermitPremiumRenew")]
            [Validation(Required=false)]
            public bool? PermitPremiumRenew { get; set; }

            /// <summary>
            /// <para>The renewal duration, in years. Default value: <b>1</b>. Valid values: <b>1</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubscriptionDuration")]
            [Validation(Required=false)]
            public int? SubscriptionDuration { get; set; }

        }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123</para>
        /// </summary>
        [NameInMap("PromotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: Do not use a coupon.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Use a coupon.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseCoupon")]
        [Validation(Required=false)]
        public bool? UseCoupon { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a promotion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: Do not use a promotion.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Use a promotion.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UsePromotion")]
        [Validation(Required=false)]
        public bool? UsePromotion { get; set; }

        /// <summary>
        /// <para>The user\&quot;s IP address. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
