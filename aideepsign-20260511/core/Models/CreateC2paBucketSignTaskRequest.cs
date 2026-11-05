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
        /// <para>The region of the user OSS bucket. It must match the actual region of the bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BucketRegionId")]
        [Validation(Required=false)]
        public string BucketRegionId { get; set; }

        /// <summary>
        /// <para>The JSON string of the custom assertion list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;label&quot;:&quot;com.shein.internal&quot;,&quot;data&quot;:{&quot;meta_id&quot;:&quot;emp001&quot;,&quot;generation&quot;:{&quot;modelVersion&quot;:&quot;2.1&quot;,&quot;count&quot;:3},&quot;tags&quot;:[&quot;AI-generated&quot;,&quot;E-commerce&quot;],&quot;enabled&quot;:true,&quot;optional&quot;:null}}]</para>
        /// </summary>
        [NameInMap("CustomAssertions")]
        [Validation(Required=false)]
        public string CustomAssertions { get; set; }

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
        /// <para>The source object prefix. It must be ai-deepsign/ or its subdirectories. The service recursively processes objects under this prefix.</para>
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
