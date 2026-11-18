// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddWatermarkResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The watermark template information.</para>
        /// </summary>
        [NameInMap("WatermarkInfo")]
        [Validation(Required=false)]
        public AddWatermarkResponseBodyWatermarkInfo WatermarkInfo { get; set; }
        public class AddWatermarkResponseBodyWatermarkInfo : TeaModel {
            /// <summary>
            /// <para>The time when the watermark template was created. The time follows the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-11-07T09:05:52Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The URL of the watermark file, which is an OSS URL or a CDN URL.</para>
            /// <remarks>
            /// <para>This parameter is returned only for image watermark templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://outin-3262*****9f4b3e7.oss-cn-shanghai.aliyuncs.com/image/cover/E6C3448CC8B715E6F8A72EC6B-6-2.png?Expires=1541600583&OSSAccessKeyId=****&Signature=gmf1eYMoDVg%2BHQCb4UGozBW">https://outin-3262*****9f4b3e7.oss-cn-shanghai.aliyuncs.com/image/cover/E6C3448CC8B715E6F8A72EC6B-6-2.png?Expires=1541600583&amp;OSSAccessKeyId=****&amp;Signature=gmf1eYMoDVg%2BHQCb4UGozBW</a>****</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>Specifies whether the watermark template is the default image or text watermark template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b>: default image or text watermark template.</description></item>
            /// <item><description><b>NotDefault</b>: non-default image or text watermark template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotDefault</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>The name of the watermark template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Image watermark template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the watermark template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Image</b>: image watermark template.</description></item>
            /// <item><description><b>Text</b>: text watermark template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The configuration information of the image or text watermark in JSON format, including the display position and effects of the watermark. The configuration parameters for image watermarks and text watermarks are different. For more information about the parameter structure, see <a href="~~98618#section-h01-44s-2lr~~">WatermarkConfig</a>.</para>
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

            /// <summary>
            /// <para>The watermark template ID. You can use this ID to associate the watermark template with a transcoding template group, or query, modify, or delete the watermark template, or set it as the default watermark template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9bcc8bfadb84*****109a2671d0df97</para>
            /// </summary>
            [NameInMap("WatermarkId")]
            [Validation(Required=false)]
            public string WatermarkId { get; set; }

        }

    }

}
