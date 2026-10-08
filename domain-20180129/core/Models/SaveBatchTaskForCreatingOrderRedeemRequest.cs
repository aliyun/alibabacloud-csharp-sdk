// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderRedeemRequest : TeaModel {
        /// <summary>
        /// <para>Coupon number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese;  </description></item>
        /// <item><description><b>en</b>: English.</description></item>
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
        /// <para>List of job details.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderRedeemParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderRedeemRequestOrderRedeemParam> OrderRedeemParam { get; set; }
        public class SaveBatchTaskForCreatingOrderRedeemRequestOrderRedeemParam : TeaModel {
            /// <summary>
            /// <para>Current expiration date of the domain name, represented as the number of milliseconds from 00:00 UTC on January 1, 1970, to the domain’s current expiration date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>000000</para>
            /// </summary>
            [NameInMap("CurrentExpirationDate")]
            [Validation(Required=false)]
            public long? CurrentExpirationDate { get; set; }

            /// <summary>
            /// <para>Domain name. If multiple domain names are involved, pass a domain name list. You can obtain the domain name list by using the <a href="https://help.aliyun.com/document_detail/67712.html">QueryDomainList</a> API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        /// <summary>
        /// <para>Coupon number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123213123</para>
        /// </summary>
        [NameInMap("PromotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        /// <summary>
        /// <para>Is coupon used? Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No.  </description></item>
        /// <item><description><b>true</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseCoupon")]
        [Validation(Required=false)]
        public bool? UseCoupon { get; set; }

        /// <summary>
        /// <para>Is coupon used? Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No.  </description></item>
        /// <item><description><b>true</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UsePromotion")]
        [Validation(Required=false)]
        public bool? UsePromotion { get; set; }

        /// <summary>
        /// <para>User IP address. You can set it to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
