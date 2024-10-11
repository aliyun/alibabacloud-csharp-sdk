// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. If you have activated the multi-application service, specify the ID of the application to add the watermark template in the specified application. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The URL of the watermark file. The URL must be an Object Storage Service (OSS) URL and cannot contain the information used for URL signing.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if you set <c>Type</c> to <c>Image</c>.</description></item>
        /// <item><description>You can obtain the URL from the <c>FileURL</c> parameter in the response to the <a href="~~CreateUploadAttachedMedia~~">CreateUploadAttachedMedia</a> operation that you call to upload the watermark image to ApsaraVideo VOD.</description></item>
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
        /// <item><description>Only letters and digits are supported.</description></item>
        /// <item><description>The name cannot exceed 128 bytes.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>watermark</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the watermark template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Image</b> (default): image watermark template</description></item>
        /// <item><description><b>Text</b>: text watermark template</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The configuration information of the watermark such as the display position and special effects. The value must be a JSON string. The configuration parameters for image and text watermarks are different. For more information about the parameter structure, see <a href="~~98618#section-h01-44s-2lr~~">WatermarkConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Width&quot;:&quot;55&quot;,&quot;Height&quot;:&quot;55&quot;,&quot;Dx&quot;:&quot;9&quot;,&quot;Dy&quot;:&quot;9&quot;,&quot;ReferPos&quot;:&quot;BottonLeft&quot;}</para>
        /// </summary>
        [NameInMap("WatermarkConfig")]
        [Validation(Required=false)]
        public string WatermarkConfig { get; set; }

    }

}
