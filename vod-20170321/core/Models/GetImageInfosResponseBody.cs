// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The image information.</para>
        /// </summary>
        [NameInMap("ImageInfo")]
        [Validation(Required=false)]
        public List<GetImageInfosResponseBodyImageInfo> ImageInfo { get; set; }
        public class GetImageInfosResponseBodyImageInfo : TeaModel {
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
            /// <para>The ID of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254766071</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The name of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// <para>The time when the image was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-11-21T02:37:23Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bbc65bba53f9*****ed90de118a7849</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The type of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: regular images</description></item>
            /// <item><description><b>cover</b>: video thumbnail</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NormalSnapshot</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The source information about the image.</para>
            /// </summary>
            [NameInMap("Mezzanine")]
            [Validation(Required=false)]
            public GetImageInfosResponseBodyImageInfoMezzanine Mezzanine { get; set; }
            public class GetImageInfosResponseBodyImageInfoMezzanine : TeaModel {
                /// <summary>
                /// <para>The size of the file to be uploaded. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8932</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// <para>The OSS URL of the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://outin-bfefbb*****163e1c7426.oss-cn-XXXXXXXX.aliyuncs.com/image/default/5E84CD536*****D4DAD.png?Expires=1590982353&OSSAccessKeyId=*****&Signature=ALPET74o*****c%3D">https://outin-bfefbb*****163e1c7426.oss-cn-XXXXXXXX.aliyuncs.com/image/default/5E84CD536*****D4DAD.png?Expires=1590982353&amp;OSSAccessKeyId=*****&amp;Signature=ALPET74o*****c%3D</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <para>The height of the image. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>The URL of the source file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>****.gif</para>
                /// </summary>
                [NameInMap("OriginalFileName")]
                [Validation(Required=false)]
                public string OriginalFileName { get; set; }

                /// <summary>
                /// <para>The width of the image. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>The status of the image file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Uploading</b>: The image is being uploaded. This is the initial status.</description></item>
            /// <item><description><b>Normal</b>: The image is uploaded.</description></item>
            /// <item><description><b>UploadFail</b>: The image fails to be uploaded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Uploading</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The bucket in which the image is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>outin-****..oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// <para>The tags of the image. Multiple tags are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1,tag2,tag3</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The title of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a sample</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The image URL. If a domain name for CDN is specified, a CDN URL is returned. Otherwise, an OSS URL is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.aliyundoc.com/image/default/****.gif?auth_key=">http://example.aliyundoc.com/image/default/****.gif?auth_key=</a>****</para>
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the images that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistImageIds")]
        [Validation(Required=false)]
        public List<string> NonExistImageIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
