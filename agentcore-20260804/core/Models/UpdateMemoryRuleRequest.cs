// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMemoryRuleRequest : TeaModel {
        /// <summary>
        /// <para>The JSON request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateMemoryRuleRequestBody Body { get; set; }
        public class UpdateMemoryRuleRequestBody : TeaModel {
            /// <summary>
            /// <para>description</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extract long-term preferences explicitly expressed by the user</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Long-term preferences</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The extraction strategy. Omitted fields retain their original values during a partial merge.</para>
            /// </summary>
            [NameInMap("strategy")]
            [Validation(Required=false)]
            public UpdateMemoryRuleRequestBodyStrategy Strategy { get; set; }
            public class UpdateMemoryRuleRequestBodyStrategy : TeaModel {
                /// <summary>
                /// <para>The custom extraction requirements. Omitted fields retain their original values, and an empty string clears the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Retain only long-term preferences explicitly expressed by the user</para>
                /// </summary>
                [NameInMap("instruction")]
                [Validation(Required=false)]
                public string Instruction { get; set; }

                /// <summary>
                /// <para>type</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
