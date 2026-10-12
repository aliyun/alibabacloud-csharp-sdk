// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetApiPathFieldTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The gateway type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1/chat/completions</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
