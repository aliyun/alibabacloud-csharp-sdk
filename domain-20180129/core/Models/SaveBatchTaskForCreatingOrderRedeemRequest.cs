// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderRedeemRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderRedeemParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderRedeemRequestOrderRedeemParam> OrderRedeemParam { get; set; }
        public class SaveBatchTaskForCreatingOrderRedeemRequestOrderRedeemParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>000000</para>
            /// </summary>
            [NameInMap("CurrentExpirationDate")]
            [Validation(Required=false)]
            public long? CurrentExpirationDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Aliyun.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123213123</para>
        /// </summary>
        [NameInMap("PromotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseCoupon")]
        [Validation(Required=false)]
        public bool? UseCoupon { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UsePromotion")]
        [Validation(Required=false)]
        public bool? UsePromotion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
