// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetWatermarkResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the watermark template.</para>
        /// </summary>
        [NameInMap("WatermarkInfo")]
        [Validation(Required=false)]
        public GetWatermarkResponseBodyWatermarkInfo WatermarkInfo { get; set; }
        public class GetWatermarkResponseBodyWatermarkInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the watermark template was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-11-06T08:03:17Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The URL of the watermark file. The URL is an Object Storage Service (OSS) URL or an Alibaba Cloud CDN URL.</para>
            /// <remarks>
            /// <para> This parameter is returned only for image watermark templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://outin-32*****f4b3e7.oss-cn-shanghai.aliyuncs.com/image/cover/F85529C8B715E6F8A72EC6B-6-2.png?Expires=1541600583&OSSAccessKeyId=****&Signature=gmf1eYMoDVg%2BHQCb4UGozBW">https://outin-32*****f4b3e7.oss-cn-shanghai.aliyuncs.com/image/cover/F85529C8B715E6F8A72EC6B-6-2.png?Expires=1541600583&amp;OSSAccessKeyId=****&amp;Signature=gmf1eYMoDVg%2BHQCb4UGozBW</a>****</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether the watermark template is the default one. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b></description></item>
            /// <item><description><b>NotDefault</b></description></item>
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
            /// <para>image watermark test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the watermark template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Image</b>: image watermark template</description></item>
            /// <item><description><b>Text</b>: text watermark template</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The configuration information of the watermark such as the display position and special effects. The value is a JSON string. The configuration parameters for image and text watermarks are different. For more information about the parameter structure, see <a href="~~98618#section-h01-44s-2lr~~">WatermarkConfig</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ReferPos&quot;: &quot;BottomRight&quot;,&quot;Height&quot;: &quot;55&quot;,&quot;Width&quot;: &quot;55&quot;,&quot;Dx&quot;: &quot;8&quot;,&quot;Dy&quot;: &quot;8&quot; }</para>
            /// </summary>
            [NameInMap("WatermarkConfig")]
            [Validation(Required=false)]
            public string WatermarkConfig { get; set; }

            /// <summary>
            /// <para>The ID of the watermark template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>505e2e287ea*****ecfddd386d384</para>
            /// </summary>
            [NameInMap("WatermarkId")]
            [Validation(Required=false)]
            public string WatermarkId { get; set; }

        }

    }

}
