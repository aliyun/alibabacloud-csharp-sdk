// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMemoryStoreRequest : TeaModel {
        /// <summary>
        /// <para>The update MemoryStore request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateMemoryStoreRequestBody Body { get; set; }
        public class UpdateMemoryStoreRequestBody : TeaModel {
            /// <summary>
            /// <para>The MemoryStore description, up to 1,024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Memory store used to save long-term customer preferences</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The custom memory extraction instructions, up to 4,096 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extract only long-term preferences explicitly expressed by the user</para>
            /// </summary>
            [NameInMap("extractInstructions")]
            [Validation(Required=false)]
            public string ExtractInstructions { get; set; }

        }

        /// <summary>
        /// <para>The client request token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory-store-update-20260909-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
