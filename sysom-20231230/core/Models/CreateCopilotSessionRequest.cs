// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateCopilotSessionRequest : TeaModel {
        /// <summary>
        /// <para>不填为 New Session</para>
        /// 
        /// <b>Example:</b>
        /// <para>排查 CPU 负载</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
