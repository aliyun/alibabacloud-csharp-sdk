// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class PrecheckVideoCharacterReplaceJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the video character replacement application. Use a configured application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application input parameters, which are provided as a JSON-serialized string. The field names and material requirements are subject to the input definition of the corresponding AppId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;LoadImage.1.TargetImage&quot;:&quot;1a7852b032c371f0b64fe6f6c74b****&quot;}</para>
        /// </summary>
        [NameInMap("AppParams")]
        [Validation(Required=false)]
        public string AppParams { get; set; }

    }

}
