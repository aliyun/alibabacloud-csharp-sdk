// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteImageRequest : TeaModel {
        /// <summary>
        /// <para>The type of image deletion operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ImageURL</b>: deletes images based on image URLs.</description></item>
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
        /// <para>The image IDs. Separate multiple IDs with commas (,). A maximum of 20 IDs are supported. You can obtain image IDs by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Image</b> to view the IDs.</description></item>
        /// <item><description>Obtain the IDs from the response of the <a href="~~CreateUploadImage~~">CreateUploadImage</a> operation that is called to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the IDs from the response of the <a href="~~SearchMedia~~">SearchMedia</a> operation that is called to query images.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>DeleteImageType</b> is set to <b>ImageId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bbc65bba53fed90de118a7849****,594228cdd14b4d069fc17a8c4a****</para>
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// <para>The type of images associated with the video that you want to delete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CoverSnapshot</b>: thumbnail snapshot.</description></item>
        /// <item><description><b>NormalSnapshot</b>: regular snapshot.</description></item>
        /// <item><description><b>SpriteSnapshot</b>: sprite snapshot.</description></item>
        /// <item><description><b>SpriteOriginSnapshot</b>: sprite source image.</description></item>
        /// <item><description><b>All</b>: all of the preceding image types. If the value is not <c>All</c>, you can specify multiple image types. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>DeleteImageType</b> is set to <b>VideoId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The image URLs. The value is the <c>ImageURL</c> parameter returned by the <a href="~~CreateUploadImage~~">CreateUploadImage</a> operation. Separate multiple URLs with commas (,). A maximum of 20 URLs are supported.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>DeleteImageType</b> is set to <b>ImageURL</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.aliyundoc.com/image/default/41AE7ADABBE*****.png">https://example.aliyundoc.com/image/default/41AE7ADABBE*****.png</a></para>
        /// </summary>
        [NameInMap("ImageURLs")]
        [Validation(Required=false)]
        public string ImageURLs { get; set; }

        /// <summary>
        /// <para>The video ID. Only a single video ID is supported. You can obtain the video ID by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>Obtain the ID from the response of the <a href="~~CreateUploadVideo~~">CreateUploadVideo</a> operation that is called to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the ID from the response of the <a href="~~SearchMedia~~">SearchMedia</a> operation that is called to query videos.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>DeleteImageType</b> is set to <b>VideoId</b>.</para>
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
