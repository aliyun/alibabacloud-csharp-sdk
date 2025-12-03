// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfoRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b> to view the category ID of the media file.</description></item>
        /// <item><description>View the value of the CateId parameter returned by the <a href="https://help.aliyun.com/document_detail/56401.html">AddCategory</a> operation that you called to create a category.</description></item>
        /// <item><description>View the value of the CateId parameter returned by the <a href="https://help.aliyun.com/document_detail/56406.html">GetCategories</a> operation that you called to query a category.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>384761111</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The URL of the audio/video thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.aliyundoc.com/****.jpg">https://example.aliyundoc.com/****.jpg</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the audio or video file.</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 1,024 bytes in length.</description></item>
        /// <item><description>The value is encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The tags of the media file.</para>
        /// <list type="bullet">
        /// <item><description>Each tag can be up to 32 bytes in length. You can specify up to 16 tags.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>The value is encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag1,tag2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The title of the audio or video file.</para>
        /// <list type="bullet">
        /// <item><description>The name cannot exceed 128 bytes.</description></item>
        /// <item><description>The value is encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Custom settings. This is a JSON string that supports message callbacks, upload acceleration, and other settings. For more information, please refer to <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the audio or video file. Perform the following operations to obtain the storage address:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you called to obtain the upload URL and credential.</description></item>
        /// <item><description>View the value of the VideoId parameter returned by the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation that you called to query media information after the audio or video file is uploaded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2deda93265312baf9b0ed810d****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
