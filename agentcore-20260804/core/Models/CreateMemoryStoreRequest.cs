// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateMemoryStoreRequest : TeaModel {
        /// <summary>
        /// <para>The request to create a memory store.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateMemoryStoreRequestBody Body { get; set; }
        public class CreateMemoryStoreRequestBody : TeaModel {
            /// <summary>
            /// <para>The description of the memory store. Maximum of 1,024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used to store long-term user preferences</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The custom extraction instructions. Maximum of 4,096 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extract only long-term preferences explicitly expressed by the user</para>
            /// </summary>
            [NameInMap("extractInstructions")]
            [Validation(Required=false)]
            public string ExtractInstructions { get; set; }

            /// <summary>
            /// <para>The name of the memory store. The name must be 1 to 64 characters in length and can contain only lowercase letters, digits, and hyphens (-). The name cannot be modified after creation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer-memory</para>
            /// </summary>
            [NameInMap("memoryStoreName")]
            [Validation(Required=false)]
            public string MemoryStoreName { get; set; }

        }

        /// <summary>
        /// <para>The client request token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory-store-create-20260909-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
