// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateC2paBucketSignTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket. The value must be 3 to 63 characters in length. Before you call this operation, you must authorize the <c>AliyunServiceRoleForAIDeepSign</c> service-linked role to read the source files, and access and write the signing results and reports.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-bucket</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The region of the OSS bucket. The value can be up to 64 characters in length and must match the actual region of the bucket. Example: <c>cn-hangzhou</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BucketRegionId")]
        [Validation(Required=false)]
        public string BucketRegionId { get; set; }

        /// <summary>
        /// <para>The optional list of custom assertions. Pass a JSON array string. The original JSON text can be up to 4,096 UTF-8 bytes in length and contain up to 64 assertions. Each item must and can only contain <c>label</c> and <c>data</c>. <c>data</c> supports any JSON value. Objects and arrays can be nested up to 5 levels deep, and JSON integers must be within the signed 64-bit range. The assertions are written into the manifest of the signature file and can be read and authenticated for integrity by <c>label</c>. Each file in the same batch uses the same set of assertions. The content saved during creation is retained after the task is paused and resumed. For detailed formats, limits, and examples, see the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;label&quot;:&quot;com.shein.internal&quot;,&quot;data&quot;:{&quot;meta_id&quot;:&quot;emp001&quot;,&quot;generation&quot;:{&quot;modelVersion&quot;:&quot;2.1&quot;,&quot;count&quot;:3},&quot;tags&quot;:[&quot;AI-generated&quot;,&quot;E-commerce&quot;],&quot;enabled&quot;:true,&quot;optional&quot;:null}}]</para>
        /// </summary>
        [NameInMap("CustomAssertions")]
        [Validation(Required=false)]
        public string CustomAssertions { get; set; }

        /// <summary>
        /// <para>The optional name of the software that generated or processed the content. The value can be up to 128 characters in length. Example: <c>Example Studio 1.0</c>. This software information is written into the content credential of the signature file. Each file in the same batch uses the value saved when the task is created. The original value is retained after the task is paused and resumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Adobe Photoshop 25.0</para>
        /// </summary>
        [NameInMap("SoftwareAgent")]
        [Validation(Required=false)]
        public string SoftwareAgent { get; set; }

        /// <summary>
        /// <para>The prefix of the objects to be processed. The value can be up to 1,023 UTF-8 bytes in length and must be <c>ai-deepsign/</c> or its subdirectory. If the trailing <c>/</c> is missing, the service automatically appends it, and the completed prefix must also meet the length limit. The service recursively processes non-directory objects under this prefix and supports <c>.jpg</c>, <c>.jpeg</c>, <c>.png</c>, <c>.mp4</c>, <c>.flac</c>, <c>.m4a</c>, <c>.mp3</c>, and <c>.wav</c> extensions, which are case-insensitive. Scanning the root directory of the bucket is not allowed, and the prefix cannot overlap with the output prefix <c>ai-deepsign-signed/</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-deepsign/images/</para>
        /// </summary>
        [NameInMap("SourcePrefix")]
        [Validation(Required=false)]
        public string SourcePrefix { get; set; }

        /// <summary>
        /// <para>The optional content source type. The value can be up to 128 characters in length. It supports 19 short names and their corresponding full HTTP URIs, which are case-sensitive. Examples: <c>digitalCapture</c> and <c>trainedAlgorithmicMedia</c>. The source declaration is written into the content credential of the signature file. Each file in the same batch uses the value saved when the task is created. If this parameter is left empty, no additional declaration is made. The service will deny invalid values during the creation phase. For the complete enumeration and URIs, see the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>digitalCapture</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
