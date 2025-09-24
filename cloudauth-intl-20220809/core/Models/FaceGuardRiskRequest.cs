// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceGuardRiskRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the current business authentication. It is used with FACE_GUARD for verification during queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LMALL20******001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The deviceToken obtained from the client SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tk9SSUQuMS*****************ZDNmNWY5NzQxOW1o</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <para>A custom unique business identifier. It is used to locate and troubleshoot issues. The identifier can be a combination of letters and digits up to 32 characters long. Ensure that it is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c83ce0101d34eff886b1f7d1cdef67f</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The product code. Set this to the static field <b>FACE_GUARD</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_GUARD</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
