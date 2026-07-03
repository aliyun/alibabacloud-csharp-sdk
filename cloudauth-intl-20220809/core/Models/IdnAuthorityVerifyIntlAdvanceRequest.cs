// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class IdnAuthorityVerifyIntlAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The date of birth.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-01</para>
        /// </summary>
        [NameInMap("BirthDate")]
        [Validation(Required=false)]
        public string BirthDate { get; set; }

        /// <summary>
        /// <para>The email address of the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a*@gmail.com</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The full name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray</para>
        /// </summary>
        [NameInMap("FullName")]
        [Validation(Required=false)]
        public string FullName { get; set; }

        /// <summary>
        /// <para>The ID card number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3612841***47001</para>
        /// </summary>
        [NameInMap("IdNumber")]
        [Validation(Required=false)]
        public string IdNumber { get; set; }

        /// <summary>
        /// <para>The merchant-side custom business unique identifier, which is used for subsequent troubleshooting. The value can be a combination of letters and digits with a maximum length of 32 characters. Ensure that the value is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dso932dsjsd22</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID, or another identifier that can identify a specific user, such as a phone number or email address. We strongly recommend that you desensitize the value of this field in advance, for example, by hashing the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The Indonesian mobile phone number. The number must start with +62, followed by 9 to 11 digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+6281293671234</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The product solution to use. Set the value to IDN_META.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDN_META</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The custom authentication scenario ID. You can use this scenario ID to query related records in the console. The value can be a combination of letters, digits, or underscores with a maximum length of 10 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The Base64-encoded facial photo.</para>
        /// <remarks>
        /// <para><b>Note</b></para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the ID photo, check the photo size and do not pass an excessively large photo.</description></item>
        /// <item><description>Specify one of the following parameters: SourceFacePicture, SourceFacePictureUrl, or SourceFacePictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceFacePicture")]
        [Validation(Required=false)]
        public string SourceFacePicture { get; set; }

        /// <summary>
        /// <para>The file stream of the facial photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("SourceFacePictureFile")]
        [Validation(Required=false)]
        public Stream SourceFacePictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the facial photo. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face1.jpeg</para>
        /// </summary>
        [NameInMap("SourceFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceFacePictureUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
