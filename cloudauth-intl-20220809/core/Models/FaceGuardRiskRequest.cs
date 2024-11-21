// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceGuardRiskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>LMALL20******001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Tk9SSUQuMS*****************ZDNmNWY5NzQxOW1o</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0c83ce0101d34eff886b1f7d1cdef67f</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FACE_GUARD</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
