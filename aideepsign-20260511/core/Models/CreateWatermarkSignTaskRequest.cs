// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateWatermarkSignTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow overwriting when the target object already exists. Default value: false. If the target object exists, the creation is rejected. If you set this parameter to true, existing objects can be overwritten, which supports in-place signing. The target object key can be the same as the source object key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowOverwrite")]
        [Validation(Required=false)]
        public bool? AllowOverwrite { get; set; }

        /// <summary>
        /// <para>The idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The optional custom C2PA assertions. It is a JSON array string. You can specify up to 64 assertions, and each assertion cannot exceed 4,096 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;label&quot;:&quot;com.xxx.internal&quot;,&quot;data&quot;:{&quot;meta_id&quot;:&quot;emp001&quot;,&quot;generation&quot;:{&quot;modelVersion&quot;:&quot;2.1&quot;,&quot;count&quot;:3},&quot;tags&quot;:[&quot;AI-generated&quot;,&quot;E-commerce&quot;],&quot;enabled&quot;:true,&quot;optional&quot;:null}}]</para>
        /// </summary>
        [NameInMap("CustomAssertions")]
        [Validation(Required=false)]
        public string CustomAssertions { get; set; }

        /// <summary>
        /// <para>The file type. Valid values: image, video, and audio. For audio files, the watermark is always processed through the EAS link, the capacity is always 32 bits (auto_len is invalid), and the file extension of the signed output is always .wav.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The URL of the file to be processed. You must specify either this parameter or ObjectKey. Images, videos, and audio files are supported. Only HTTP and HTTPS protocols are supported. The source file extension is verified based on the intersection of C2PA signing capabilities and watermark level capabilities. For images, only .jpg, .jpeg, and .png are supported. For videos, only .mp4 is supported, and the video must be within 10 minutes and 100 MB in size. For audio files, only .flac, .m4a, .mp3, and .wav are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/images/photo.png?token=xxx">https://example.com/images/photo.png?token=xxx</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The watermark embedding strength. Valid values: 0 to 3. Default value: 2. A higher strength indicates better robustness but lower visual quality.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;2&quot;</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The reserved parameter. It is used to pass extended parameters such as subkeys. Example: subkey:xxx. A subkey is used to isolate different customers under the same primary key and cannot contain commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Reserved")]
        [Validation(Required=false)]
        public string Reserved { get; set; }

        /// <summary>
        /// <para>The optional name of the software that generated the content. It is used for C2PA tracing. The current version does not support writing to the DigiCert manifest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Adobe Photoshop 25.0</para>
        /// </summary>
        [NameInMap("SoftwareAgent")]
        [Validation(Required=false)]
        public string SoftwareAgent { get; set; }

        /// <summary>
        /// <para>The optional content source type. It is used for C2PA tracing. The current version does not support writing to the DigiCert manifest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>digitalCapture</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The optional name of the user\&quot;s Object Storage Service (OSS) bucket to which the signing result is written. If this parameter is empty, the result is written to an internal bucket of the service and returned through SignedFileUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("TargetBucketName")]
        [Validation(Required=false)]
        public string TargetBucketName { get; set; }

        /// <summary>
        /// <para>The region ID of the user\&quot;s OSS bucket. This parameter is required when TargetBucketName is not empty. Example: cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TargetBucketRegion")]
        [Validation(Required=false)]
        public string TargetBucketRegion { get; set; }

        /// <summary>
        /// <para>The optional full object key of the signed output written to the user\&quot;s bucket. This parameter must be provided together with TargetBucketName. It must start with ai-deepsign-signed/ and be a full object name with an extension, not a directory prefix. The server does not append the _signed suffix or a trailing slash.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-deepsign-signed/2026/photo.png</para>
        /// </summary>
        [NameInMap("TargetObjectKey")]
        [Validation(Required=false)]
        public string TargetObjectKey { get; set; }

        /// <summary>
        /// <para>The watermark content. The service internally maps it to an integer watermark ID and restores it when the watermark is extracted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wm-e2e-85970647</para>
        /// </summary>
        [NameInMap("WatermarkContent")]
        [Validation(Required=false)]
        public string WatermarkContent { get; set; }

    }

}
