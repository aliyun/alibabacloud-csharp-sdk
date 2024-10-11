// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteImageRequest : TeaModel {
        /// <summary>
        /// <para>The method that is used to delete images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ImageURL</b>: deletes images based on URLs.</description></item>
        /// <item><description><b>ImageId</b>: deletes images based on image IDs.</description></item>
        /// <item><description><b>VideoId</b>: deletes images associated with a video based on the video ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VideoId</para>
        /// </summary>
        [NameInMap("DeleteImageType")]
        [Validation(Required=false)]
        public string DeleteImageType { get; set; }

        /// <summary>
        /// <para>The ID of the image. You can specify up to 20 image IDs and separate them with commas (,). You can use one of the following methods to obtain the image ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Image</b> to view the image ID.</description></item>
        /// <item><description>Obtain the image ID from the response to the <a href="~~CreateUploadImage~~">CreateUploadImage</a> operation that you call to obtain the upload credential and URL.</description></item>
        /// <item><description>Obtain the image ID from the response to the <a href="~~SearchMedia~~">SearchMedia</a> operation that you call to query images.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect and is required only if you set <b>DeleteImageType</b> to <b>ImageId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bbc65bba53fed90de118a7849****,594228cdd14b4d069fc17a8c4a****</para>
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// <para>The type of images that you want to delete. The images are associated with the video. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CoverSnapshot</b>: thumbnail snapshot.</description></item>
        /// <item><description><b>NormalSnapshot</b>: regular snapshot.</description></item>
        /// <item><description><b>SpriteSnapshot</b>: sprite snapshot.</description></item>
        /// <item><description><b>SpriteOriginSnapshot</b>: sprite source snapshot.</description></item>
        /// <item><description><b>All</b>: images of all the preceding types. You can specify multiple types other than <c>All</c> for this parameter. Separate multiple types with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect and is required only if you set <b>DeleteImageType</b> to <b>VideoId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The URL of the image. You can obtain the value of <c>ImageURL</c> from the response to the <a href="~~CreateUploadImage~~">CreateUploadImage</a> operation. You can specify up to 20 URLs and separate them with commas (,).</para>
        /// <remarks>
        /// <para> This parameter takes effect and is required only if you set <b>DeleteImageType</b> to <b>ImageURL</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.aliyundoc.com/image/default/41AE7ADABBE*****.png">https://example.aliyundoc.com/image/default/41AE7ADABBE*****.png</a></para>
        /// </summary>
        [NameInMap("ImageURLs")]
        [Validation(Required=false)]
        public string ImageURLs { get; set; }

        /// <summary>
        /// <para>The ID of the video. You can specify only one ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the media file.</description></item>
        /// <item><description>Obtain the video ID from the response to the <a href="~~CreateUploadVideo~~">CreateUploadVideo</a> operation that you call to obtain the upload credential and URL.</description></item>
        /// <item><description>Obtain the video ID from the response to the <a href="~~SearchMedia~~">SearchMedia</a> operation that you call to query videos.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect and is required only if you set <b>DeleteImageType</b> to <b>VideoId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eb1861d2c9a8842340e989dd56****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
