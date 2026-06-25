// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class AddImageRequest : TeaModel {
        /// <summary>
        /// <para>The image category. For more information, refer to <a href="https://help.aliyun.com/document_detail/179184.html">Category reference</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For product image search, if you specify a category, the specified category is used. If you do not specify a category, the system predicts the category. The predicted category result can be obtained from the response.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>For fabric, trademark, generic, furniture, and industrial hardware image search, the system sets the category to 88888888 regardless of whether you specify a category.</para>
        /// </description></item>
        /// <item><description><para>For generic image search, the system sets the category to 88888888 regardless of whether you specify a category.</para>
        /// </description></item>
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
        /// <item><description>true: The system performs subject identification and searches based on the identified subject. The subject identification result can be obtained from the response.</description></item>
        /// <item><description>false: The system does not perform subject identification and searches based on the entire image.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;For fabric image search, this parameter is ignored. The system searches based on the entire image..</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public bool? Crop { get; set; }

        /// <summary>
        /// <para>The custom content defined by the user. The content can be up to 4,096 characters in length.</para>
        /// <remarks>
        /// <para>This field is returned in query results. For example, you can add a text description of the image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zidingyi</para>
        /// </summary>
        [NameInMap("CustomContent")]
        [Validation(Required=false)]
        public string CustomContent { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.
        /// If you have purchased an Image Search instance, log on to the <a href="https://imagesearch.console.aliyun.com/">Image Search console</a> to view the instance name.
        /// If you have not purchased an Image Search instance, refer to <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
        /// <remarks>
        /// <para>The instance name is not the instance ID. Do not confuse the two.</para>
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
        /// <para>The integer attribute. This attribute can be used to filter query results and is returned in query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("IntAttr")]
        [Validation(Required=false)]
        public int? IntAttr { get; set; }

        /// <summary>
        /// <para>The integer attribute. This attribute can be used to filter query results and is returned in query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("IntAttr2")]
        [Validation(Required=false)]
        public int? IntAttr2 { get; set; }

        /// <summary>
        /// <para>The integer attribute. This attribute can be used to filter query results and is returned in query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("IntAttr3")]
        [Validation(Required=false)]
        public int? IntAttr3 { get; set; }

        /// <summary>
        /// <para>The integer attribute. This attribute can be used to filter query results and is returned in query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("IntAttr4")]
        [Validation(Required=false)]
        public int? IntAttr4 { get; set; }

        /// <summary>
        /// <para>The image content.</para>
        /// <list type="bullet">
        /// <item><description>The image size cannot exceed 4 MB.</description></item>
        /// <item><description>Image formats: PNG, JPG, JPEG, BMP, GIF, WEBP, TIFF, and PPM.</description></item>
        /// <item><description>The transmission wait time cannot exceed 5 seconds.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>For product image search, generic image search, furniture image search, and industrial hardware image search, the image width and height must be at least 100 pixels and at most 4,096 pixels.
        ///   For trademark image search, the image width and height must be at least 200 pixels and less than 4,096 pixels.
        ///  For fabric image search, the image width and height must be at least 448 pixels and at most 4,096 pixels.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>For product image search and generic image search, the image width and height must be at least 100 pixels and at most 4,096 pixels.</para>
        /// </description></item>
        /// <item><description><para>The image must not contain rotation information.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>When calling by using an SDK:</b></description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use a V3 SDK, you do not need to set the PicContent field. The SDK encapsulates this field as PicContentObject and automatically converts it to Base64 encoding. For specific examples, refer to <a href="https://help.aliyun.com/document_detail/179188.html">Java SDK</a>.</description></item>
        /// <item><description>The SDK does not support passing image URLs directly. The V3 SDK provides an alternative method to upload images by URL. For specific examples, refer to <a href="https://help.aliyun.com/document_detail/179188.html">Java SDK</a>.</description></item>
        /// <item><description><b>When calling by using the Alibaba Cloud OpenAPI platform:</b><list type="bullet">
        /// <item><description>If you use the <b>2019-03-25</b> version, set the <b>PicContent</b> field to the <b>Base64</b> encoding of the image.</description></item>
        /// <item><description>If you use the <b>2020-12-14</b> version, click to upload the image directly in the <b>PicContent</b> field.</description></item>
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
        /// <para>The image name. The name can be up to 256 characters in length.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ProductId and PicName uniquely identify an image.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you add multiple images with the same ProductId and PicName, only the last added image is retained. Previously added images are overwritten.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1.jpg</para>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>The product ID. The ID can be up to 256 characters in length.</para>
        /// <remarks>
        /// <para>A product can have multiple images.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The subject region of the image, in the format of <c>x1,x2,y1,y2</c>, where <c>x1,y1</c> is the upper-left point and <c>x2,y2</c> is the lower-right point.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify Region, the system searches based on the specified Region regardless of the Crop parameter value.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>For fabric image search, this parameter is ignored. The system searches based on the entire image.</para>
        /// </description></item>
        /// <item><description><para>The Region parameter has no unit. The values are based on the pixel dimensions of the image. If the image is scaled, the Region parameter values must be scaled proportionally.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>280,486,232,351</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The string attribute. The attribute can be up to 128 characters in length. This attribute can be used to filter query results and is returned in query results.</para>
        /// <remarks>
        /// <para>Special characters such as \¥$&amp;% are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss</para>
        /// </summary>
        [NameInMap("StrAttr")]
        [Validation(Required=false)]
        public string StrAttr { get; set; }

        /// <summary>
        /// <para>The string attribute. The attribute can be up to 128 characters in length. This attribute can be used to filter query results and is returned in query results.</para>
        /// <remarks>
        /// <para>Special characters such as \¥$&amp;% are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss</para>
        /// </summary>
        [NameInMap("StrAttr2")]
        [Validation(Required=false)]
        public string StrAttr2 { get; set; }

        /// <summary>
        /// <para>The string attribute. The attribute can be up to 128 characters in length. This attribute can be used to filter query results and is returned in query results.</para>
        /// <remarks>
        /// <para>Special characters such as \¥$&amp;% are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss</para>
        /// </summary>
        [NameInMap("StrAttr3")]
        [Validation(Required=false)]
        public string StrAttr3 { get; set; }

        /// <summary>
        /// <para>The string attribute. The attribute can be up to 128 characters in length. This attribute can be used to filter query results and is returned in query results.</para>
        /// <remarks>
        /// <para>Special characters such as \¥$&amp;% are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss</para>
        /// </summary>
        [NameInMap("StrAttr4")]
        [Validation(Required=false)]
        public string StrAttr4 { get; set; }

    }

}
