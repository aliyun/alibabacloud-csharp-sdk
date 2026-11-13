// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetApiPathFieldTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The API request path, used to query the field template corresponding to the path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1/chat/completions</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
