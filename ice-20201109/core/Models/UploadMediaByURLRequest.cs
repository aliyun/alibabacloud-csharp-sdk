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
        /// <para>The entity ID. You can call the CreateEntity operation to create an entity and specify a dynamic metadata structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d67281da3c8743b8823ad12976187***</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The metadata of the media file that you want to upload. The value must be a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if its value matches a URL that is specified in UploadURLs.</description></item>
        /// <item><description>You must convert the JSON-formatted data, such as [UploadMetadata, UploadMetadata,…], into a JSON string.</description></item>
        /// <item><description>For more information, see the &quot;UploadMetadata&quot; section of this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SourceURL&quot;:&quot;<a href="https://example.aliyundoc.com/video01.mp4%22,%22Title%22:%22urlUploadTest%22%7D%5D">https://example.aliyundoc.com/video01.mp4&quot;,&quot;Title&quot;:&quot;urlUploadTest&quot;}]</a></para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <para>The postprocessing configurations. You can specify this parameter if Type is set to video or audio.</para>
        /// <para>Set ProcessType to Workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProcessType&quot;: &quot;Workflow&quot;,&quot;ProcessID&quot;:&quot;b72a06c6beeb4dcdb898feef067b1***&quot;}</para>
        /// </summary>
        [NameInMap("PostProcessConfig")]
        [Validation(Required=false)]
        public string PostProcessConfig { get; set; }

        /// <summary>
        /// <para>The destination storage address.</para>
        /// <para>Set StorageType to oss.</para>
        /// <para>Set StorageLocation to an address in ApsaraVideo VOD. You cannot set this field to an OSS URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;StorageType&quot;:&quot;oss&quot;,&quot;StorageLocation&quot;:&quot;outin-***.oss-cn-shanghai.aliyuncs.com&quot;}</para>
        /// </summary>
        [NameInMap("UploadTargetConfig")]
        [Validation(Required=false)]
        public string UploadTargetConfig { get; set; }

        /// <summary>
        /// <para>The URL of the source file.</para>
        /// <list type="bullet">
        /// <item><description><para>The URL must contain a file name extension, such as mp4 in <c>https://****.mp4</c>.</para>
        /// <list type="bullet">
        /// <item><description>If the URL does not contain a file name extension, you can specify one by setting <c>FileExtension</c> in <c>UploadMetadata</c>.</description></item>
        /// <item><description>If the URL contains a file name extension and <c>FileExtension</c> is also specified, the value of <c>FileExtension</c> prevails.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>URL encoding is required. Separate multiple URLs with commas (,). You can specify a maximum of 20 URLs.</para>
        /// </description></item>
        /// <item><description><para>Special characters may cause upload failures. Therefore, you must encode URLs before you separate them with commas (,).</para>
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
        /// <para>The user data. The value must be a JSON string. You can configure settings such as message callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22xxx%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
