// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UploadMediaByURLRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The entity ID. You can call the CreateEntity API to create an entity and define a custom dynamic metadata schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d67281da3c8743b8823ad12976187***</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The metadata of the media file, provided as a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para>This metadata takes effect only when it matches a URL in <c>UploadURLs</c>.</para>
        /// </description></item>
        /// <item><description><para>The value must be a JSON array in the <c>[UploadMetadata, UploadMetadata, ...]</c> format, passed as a JSON string.</para>
        /// </description></item>
        /// <item><description><para>For more information, see the UploadMetadata table below.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SourceURL&quot;:&quot;<a href="https://example.aliyundoc.com/video01.mp4%22,%22Title%22:%22urlUploadTest%22%7D%5D">https://example.aliyundoc.com/video01.mp4&quot;,&quot;Title&quot;:&quot;urlUploadTest&quot;}]</a></para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <para>Specifies post-upload processing actions for media files of type <c>video</c> or <c>audio</c>.</para>
        /// <para>The only supported value for <c>ProcessType</c> is <c>Workflow</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProcessType&quot;: &quot;Workflow&quot;,&quot;ProcessID&quot;:&quot;b72a06c6beeb4dcdb898feef067b1***&quot;}</para>
        /// </summary>
        [NameInMap("PostProcessConfig")]
        [Validation(Required=false)]
        public string PostProcessConfig { get; set; }

        /// <summary>
        /// <para>The destination storage location.</para>
        /// <list type="bullet">
        /// <item><description><para>The only valid value for <c>StorageType</c> is <c>oss</c>.</para>
        /// </description></item>
        /// <item><description><para><c>StorageLocation</c> supports VOD storage only and does not support your own OSS buckets.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;StorageType&quot;:&quot;oss&quot;,&quot;StorageLocation&quot;:&quot;outin-***.oss-cn-shanghai.aliyuncs.com&quot;}</para>
        /// </summary>
        [NameInMap("UploadTargetConfig")]
        [Validation(Required=false)]
        public string UploadTargetConfig { get; set; }

        /// <summary>
        /// <para>The source URL of the media file.</para>
        /// <list type="bullet">
        /// <item><description><para>The URL must include a file extension. For example, in <c>https://****.mp4</c>, mp4 is the file extension.</para>
        /// <list type="bullet">
        /// <item><description><para>If the URL does not include a file extension, you can specify it by using the <c>FileExtension</c> parameter in <c>MediaMetaData</c>.</para>
        /// </description></item>
        /// <item><description><para>If a file extension is present in both the URL and the <c>FileExtension</c> parameter, the value of <c>FileExtension</c> takes precedence.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The URLs must be URL-encoded. Separate multiple URLs with commas (,). You can specify up to 20 URLs.</para>
        /// </description></item>
        /// <item><description><para>To prevent upload failures due to special characters, URL-encode each URL before concatenating them with commas.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://diffurl.mp4">https://diffurl.mp4</a></para>
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

        /// <summary>
        /// <para>Custom settings, provided as a JSON string. This parameter supports configurations such as message callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22xxx%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
