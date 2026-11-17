// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMemoryRequest : TeaModel {
        /// <summary>
        /// <para>The request to update a memory.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateMemoryRequestBody Body { get; set; }
        public class UpdateMemoryRequestBody : TeaModel {
            /// <summary>
            /// <para>The updated string key-value metadata. Provide at least one of Text or Metadata. A maximum of 16 keys are allowed. The maximum length is 64 characters for a key and 1,024 characters for a value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;topic&quot;:&quot;hiking&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> Metadata { get; set; }

            /// <summary>
            /// <para>The updated memory text. Provide at least one of Text or Metadata. The size cannot exceed 32,000 UTF-8 bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The user enjoys hiking on weekends</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

    }

}
