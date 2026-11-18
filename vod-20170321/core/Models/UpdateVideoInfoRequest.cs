// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfoRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Asset Management Settings</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/56401.html">AddCategory</a> operation to create a category, the category ID is the value of the CateId response parameter.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/56406.html">GetCategories</a> operation to query categories, the category ID is the value of the CateId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>384761111</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The URL of the thumbnail for the audio or video file.</para>
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
        /// <item><description>The description must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud VOD video description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The custom ID. The ID must be 6 to 64 characters in length and can contain only lowercase letters, uppercase letters, digits, hyphens, and underscores. The ID must be unique per user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <list type="bullet">
        /// <item><description>A single tag can be up to 32 bytes in length. You can add up to 16 tags.</description></item>
        /// <item><description>Separate multiple tags with commas (,).</description></item>
        /// <item><description>Tags must be encoded in UTF-8.</description></item>
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
        /// <item><description>The title can be up to 128 bytes in length.</description></item>
        /// <item><description>The title must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud VOD Video Title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string that supports settings such as message callbacks and upload acceleration. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The audio or video file ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Assets</b> &gt; <b>Audio and Video</b> to view the audio or video file ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to obtain the upload URL and credential, the audio or video file ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After a video is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the audio or video file ID. The ID is the value of the VideoId response parameter.</description></item>
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
