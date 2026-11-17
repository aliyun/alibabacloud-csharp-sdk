// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateC2paSignTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow overwriting when the target object already exists. Default value: false. If the target object exists and this parameter is set to false, the creation is rejected. If this parameter is set to true, existing objects can be overwritten, which supports in-place signing where the target object key can be the same as the source object key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowOverwrite")]
        [Validation(Required=false)]
        public bool? AllowOverwrite { get; set; }

        /// <summary>
        /// <para>The name of the user\&quot;s OSS bucket where the source file is located. This parameter, together with BucketRegionId and ObjectKey, forms the bucket source. Either this parameter or FileUrl is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-bucket</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The region ID of the user\&quot;s OSS bucket where the source file is located. This parameter, together with BucketName and ObjectKey, forms the bucket source. Either this parameter or FileUrl is required. Example: cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BucketRegionId")]
        [Validation(Required=false)]
        public string BucketRegionId { get; set; }

        /// <summary>
        /// <para>The optional list of custom assertions. Pass a JSON array string. The original JSON text can be up to 4,096 UTF-8 bytes in length and contain up to 64 assertions. Each item must and can only contain label and data. data supports any JSON value. Objects and arrays can be nested up to 5 levels deep. JSON integers must be within the signed 64-bit range. The assertions are written into the manifest of the signed file and can be read and authenticated for integrity by label. For detailed formats, limits, and examples, refer to the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;label&quot;:&quot;com.shein.internal&quot;,&quot;data&quot;:{&quot;meta_id&quot;:&quot;emp001&quot;,&quot;generation&quot;:{&quot;modelVersion&quot;:&quot;2.1&quot;,&quot;count&quot;:3},&quot;tags&quot;:[&quot;AI-generated&quot;,&quot;E-commerce&quot;],&quot;enabled&quot;:true,&quot;optional&quot;:null}}]</para>
        /// </summary>
        [NameInMap("CustomAssertions")]
        [Validation(Required=false)]
        public string CustomAssertions { get; set; }

        /// <summary>
        /// <para>The absolute HTTP or HTTPS URL of signature file to be signed. The URL can be up to 4,096 characters in length and cannot contain URL user info. The URL path must end with a .jpg, .jpeg, .png, .mp4, .flac, .m4a, .mp3, or .wav file name. Signature file extension is case-insensitive. The URL query is not used for file name identification. The source URL must be accessible by the service and directly return an HTTP 200 status code. Redirection is not supported. The size of a single file cannot exceed 800 MiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/images/photo.png?token=xxx">https://example.com/images/photo.png?token=xxx</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The object key of the source file in the user\&quot;s OSS bucket. This parameter, together with BucketRegionId and BucketName, forms the bucket source. Either this parameter or FileUrl is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-deepsign/example.png</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// <para>The optional name of the software that generated or processed the content. The value can be up to 128 characters in length, such as Example Studio 1.0. This software information is written into the content credentials of the signed file and is independent of SourceType and CustomAssertions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Qwen ImageGen</para>
        /// </summary>
        [NameInMap("SoftwareAgent")]
        [Validation(Required=false)]
        public string SoftwareAgent { get; set; }

        /// <summary>
        /// <para>The optional content source type. The value can be up to 128 characters in length. It supports 19 short names and their corresponding full HTTP URIs, and is case-sensitive. Examples include digitalCapture and trainedAlgorithmicMedia. The source declaration is written into the content credentials of the signed file. If this parameter is not specified, no additional source type is declared. The service denies invalid values during the creation phase. For the complete enumeration and URIs, refer to the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trainedAlgorithmicMedia</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The optional name of the user\&quot;s OSS bucket to which the signing result is written. If this parameter is empty, the result is written to an internal bucket of the service and returned through SignedFileUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-target-bucket</para>
        /// </summary>
        [NameInMap("TargetBucketName")]
        [Validation(Required=false)]
        public string TargetBucketName { get; set; }

        /// <summary>
        /// <para>The optional region ID of the user\&quot;s OSS bucket to which the signing result is written. If this parameter is empty, the source BucketRegionId is reused for same-region writes. For cross-region writes, this parameter must be explicitly specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("TargetBucketRegion")]
        [Validation(Required=false)]
        public string TargetBucketRegion { get; set; }

        /// <summary>
        /// <para>The optional full object key of the signed artifact written to the user\&quot;s bucket. This parameter must be provided together with TargetBucketName. It must start with ai-deepsign-signed/ and be a full object name with an extension, not a directory prefix. The server does not append the _signed suffix or a trailing slash.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-deepsign-signed/2026/photo.png</para>
        /// </summary>
        [NameInMap("TargetObjectKey")]
        [Validation(Required=false)]
        public string TargetObjectKey { get; set; }

    }

}
