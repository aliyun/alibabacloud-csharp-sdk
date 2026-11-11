// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateCopilotSessionRequest : TeaModel {
        /// <summary>
        /// <para>The session name. The name must be 1 to 255 characters in length. Default value: New Session. Empty strings or null values are not supported. If no name is specified, the server uses content generation to create a session name based on the first user message when it is received.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Troubleshoot CPU load</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
