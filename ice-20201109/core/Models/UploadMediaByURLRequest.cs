// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UploadMediaByURLRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d67281da3c8743b8823ad12976187***</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;SourceURL&quot;:&quot;<a href="https://example.aliyundoc.com/video01.mp4%22,%22Title%22:%22urlUploadTest%22%7D%5D">https://example.aliyundoc.com/video01.mp4&quot;,&quot;Title&quot;:&quot;urlUploadTest&quot;}]</a></para>
        /// </summary>
        [NameInMap("MediaMetaData")]
        [Validation(Required=false)]
        public string MediaMetaData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;ProcessType&quot;: &quot;Workflow&quot;,&quot;ProcessID&quot;:&quot;b72a06c6beeb4dcdb898feef067b1***&quot;}</para>
        /// </summary>
        [NameInMap("PostProcessConfig")]
        [Validation(Required=false)]
        public string PostProcessConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;StorageType&quot;:&quot;oss&quot;,&quot;StorageLocation&quot;:&quot;outin-***.oss-cn-shanghai.aliyuncs.com&quot;}</para>
        /// </summary>
        [NameInMap("UploadTargetConfig")]
        [Validation(Required=false)]
        public string UploadTargetConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://diffurl.mp4">https://diffurl.mp4</a></para>
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22xxx%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
