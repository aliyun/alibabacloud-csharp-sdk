// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateC2paSignTaskRequest : TeaModel {
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
        /// <para>Not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Qwen ImageGen</para>
        /// </summary>
        [NameInMap("SoftwareAgent")]
        [Validation(Required=false)]
        public string SoftwareAgent { get; set; }

        /// <summary>
        /// <para>Not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trainedAlgorithmicMedia</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
