// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DebugModelRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public DebugModelRequestBody Body { get; set; }
        public class DebugModelRequestBody : TeaModel {
            /// <summary>
            /// <para>The prompt used to verify the model call chain.</para>
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
