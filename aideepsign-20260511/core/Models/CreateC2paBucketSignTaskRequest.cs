// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateC2paBucketSignTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the user OSS bucket. You must authorize the service-linked role AliyunServiceRoleForAIDeepSign to access the bucket in advance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-bucket</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The region of the user OSS bucket. It must be consistent with the actual region of the bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BucketRegionId")]
        [Validation(Required=false)]
        public string BucketRegionId { get; set; }

        /// <summary>
        /// <para>The optional name of the software that generated the content. This parameter is not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Adobe Photoshop 25.0</para>
        /// </summary>
        [NameInMap("SoftwareAgent")]
        [Validation(Required=false)]
        public string SoftwareAgent { get; set; }

        /// <summary>
        /// <para>The source object prefix. It must be <c>ai-deepsign/</c> or its subdirectory. The service recursively processes objects under this prefix.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-deepsign/images/</para>
        /// </summary>
        [NameInMap("SourcePrefix")]
        [Validation(Required=false)]
        public string SourcePrefix { get; set; }

        /// <summary>
        /// <para>The optional content source type. This parameter is not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>digitalCapture</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
