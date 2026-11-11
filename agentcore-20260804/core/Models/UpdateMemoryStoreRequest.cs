// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMemoryStoreRequest : TeaModel {
        /// <summary>
        /// <para>The update memory store request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateMemoryStoreRequestBody Body { get; set; }
        public class UpdateMemoryStoreRequestBody : TeaModel {
            /// <summary>
            /// <para>The description of the memory store. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A memory store used to save long-term customer preferences</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The custom memory extraction instructions. Maximum length: 4096 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extract only long-term preferences explicitly expressed by the user</para>
            /// </summary>
            [NameInMap("extractInstructions")]
            [Validation(Required=false)]
            public string ExtractInstructions { get; set; }

        }

        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory-store-update-20260909-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
