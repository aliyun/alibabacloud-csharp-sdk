// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByPicAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The category of the product. For more information, see <a href="https://help.aliyun.com/document_detail/179184.html">Category references</a>.</para>
        /// <list type="bullet">
        /// <item><description>For product search: If a category is specified, the specified category prevails. If no category is specified, the system estimates and selects a category. The category selected by the system is included in the response.</description></item>
        /// <item><description>For generic search: The parameter value is set to 88888888 regardless of whether a category is specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>88888888</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to recognize the subject in the image and search for images based on the recognized subject. Valid values: true and false. Default value: true.</para>
        /// <list type="bullet">
        /// <item><description>true: The system recognizes the subject in the image, and searches for images based on the recognized subject. The recognition result is included in the response.</description></item>
        /// <item><description>false: The system does not recognize the subject of the image, and searches for images based on the entire image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public bool? Crop { get; set; }

        [NameInMap("DistinctProductId")]
        [Validation(Required=false)]
        public bool? DistinctProductId { get; set; }

        /// <summary>
        /// <para>The filter conditions. int_attr supports the following operators: &gt;, &gt;=, &lt;, &lt;=, and =. str_attr supports the following operators: = and !=. You can set the logical operator between conditions to AND or OR.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>int_attr&gt;=100</description></item>
        /// <item><description>str_attr!=&quot;value1&quot;</description></item>
        /// <item><description>Example: int_attr=1000 AND str_attr=&quot;value1&quot;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>int_attr=1000 AND str_attr=&quot;value1&quot;</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoinstance1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The number of images to return on each page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        /// <summary>
        /// <para>The image file. The image file is encoded in Base64.</para>
        /// <list type="bullet">
        /// <item><description>The file size of the image cannot exceed 4 MB.</description></item>
        /// <item><description>The following image formats are supported: PNG, JPG, JPEG, BMP, GIF, WebP, TIFF, and PPM.</description></item>
        /// <item><description>The transmission timeout period cannot exceed 5 seconds.</description></item>
        /// <item><description>For brand image searches, the length and the width of the image must range from 200 pixels to 4,096 pixels.</description></item>
        /// <item><description>For cloth image searches, the length and the width of the image must range from 448 pixels to 4,096 pixels.</description></item>
        /// <item><description>For product and generic image searches, the length and the width of the image must range from 100 pixels to 4,096 pixels.</description></item>
        /// <item><description>The image cannot contain rotation settings.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAANSUhEUgAAAPcAAAEVCAYAAAA8d3NuAAAAAXNSR0IArs......RK5CYII=</para>
        /// </summary>
        [NameInMap("PicContent")]
        [Validation(Required=false)]
        public Stream PicContentObject { get; set; }

        /// <summary>
        /// <para>The subject area of the image. Specify the subject area in the following format: <c>x1,x2,y1,y2</c>. <c>x1 and y1</c> represent the upper-left corner pixel. <c>x2 and y2</c> represent the lower-right corner pixel.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set the Region parameter, the system searches for images based on the value of Region regardless of the value of the Crop parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>280,486,232,351</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The number of the image to return. Valid values: 0 to 499. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}
