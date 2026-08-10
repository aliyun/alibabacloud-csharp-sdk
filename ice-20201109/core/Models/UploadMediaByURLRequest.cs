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
        /// <para>The entity ID. You can call the CreateEntity operation to create an entity and define a custom dynamic metadata structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d67281da3c8743b8823ad12976187***</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The metadata of the media file to be uploaded. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>The metadata takes effect only when it matches a URL in UploadURLs.</description></item>
        /// <item><description>JSON format: [UploadMetadata, UploadMetadata, ...]. The value must be converted to a JSON string.</description></item>
        /// <item><description>For more information, see the UploadMetadata table below.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SourceURL&quot;:&quot;<a href="https://example.aliyundoc.com/video01.mp4%22,%22Title%22:%22urlUploadTest%22%7D%5D">https://example.aliyundoc.com/video01.mp4&quot;,&quot;Title&quot;:&quot;urlUploadTest&quot;}]</a></para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <para>The post-upload processing action when Type is set to video or audio.</para>
        /// <para>Valid values of ProcessType: Workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProcessType&quot;: &quot;Workflow&quot;,&quot;ProcessID&quot;:&quot;b72a06c6beeb4dcdb898feef067b1***&quot;}</para>
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
        /// <para>{&quot;StorageType&quot;:&quot;oss&quot;,&quot;StorageLocation&quot;:&quot;outin-***.oss-cn-shanghai.aliyuncs.com&quot;}</para>
        /// </summary>
        [NameInMap("UploadTargetConfig")]
        [Validation(Required=false)]
        public string UploadTargetConfig { get; set; }

        /// <summary>
        /// <para>The URL of the media source file.</para>
        /// <list type="bullet">
        /// <item><description>The URL must include a file name extension. For example, mp4 is the file name extension in <c>https://****.mp4</c>.<list type="bullet">
        /// <item><description>If the URL does not include a file name extension, you can specify the FileExtension parameter in <c>UploadMetadatas</c>.</description></item>
        /// <item><description>If the URL includes a file name extension and the FileExtension parameter is also specified, the value of FileExtension takes precedence.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>URL-encode the URLs. Separate multiple URLs with commas (,). A maximum of 20 URLs are supported.</description></item>
        /// <item><description>To prevent upload failures caused by special characters, URL-encode each URL before concatenating them with commas.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://diffurl.mp4">https://diffurl.mp4</a></para>
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string that supports settings such as message callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22xxx%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
