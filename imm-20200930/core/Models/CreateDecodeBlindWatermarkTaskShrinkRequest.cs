// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateDecodeBlindWatermarkTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The quality of the output image. This parameter is also available in the earlier DecodeBlindWatermark operation.</para>
        /// <para>Higher image quality indicates a larger image size and higher watermark resolution quality.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ImageQuality")]
        [Validation(Required=false)]
        public int? ImageQuality { get; set; }

        /// <summary>
        /// <para>The watermark algorithm model. This parameter is also available in the earlier DecodeBlindWatermark operation. Valid values: FFT, FFT_FULL, DWT, and DWT_IBG. Default value: FFT.</para>
        /// <para>If this parameter is left empty, the CreateDecodeBlindWatermarkTask operation is called. Otherwise, the earlier DecodeBlindWatermark operation is called.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFT</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The OSS URI of the image before the blind watermark is added. This parameter is also available in the earlier DecodeBlindWatermark operation.</para>
        /// <para>Do not specify this parameter when you set the Model parameter to DWT or DWT_IBG.</para>
        /// <para>Specify the OSS URI in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format, where <c>&lt;bucket&gt;</c> is the name of the bucket in the same region as the current project and <c>&lt;object&gt;</c> is the path of the object with the extension included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/testcases/watermarktestbefore.jpg</para>
        /// </summary>
        [NameInMap("OriginalImageURI")]
        [Validation(Required=false)]
        public string OriginalImageURI { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <remarks>
        /// <para> The project specified in the request must match the one in the EncodeBlindWatermark request to encode the blind watermark.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The OSS URI of the image.</para>
        /// <para>Specify the OSS URI in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format, where <c>&lt;bucket&gt;</c> is the name of the bucket in the same region as the current project and <c>&lt;object&gt;</c> is the path of the object with the extension included.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://target/sampleobject.jpg</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The watermark strength level. The higher the strength level, the more resistant the watermarked image is to attacks, but the more the image is distorted. Valid values: low, medium, and high. Default value: low.</para>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("StrengthLevel")]
        [Validation(Required=false)]
        public string StrengthLevel { get; set; }

        /// <summary>
        /// <para>The OSS URI of the output image. This parameter is also available in the earlier DecodeBlindWatermark operation.</para>
        /// <para>Specify the OSS URI in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format, where <c>&lt;bucket&gt;</c> is the name of the bucket in the same region as the current project and <c>&lt;object&gt;</c> is the path of the object with the extension included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://target/targetobject.jpg</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The type of the watermark. Valid value: text.</para>
        /// <para>No image watermarks are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
