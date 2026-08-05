// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateUploadMediaRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Default value: app-1000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The entity ID. You can call the CreateEntity operation to create an entity and customize the dynamic metadata structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9e177cac2fb44f8b8c67b199fcc7bffd</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The file information in JSON format. This parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>Type (required): the file type. Valid values: video, image, audio, text, and other.</description></item>
        /// <item><description>Name (required): the file name without the file name extension.</description></item>
        /// <item><description>Size (optional): the file size.</description></item>
        /// <item><description>Ext (required): the file name extension.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Type\&quot;:\&quot;video\&quot;,\&quot;Name\&quot;:\&quot;test\&quot;,\&quot;Size\&quot;:108078336,\&quot;Ext\&quot;:\&quot;mp4\&quot;}</para>
        /// </summary>
        [NameInMap("FileInfo")]
        [Validation(Required=false)]
        public string FileInfo { get; set; }

        /// <summary>
        /// <para>The metadata of the media asset to upload, in JSON format.</para>
        /// <para>Title (required):</para>
        /// <list type="bullet">
        /// <item><description>The maximum length is 128 characters.</description></item>
        /// <item><description>UTF-8 encoded.</description></item>
        /// </list>
        /// <para>Description (optional):</para>
        /// <list type="bullet">
        /// <item><description>The maximum length is 1024 characters.</description></item>
        /// <item><description>UTF-8 encoded.</description></item>
        /// </list>
        /// <para>CateId (optional): the category ID.</para>
        /// <para>Tags (optional): the tags.</para>
        /// <para>BusinessType (required): the business type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When Type = video:
        /// opening: opening credits. ending: ending credits.</description></item>
        /// <item><description>When Type = image:
        /// default: default.
        /// cover: cover image.</description></item>
        /// <item><description>When Type = text:
        /// subtitles: subtitles.
        /// font: font.</description></item>
        /// <item><description>When Type = material:
        /// watermark: watermark.</description></item>
        /// <item><description>general: general-purpose.</description></item>
        /// </list>
        /// <para>CoverURL (optional): the cover URL.</para>
        /// <para>DynamicMetaData: the dynamic metadata. The value is a string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Title\&quot;: \&quot;UploadTest\&quot;, \&quot;Description\&quot;: \&quot;UploadImageTest\&quot;, \&quot;Tags\&quot;: \&quot;tag1,tag2\&quot;,\&quot;BusinessType\&quot;:\&quot;cover\&quot;}</para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <para>Specifies the post-upload processing action when Type = video or audio.</para>
        /// <para>ProcessType: set to Workflow.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter triggers an <a href="https://help.aliyun.com/document_detail/3027141.html">asynchronous task</a>. After submission, the task is not immediately completed and enters a background queue for asynchronous execution.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;ProcessType\&quot;:\&quot;Workflow\&quot;,\&quot;ProcessID\&quot;:\&quot;74ba870f1a4873a3ba238e0bf6fa9***\&quot;}</para>
        /// </summary>
        [NameInMap("PostProcessConfig")]
        [Validation(Required=false)]
        public string PostProcessConfig { get; set; }

        /// <summary>
        /// <para>The destination storage address.</para>
        /// <list type="bullet">
        /// <item><description>StorageType: only oss is supported.</description></item>
        /// <item><description>StorageLocation: only VOD storage is supported. User-owned OSS storage is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;StorageType\&quot;:\&quot;oss\&quot;,\&quot;StorageLocation\&quot;:\&quot;outin-***.oss-cn-shanghai.aliyuncs.com\&quot;}</para>
        /// </summary>
        [NameInMap("UploadTargetConfig")]
        [Validation(Required=false)]
        public string UploadTargetConfig { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string that supports settings such as message callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
