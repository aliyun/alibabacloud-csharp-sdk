// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderTransferRequest : TeaModel {
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
        [NameInMap("OrderTransferParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderTransferRequestOrderTransferParam> OrderTransferParam { get; set; }
        public class SaveBatchTaskForCreatingOrderTransferRequestOrderTransferParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testCode</para>
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PermitPremiumTransfer")]
            [Validation(Required=false)]
            public bool? PermitPremiumTransfer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("RegistrantProfileId")]
            [Validation(Required=false)]
            public long? RegistrantProfileId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123123</para>
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
