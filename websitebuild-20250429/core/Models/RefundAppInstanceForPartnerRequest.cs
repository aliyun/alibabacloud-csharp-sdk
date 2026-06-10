// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class RefundAppInstanceForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>Website building business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Idempotent token</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6f7e8b9-a0b1-4c2d-9e0f-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Refund reason</para>
        /// 
        /// <b>Example:</b>
        /// <para>渠道商退款</para>
        /// </summary>
        [NameInMap("RefundReason")]
        [Validation(Required=false)]
        public string RefundReason { get; set; }

        /// <summary>
        /// <para>User ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
