// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceGuardRiskRequest : TeaModel {
        /// <summary>
        /// <para>The customer business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LMALL20******001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The device token obtained through the Face Guard SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tk9SSUQuMS*****************ZDNmNWY5NzQxOW1o</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, used for subsequent troubleshooting. It supports a combination of letters and digits and can be up to 32 characters in length. Ensure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c83ce0101d34eff886b1f7d1cdef67f</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The product code. Valid values: FACE_GUARD and FACE_GUARD_PRO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_GUARD_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the risk scenario detected by Device Assistant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Face</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
