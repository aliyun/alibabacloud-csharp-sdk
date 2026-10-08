// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderTransferRequest : TeaModel {
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
        /// <para>Language of the error message returned by the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value is <b>en</b>.</para>
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
        [NameInMap("OrderTransferParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderTransferRequestOrderTransferParam> OrderTransferParam { get; set; }
        public class SaveBatchTaskForCreatingOrderTransferRequestOrderTransferParam : TeaModel {
            /// <summary>
            /// <para>Domain name transfer-in password. If multiple domain names are involved, pass the passwords as a list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCode</para>
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// <para>Domain name. If multiple domain names are involved, pass them as a list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Is transfer-in of premium domain names allowed? Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: Allowed.</description></item>
            /// <item><description><b>true</b>: Not allowed.</description></item>
            /// </list>
            /// <para>Default value: <b>false</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PermitPremiumTransfer")]
            [Validation(Required=false)]
            public bool? PermitPremiumTransfer { get; set; }

            /// <summary>
            /// <para>ID of an identity-verified domain name registrant profile. You can obtain this ID by invoking the <a href="https://help.aliyun.com/document_detail/69359.htm?spm=a2c4g.11186623.0.0.5096253c12PfdB">QueryRegistrantProfileRealNameVerificationInfo</a> API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("RegistrantProfileId")]
            [Validation(Required=false)]
            public long? RegistrantProfileId { get; set; }

        }

        /// <summary>
        /// <para>Coupon number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("PromotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        /// <summary>
        /// <para>Is a coupon used? Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No.</description></item>
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
        /// <para>Whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Do not use.</description></item>
        /// <item><description><b>true</b>: Use.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UsePromotion")]
        [Validation(Required=false)]
        public bool? UsePromotion { get; set; }

        /// <summary>
        /// <para>User IP address, which can be set to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
