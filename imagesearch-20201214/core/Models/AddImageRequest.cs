// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class AddImageRequest : TeaModel {
        /// <summary>
        /// <para>The category of the image. For more information, see <a href="https://help.aliyun.com/document_detail/179184.html">Category reference</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For product image search, if you specify a category for an image, the specified category prevails. If you do not specify a category for an image, the system predicts the category, and returns the prediction result in the response.</description></item>
        /// <item><description>For generic image search, only 88888888 may be returned for this parameter in the response regardless of whether a category is specified.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>88888888</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to identify the subject in the image and search for images based on the subject identification result. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The system identifies the subject in the image, and searches for images based on the subject identification result. The subject identification result is included in the response.</description></item>
        /// <item><description>false: The system does not identify the subject in the image, and searches for images based on the entire image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public bool? Crop { get; set; }

        /// <summary>
        /// <para>The user-defined content. The value can be up to 4,096 characters in length.</para>
        /// <remarks>
        /// <para>If you specify this parameter, the response includes this parameter and its value. You can add text such as an image description.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zidingyi</para>
        /// </summary>
        [NameInMap("CustomContent")]
        [Validation(Required=false)]
        public string CustomContent { get; set; }

        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length. If an Image Search instance is purchased, you can log on to the <a href="https://imagesearch.console.aliyun.com/">Image Search console</a> to view the instance. If no Image Search instance is purchased, you must purchase an instance. For more information, see <a href="https://help.aliyun.com/document_detail/179178.html">Activate Image Search</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
        /// <remarks>
        /// <para>The instance name is not the instance ID.</para>
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
        /// <para>The attribute, which is an integer. The attribute can be used to filter images when you search for images. If you specify this parameter, the response includes this parameter and its value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("IntAttr")]
        [Validation(Required=false)]
        public int? IntAttr { get; set; }

        /// <summary>
        /// <para>The attribute, which is an integer. The attribute can be used to filter images when you search for images. If you specify this parameter, the response includes this parameter and its value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("IntAttr2")]
        [Validation(Required=false)]
        public int? IntAttr2 { get; set; }

        [NameInMap("IntAttr3")]
        [Validation(Required=false)]
        public int? IntAttr3 { get; set; }

        [NameInMap("IntAttr4")]
        [Validation(Required=false)]
        public int? IntAttr4 { get; set; }

        /// <summary>
        /// <para>The image file. The image file is encoded in Base64.</para>
        /// <list type="bullet">
        /// <item><description>The file size of the image cannot exceed 4 MB.</description></item>
        /// <item><description>The following image formats are supported: PNG, JPG, JPEG, BMP, GIF, WebP, TIFF, and PPM.</description></item>
        /// <item><description>The transmission timeout period cannot exceed 5 seconds.</description></item>
        /// <item><description>For product and generic image searches, the length and width of the image must range from 100 pixels to 4,096 pixels.</description></item>
        /// <item><description>The image cannot contain rotation settings.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you use SDKs to call this operation, you do not need to specify <b>PicContent</b>. The SDKs encapsulate this parameter and automatically encode its value in Base64. For more information about how to use Image Search SDK for Java, see <a href="https://help.aliyun.com/document_detail/179188.html">Java SDK</a>.</description></item>
        /// <item><description>If you use OpenAPI Explorer to call this operation, you can select only the <b>2019-03-25</b> version. If you call this operation of other versions, the value of <b>PicContent</b> cannot be encoded in Base64.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAANSUhEUgAAAPcAAAEVCAYAAAA8d3NuAAAAAXNSR0IArs......RK5CYII=</para>
        /// </summary>
        [NameInMap("PicContent")]
        [Validation(Required=false)]
        public string PicContent { get; set; }

        /// <summary>
        /// <para>The name of the image. The name can be up to 512 characters in length.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>An image is uniquely identified by the values of ProductId and PicName.</description></item>
        /// <item><description>If you add an image whose product ID (ProductId) and image name (PicName) are the same as those of an existing image, the newly added image overwrites the existing image.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092061_1.jpg</para>
        /// </summary>
        [NameInMap("PicName")]
        [Validation(Required=false)]
        public string PicName { get; set; }

        /// <summary>
        /// <para>The ID of the product. The ID can be up to 512 characters in length.</para>
        /// <remarks>
        /// <para>A product may have multiple images.</para>
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
        /// <para>The subject area of the image, in the format of <c>x1,x2,y1,y2</c>. <c>x1 and y1</c> represent the position in the upper-left corner, in pixels. <c>x2 and y2</c> represent the position in the lower-right corner, in pixels.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify Region, the system searches for images based on the value of Region regardless of the value of Crop.</description></item>
        /// <item><description>The value of Region does not have a unit. The value is generated based on the length and width of the image. If the length and width of the image are scaled, the value of Region must be proportionally adjusted.</description></item>
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
        /// <para>The attribute, which is a string. The value can be up to 128 characters in length. The attribute can be used to filter images when you search for images. If you specify this parameter, the response includes this parameter and its value.</para>
        /// <remarks>
        /// <para>The value cannot contain the following special characters: \ ¥ $ &amp; %</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss</para>
        /// </summary>
        [NameInMap("StrAttr")]
        [Validation(Required=false)]
        public string StrAttr { get; set; }

        /// <summary>
        /// <para>The attribute, which is a string. The value can be up to 128 characters in length. The attribute can be used to filter images when you search for images. If you specify this parameter, the response includes this parameter and its value.</para>
        /// <remarks>
        /// <para>The value cannot contain the following special characters: \ ¥ $ &amp; %</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss</para>
        /// </summary>
        [NameInMap("StrAttr2")]
        [Validation(Required=false)]
        public string StrAttr2 { get; set; }

        [NameInMap("StrAttr3")]
        [Validation(Required=false)]
        public string StrAttr3 { get; set; }

        [NameInMap("StrAttr4")]
        [Validation(Required=false)]
        public string StrAttr4 { get; set; }

    }

}
