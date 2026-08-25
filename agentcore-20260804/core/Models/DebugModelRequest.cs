// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DebugModelRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public DebugModelRequestBody Body { get; set; }
        public class DebugModelRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

        }

    }

}
