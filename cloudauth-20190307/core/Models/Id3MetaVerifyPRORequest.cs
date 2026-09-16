// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id3MetaVerifyPRORequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow cropping of the facial photo. By default, cropping is not allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b>: Cropping is allowed.</description></item>
        /// <item><description><b>F</b>: Cropping is not allowed.<remarks>
        /// <para>If the requested image is not captured by a standard liveness detection SDK, allow cropping of the facial photo.
        /// After this feature is enabled, the requested image is first cropped and corrected for the face, and then the request is sent to the service.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow fallback to a non-public security source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>N</b> (default): Disabled.</description></item>
        /// <item><description><b>Y</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("EnableFallback")]
        [Validation(Required=false)]
        public string EnableFallback { get; set; }

        /// <summary>
        /// <para>The input stream of the facial photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For the specific integration method, refer to the file upload Advance API configuration</para>
        /// </summary>
        [NameInMap("FaceFile")]
        [Validation(Required=false)]
        public string FaceFile { get; set; }

        /// <summary>
        /// <para>The Base64-encoded photo. If you use this method to submit the facial photo, check the photo size and do not submit an excessively large photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FacePicture")]
        [Validation(Required=false)]
        public string FacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the facial photo. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceUrl")]
        [Validation(Required=false)]
        public string FaceUrl { get; set; }

        /// <summary>
        /// <para>The ID card number.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>paramType</b> is set to normal: Enter the ID card number in plaintext.</para>
        /// </description></item>
        /// <item><description><para>If <b>paramType</b> is set to sm2: Enter the encrypted ID card number.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Due to authoritative source limitations, only second-generation resident ID card numbers are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Plaintext: 429001********8211</para>
        /// <para>Ciphertext: MHsCIEPDt1ycBNSVgA2yKsMnvWGheiI+STWqJLmYWlZnklhnAiEAwq1bk5YVepHwqfMsd9ErlK71OrdXx8E+wfqbzyFCwoMEIM1QdrFeekvQh6fwK7sVXAsNePiNm7Eulqm/zahRosbKBBKgtyhm3SopJ3tO/wALKXQQW+g=</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable liveness detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>N</b> (default): Liveness detection is disabled.</description></item>
        /// <item><description><b>Y</b>: Liveness detection is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("LivenessCheck")]
        [Validation(Required=false)]
        public string LivenessCheck { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal</b>: Plaintext without encryption.</para>
        /// </description></item>
        /// <item><description><para><b>sm2</b>: SM2 encryption.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>paramType</b> is set to normal: Enter the name in plaintext.</para>
        /// </description></item>
        /// <item><description><para>If <b>paramType</b> is set to sm2: Enter the encrypted name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Plaintext: Zhang San</para>
        /// <para>Ciphertext: MG8CIQCxI0wNYbc0c2BRL+7+tSethTXfQC391ZFnszRRcvRZ9AIgekQYhgDtxaDuoRD4bde/5fnFdlUp4YoxlEnIFLLm2mQEILkctuy6Rw6lfAUxBtkpPoPVCJAeD5al/RX8JFUvTACEBAYAgLJjBe0=</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
