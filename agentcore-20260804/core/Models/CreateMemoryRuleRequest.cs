// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateMemoryRuleRequest : TeaModel {
        /// <summary>
        /// <para>The JSON request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateMemoryRuleRequestBody Body { get; set; }
        public class CreateMemoryRuleRequestBody : TeaModel {
            /// <summary>
            /// <para>description</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extract long-term preferences explicitly expressed by users</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Long-term preferences</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>strategy</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("strategy")]
            [Validation(Required=false)]
            public CreateMemoryRuleRequestBodyStrategy Strategy { get; set; }
            public class CreateMemoryRuleRequestBodyStrategy : TeaModel {
                /// <summary>
                /// <para>The strategy-level instruction. It takes effect together with the store-level instruction. If a conflict occurs, this field takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Retain only long-term preferences explicitly expressed by users</para>
                /// </summary>
                [NameInMap("instruction")]
                [Validation(Required=false)]
                public string Instruction { get; set; }

                /// <summary>
                /// <para>type</para>
                /// <para>This parameter is required.</para>
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
