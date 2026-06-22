// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateDecodeBlindWatermarkTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A parameter from the earlier DecodeBlindWatermark API. It specifies the quality of the output image. The default value is 90. The value must be in the range of 70 to 100.</para>
        /// <para>A higher quality results in a larger image size and better watermark parsing quality.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ImageQuality")]
        [Validation(Required=false)]
        public int? ImageQuality { get; set; }

        /// <summary>
        /// <para>A parameter from the earlier DecodeBlindWatermark API. It specifies the watermark algorithm model. Valid values include FFT, FFT_FULL, DWT, and DWT_IBG. The default value is FFT.</para>
        /// <para>If this parameter is left empty, the new version of the blind watermarking feature is used. Otherwise, the earlier version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFT</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The notification configuration. For more information, click Notification. For the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>A parameter from the earlier DecodeBlindWatermark API. It specifies the OSS URI of the image before the blind watermark was added.</para>
        /// <para>This parameter is not required when Model is set to DWT or DWT_IBG.</para>
        /// <para>The OSS URI must be in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format. <c>&lt;bucket&gt;</c> is the name of the OSS bucket that is in the same region as the current project. <c>&lt;object&gt;</c> is the full path of the file, including the file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/testcases/watermarktestbefore.jpg</para>
        /// </summary>
        [NameInMap("OriginalImageURI")]
        [Validation(Required=false)]
        public string OriginalImageURI { get; set; }

        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <remarks>
        /// <para>Notice: The project name must be the same as the one used to add the blind watermark with the <a href="https://help.aliyun.com/document_detail/2743655.html">EncodeBlindWatermark</a> operation. Otherwise, the watermark cannot be extracted.</para>
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
        /// <para>The Object Storage Service (OSS) URI of the image.</para>
        /// <para>The OSS URI must be in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format. <c>&lt;bucket&gt;</c> is the name of the OSS bucket that is in the same region as the current project. <c>&lt;object&gt;</c> is the full path of the file, including the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://target/sampleobject.jpg</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The watermark extraction level, which controls the extraction precision. A higher level indicates a longer processing time and a better extraction effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>low</para>
        /// </description></item>
        /// <item><description><para>medium</para>
        /// </description></item>
        /// <item><description><para>high</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("StrengthLevel")]
        [Validation(Required=false)]
        public string StrengthLevel { get; set; }

        /// <summary>
        /// <para>A parameter from the earlier DecodeBlindWatermark API. It specifies the OSS URI where the image is saved after the blind watermark is parsed.</para>
        /// <para>The OSS URI must be in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format. <c>&lt;bucket&gt;</c> is the name of the OSS bucket that is in the same region as the current project. <c>&lt;object&gt;</c> is the full path of the file, including the file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://target/targetobject.jpg</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The type of the embedded watermark. Valid value: text</para>
        /// <para>(Image watermarks are not supported. Therefore, this parameter can only be set to text.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
