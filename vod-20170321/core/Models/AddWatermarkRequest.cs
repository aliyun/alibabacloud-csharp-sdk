// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: <b>app-1000000</b>. If you have activated the multi-application service, specify the application ID to add the watermark template to the specified application. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multi-application service</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) URL of the watermark image file (without authentication).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Request parameter is required when you set an image watermark template (<c>Type</c> is <c>Image</c>).</description></item>
        /// <item><description>You can call <a href="~~CreateUploadAttachedMedia~~">CreateUploadAttachedMedia</a> to upload the watermark image to ApsaraVideo VOD. The value of the <c>FileURL</c> parameter returned after the upload can be used as the value of request parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://outin-326268*****63e1403e7.oss-cn-shanghai.aliyuncs.com/image/cover/C99345*****E7FDEC-6-2.png">http://outin-326268*****63e1403e7.oss-cn-shanghai.aliyuncs.com/image/cover/C99345*****E7FDEC-6-2.png</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The name of the watermark template.</para>
        /// <list type="bullet">
        /// <item><description>Only Chinese characters, letters, and digits are supported.</description></item>
        /// <item><description>The name can be up to 128 bytes in length.</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Image watermark template</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The templatetype of the watermark. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Image</b> (default): image watermark template.</description></item>
        /// <item><description><b>Text</b>: text watermark template.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Image</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The configuration information of the watermark (JSON string), including the display position and effect of the watermark. The configuration parameters differ between image watermarks and text watermarks. For more information about the parameter structure, see <a href="~~98618#section-h01-44s-2lr~~">WatermarkConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Width&quot;: &quot;55&quot;,
        ///       &quot;Height&quot;: &quot;55&quot;,
        ///       &quot;Dx&quot;: &quot;9&quot;,
        ///       &quot;Dy&quot;: &quot;9&quot;,
        ///       &quot;ReferPos&quot;: &quot;BottomLeft&quot;
        /// }</para>
        /// </summary>
        [NameInMap("WatermarkConfig")]
        [Validation(Required=false)]
        public string WatermarkConfig { get; set; }

    }

}
