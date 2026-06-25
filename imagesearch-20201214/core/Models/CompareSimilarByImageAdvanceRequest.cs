// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class CompareSimilarByImageAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the Image Search instance. The name can be up to 20 characters in length.
        /// If you have purchased an Image Search instance, log on to the &lt;props=&quot;intl&quot;&gt;<a href="https://imagesearch.console.alibabacloud.com">Image Search console</a>&lt;props=&quot;china&quot;&gt;<a href="https://imagesearch.console.aliyun.com">Image Search console</a> to view the instance name.
        /// If you have not purchased an Image Search instance, refer to <a href="https://help.aliyun.com/document_detail/179178.html">Activate the service</a> and <a href="https://help.aliyun.com/document_detail/66569.html">Create an instance</a>.</para>
        /// <remarks>
        /// <para>The instance name is not the instance ID. Make sure you distinguish between them.</para>
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
        /// <para>The image content.</para>
        /// <list type="bullet">
        /// <item><description>The image size must not exceed 4 MB.</description></item>
        /// <item><description>Image formats: PNG, JPG, JPEG, BMP, GIF, WEBP, TIFF, and PPM.</description></item>
        /// <item><description>The transmission wait time must not exceed 5 seconds.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>If the service type is product image search, generic image search, furniture image search, or industrial hardware image search, the image width and height must be at least 100 px and at most 4096 px.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If the service type is trademark image search, the image width and height must be at least 200 px and less than 4096 px.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If the service type is fabric image search, the image width and height must be at least 448 px and at most 4096 px.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>If the service type is product image search or generic image search, the image width and height must be at least 100 px and at most 4096 px.</para>
        /// </description></item>
        /// <item><description><para>The image must not contain rotation information.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><b>When calling by using an SDK:</b>- Only V3 SDKs are supported. You do not need to set the PrimaryPicContent field. The SDK encapsulates this field as PrimaryPicContentObject and automatically converts it to Base64 encoding. For examples, refer to <a href="https://help.aliyun.com/document_detail/179188.html">JAVA SDK</a>.- The SDK does not support passing image URLs directly. V3 SDKs provide an alternative way to upload images by URL. For examples, refer to <a href="https://help.aliyun.com/document_detail/179188.html">JAVA SDK</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAANSUhEUgAAAPcAAAEVCAYAAAA8d3NuAAAAAXNSR0IArs......RK5CYII=</para>
        /// </summary>
        [NameInMap("PrimaryPicContent")]
        [Validation(Required=false)]
        public Stream PrimaryPicContentObject { get; set; }

        /// <summary>
        /// <para>The image content.</para>
        /// <list type="bullet">
        /// <item><description>The image size must not exceed 4 MB.</description></item>
        /// <item><description>Image formats: PNG, JPG, JPEG, BMP, GIF, WEBP, TIFF, and PPM.</description></item>
        /// <item><description>The transmission wait time must not exceed 5 seconds.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description>If the service type is product image search, generic image search, furniture image search, or industrial hardware image search, the image width and height must be at least 100 px and at most 4096 px.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If the service type is trademark image search, the image width and height must be at least 200 px and less than 4096 px.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If the service type is fabric image search, the image width and height must be at least 448 px and at most 4096 px.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>If the service type is product image search or generic image search, the image width and height must be at least 100 px and at most 4096 px.</para>
        /// </description></item>
        /// <item><description><para>The image must not contain rotation information.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><b>When calling by using an SDK:</b>- Only V3 SDKs are supported. You do not need to set the PrimaryPicContent field. The SDK encapsulates this field as PrimaryPicContentObject and automatically converts it to Base64 encoding. For examples, refer to <a href="https://help.aliyun.com/document_detail/179188.html">JAVA SDK</a>.- The SDK does not support passing image URLs directly. V3 SDKs provide an alternative way to upload images by URL. For examples, refer to <a href="https://help.aliyun.com/document_detail/179188.html">JAVA SDK</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAANSUhEUgAAAPcAAAEVCAYAAAA8d3NuAAAAAXNSR0IArs......RK5CYII=</para>
        /// </summary>
        [NameInMap("SecondaryPicContent")]
        [Validation(Required=false)]
        public Stream SecondaryPicContentObject { get; set; }

    }

}
