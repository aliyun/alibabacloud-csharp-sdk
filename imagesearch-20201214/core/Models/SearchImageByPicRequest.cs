// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByPicRequest : TeaModel {
        /// <summary>
        /// <para>The product category. For more information, see <a href="https://help.aliyun.com/document_detail/179184.html">Category reference</a>.</para>
        /// <list type="bullet">
        /// <item><description>For product image search, if you specify a category, the specified category is used. If you do not specify a category, the system predicts the category. You can obtain the predicted category from the response.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>For fabric, trademark, generic furniture, and industrial hardware image search, the system sets the category to 88888888 regardless of whether you specify a category.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>For generic image search, the system sets the category to 88888888 regardless of whether you specify a category.
        /// .</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>88888888</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform subject identification. Default value: true.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is set to true, the system performs subject identification and searches based on the identified subject. You can obtain the subject identification result from the response.</description></item>
        /// <item><description>If this parameter is set to false, the system does not perform subject identification and searches based on the entire image.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>For fabric image search, this parameter is ignored and the system searches based on the entire image.
        /// .</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public bool? Crop { get; set; }

        /// <summary>
        /// <para>Specifies whether to deduplicate results based on the ProductId field during the search. If this parameter is set to true, deduplication is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DistinctProductId")]
        [Validation(Required=false)]
        public bool? DistinctProductId { get; set; }

        /// <summary>
        /// <para>The filter condition. The int_attr field supports the following operators: in, not in, greater than (&gt;), greater than or equal to (&gt;=), less than (&lt;), less than or equal to (&lt;=), and equal to (=). The str_attr field supports the following operators: in, not in, equal to (=), and not equal to (!=). Multiple conditions can be connected by using AND and OR.
        /// Examples:</para>
        /// <list type="bullet">
        /// <item><description>int_attr &gt;= 100.</description></item>
        /// <item><description>str_attr != &quot;value1&quot;.</description></item>
        /// <item><description>int_attr = 1000 AND str_attr = &quot;value1&quot;.</description></item>
        /// </list>
        /// <remarks>
        /// <para>A maximum of 4096 characters are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>int_attr=1000 AND str_attr=&quot;value1&quot;</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.
        /// If you have purchased an Image Search instance, log on to the <a href="https://imagesearch.console.aliyun.com/">Image Search console</a> to view the instance name.
        /// If you have not purchased an Image Search instance, see <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
        /// <remarks>
        /// <para>The instance name is not the instance ID. Make sure that you distinguish between them.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoinstance1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The number of results to return. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        /// <summary>
        /// <para>The image content.</para>
        /// <list type="bullet">
        /// <item><description>The image size cannot exceed 4 MB.</description></item>
        /// <item><description>Image formats: PNG, JPG, JPEG, BMP, GIF, WEBP, TIFF, and PPM.</description></item>
        /// <item><description>The transmission wait time cannot exceed 5 seconds.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>For product image search, generic image search, furniture image search, and industrial hardware image search, the image width and height must be greater than or equal to 100 px and less than or equal to 4096 px.
        /// For trademark image search, the image width and height must be greater than or equal to 200 px and less than 4096 px.
        /// For fabric image search, the image width and height must be greater than or equal to 448 px and less than or equal to 4096 px.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>For product image search and generic image search, the image width and height must be greater than or equal to 100 px and less than or equal to 4096 px.</para>
        /// </description></item>
        /// <item><description><para>The image cannot contain rotation information.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>Call by using the SDK:</b></description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use the V3 SDK, you do not need to specify the PicContent field. The SDK encapsulates this field as PicContentObject and automatically converts it to Base64 encoding. For specific examples, see <a href="https://help.aliyun.com/document_detail/179188.html">Java SDK</a>.</description></item>
        /// <item><description>The SDK does not support directly passing an image URL. The V3 SDK provides an alternative method to upload images by URL. For specific examples, see <a href="https://help.aliyun.com/document_detail/179188.html">Java SDK</a>.</description></item>
        /// <item><description><b>Call by using the Alibaba Cloud OpenAPI platform:</b><list type="bullet">
        /// <item><description>If you use the <b>2019-03-25</b> version, set the <b>PicContent</b> field to the <b>Base64</b>-encoded string of the image.</description></item>
        /// <item><description>If you use the <b>2020-12-14</b> version, click the upload button in the <b>PicContent</b> field to upload the image.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAANSUhEUgAAAPcAAAEVCAYAAAA8d3NuAAAAAXNSR0IArs......RK5CYII=</para>
        /// </summary>
        [NameInMap("PicContent")]
        [Validation(Required=false)]
        public string PicContent { get; set; }

        /// <summary>
        /// <para>The subject region of the image, in the format of <c>x1,x2,y1,y2</c>, where <c>x1,y1</c> is the upper-left point and <c>x2,y2</c> is the lower-right point.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify Region, the system searches based on the specified Region regardless of the value of the Crop parameter.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For fabric image search, this parameter is ignored and the system searches based on the entire image.
        /// .</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>280,486,232,351</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The similarity score threshold. After you specify this threshold, only images with a similarity score greater than or equal to the threshold are returned. Valid values: 0.00 to 1.00. Up to two decimal places are supported. Default value: 0.00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.50</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public string ScoreThreshold { get; set; }

        /// <summary>
        /// <para>The start position of the results to return. Valid values: 0 to 499. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}
