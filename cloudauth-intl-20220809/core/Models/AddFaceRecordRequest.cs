// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddFaceRecordRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgl****7uc</para>
        /// </summary>
        [NameInMap("FaceGroupCode")]
        [Validation(Required=false)]
        public string FaceGroupCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("FacePicture")]
        [Validation(Required=false)]
        public string FacePicture { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("FacePictureFile")]
        [Validation(Required=false)]
        public string FacePictureFile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.xxxxx.com/test.jpg">https://www.xxxxx.com/test.jpg</a></para>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>130A2C10B9EE4D8488E35384FF03hst</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_ENROLL</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
