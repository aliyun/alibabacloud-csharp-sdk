// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateC2paSignTaskRequest : TeaModel {
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
        /// <para>The absolute HTTP or HTTPS URL of the file to be signed. The URL can be up to 4,096 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/images/photo.png?token=xxx">https://example.com/images/photo.png?token=xxx</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>This parameter is not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Qwen ImageGen</para>
        /// </summary>
        [NameInMap("SoftwareAgent")]
        [Validation(Required=false)]
        public string SoftwareAgent { get; set; }

        /// <summary>
        /// <para>This parameter is not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trainedAlgorithmicMedia</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
