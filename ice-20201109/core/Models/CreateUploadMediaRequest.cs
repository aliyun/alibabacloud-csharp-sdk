// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateUploadMediaRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. The default value is <c>app-1000000</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the entity. You can call the <c>CreateEntity</c> operation to create an entity and define a custom schema for dynamic metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9e177cac2fb44f8b8c67b199fcc7bffd</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The file information, provided as a JSON string containing the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Type</c> (Required): The file type. Valid values: <c>video</c>, <c>image</c>, <c>audio</c>, <c>text</c>, and <c>other</c>.</para>
        /// </description></item>
        /// <item><description><para><c>Name</c> (Required): The filename without the extension.</para>
        /// </description></item>
        /// <item><description><para><c>Size</c> (Optional): The file size.</para>
        /// </description></item>
        /// <item><description><para><c>Ext</c> (Required): The file extension.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Type\&quot;:\&quot;video\&quot;,\&quot;Name\&quot;:\&quot;test\&quot;,\&quot;Size\&quot;:108078336,\&quot;Ext\&quot;:\&quot;mp4\&quot;}</para>
        /// </summary>
        [NameInMap("FileInfo")]
        [Validation(Required=false)]
        public string FileInfo { get; set; }

        /// <summary>
        /// <para>The media asset metadata, provided as a JSON string.</para>
        /// <para><c>Title</c> (Required):</para>
        /// <list type="bullet">
        /// <item><description><para>The title can be up to 128 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The title must be UTF-8 encoded.</para>
        /// </description></item>
        /// </list>
        /// <para><c>Description</c> (Optional):</para>
        /// <list type="bullet">
        /// <item><description><para>The description can be up to 1,024 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The description must be UTF-8 encoded.</para>
        /// </description></item>
        /// </list>
        /// <para><c>CateId</c> (Optional): The category ID.</para>
        /// <para><c>Tags</c> (Optional): The tags of the media asset, separated by commas.</para>
        /// <para><c>BusinessType</c> (Required): The business type. Valid values depend on the <c>Type</c> specified in <c>FileInfo</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>Type</c> is <c>video</c>: <c>opening</c> or <c>ending</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>Type</c> is <c>image</c>: <c>default</c>, <c>cover</c>, or <c>watermark</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>Type</c> is <c>text</c>: <c>subtitles</c> or <c>font</c>.</para>
        /// </description></item>
        /// <item><description></description></item>
        /// <item><description><para>If <c>Type</c> is <c>other</c>: <c>general</c>.</para>
        /// </description></item>
        /// </list>
        /// <para><c>CoverURL</c> (Optional): The URL of the cover image.<br><c>DynamicMetaData</c> (Optional): A string for custom dynamic metadata.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Title\&quot;: \&quot;UploadTest\&quot;, \&quot;Description\&quot;: \&quot;UploadImageTest\&quot;, \&quot;Tags\&quot;: \&quot;tag1,tag2\&quot;,\&quot;BusinessType\&quot;:\&quot;cover\&quot;}</para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <para>The post-processing configuration for <c>video</c> or <c>audio</c> uploads.</para>
        /// <para>Set <c>ProcessType</c> to <c>Workflow</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter specifies an <a href="https://help.aliyun.com/document_detail/3027141.html">asynchronous task</a>, which is queued and runs in the background after you submit the request.</description></item>
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
        /// <para>The destination storage configuration, provided as a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para><c>StorageType</c>: Only <c>oss</c> is supported.</para>
        /// </description></item>
        /// <item><description><para><c>StorageLocation</c>: Only VOD storage is supported. You cannot upload to your own OSS buckets.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;StorageType\&quot;:\&quot;oss\&quot;,\&quot;StorageLocation\&quot;:\&quot;outin-***.oss-cn-shanghai.aliyuncs.com\&quot;}</para>
        /// </summary>
        [NameInMap("UploadTargetConfig")]
        [Validation(Required=false)]
        public string UploadTargetConfig { get; set; }

        /// <summary>
        /// <para>A JSON string for custom settings, such as configuring a message callback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
