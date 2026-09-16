// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id3MetaVerifyAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow cropping of the facial photo. By default, cropping is not allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: allows cropping.</description></item>
        /// <item><description>F: does not allow cropping.</description></item>
        /// </list>
        /// <para><b>Note</b></para>
        /// <para>If the requested image is not captured by a standard liveness detection SDK, allow cropping of the facial photo. After this feature is enabled, the requested image is first cropped and corrected for face alignment before the service request is initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The input stream of the ID card portrait photo. Specify either CertUrl or CertFile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("FaceFile")]
        [Validation(Required=false)]
        public Stream FaceFileObject { get; set; }

        /// <summary>
        /// <para>The Base64-encoded facial photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FacePicture")]
        [Validation(Required=false)]
        public string FacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the ID card portrait photo. The URL must be a publicly accessible HTTP or HTTPS link. Specify either CertUrl or CertFile.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/cert.jpeg">https://www.aliyun.com/cert.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceUrl")]
        [Validation(Required=false)]
        public string FaceUrl { get; set; }

        /// <summary>
        /// <para>The ID card number:</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal: enter the ID card number in plaintext.</description></item>
        /// <item><description>If paramType is set to md5: first 6 digits of the ID card number (plaintext) + date of birth (ciphertext) + last 4 digits of the ID card number (plaintext).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>● Plaintext: 429001****<b><b>8211
        /// ● Ciphertext:
        /// 42900132fa7bcd874161bea8ec8fd98f39</b></b>8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: plaintext without encryption.</description></item>
        /// <item><description>md5: MD5 encryption.</description></item>
        /// </list>
        /// <para><b>Important</b></para>
        /// <list type="bullet">
        /// <item><description>All encrypted parameter values use 32-character lowercase MD5 strings.</description></item>
        /// <item><description>Different MD5 tools may produce different ciphertext. If the API call succeeds with plaintext but fails after encryption, try a different MD5 tool.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The name:</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal: enter the name in plaintext.</description></item>
        /// <item><description>If paramType is set to md5: ciphertext of the first character of the name + plaintext of the remaining characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>● Plaintext: Zhang San
        /// ● Ciphertext:
        /// 6499fc7409049355527ef6a2ba5706b8San​</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
