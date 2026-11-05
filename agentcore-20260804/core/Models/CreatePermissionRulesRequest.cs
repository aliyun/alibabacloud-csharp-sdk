// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreatePermissionRulesRequest : TeaModel {
        /// <summary>
        /// <para>The request body for creating permission rules.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreatePermissionRulesRequestBody Body { get; set; }
        public class CreatePermissionRulesRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of permission rules to be created.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<CreatePermissionRulesRequestBodyRules> Rules { get; set; }
            public class CreatePermissionRulesRequestBodyRules : TeaModel {
                /// <summary>
                /// <para>The authorization effect.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PERMIT</para>
                /// </summary>
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The rule enforcement mode.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENFORCE</para>
                /// </summary>
                [NameInMap("enforcementMode")]
                [Validation(Required=false)]
                public string EnforcementMode { get; set; }

                /// <summary>
                /// <para>The principal ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890123456</para>
                /// </summary>
                [NameInMap("principalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// <para>The principal type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("principalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-1234567890</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The rule source.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AgentCore</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The target scope.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SPECIFIED</para>
                /// </summary>
                [NameInMap("targetScope")]
                [Validation(Required=false)]
                public string TargetScope { get; set; }

                /// <summary>
                /// <para>The list of targets for the rule.</para>
                /// </summary>
                [NameInMap("targets")]
                [Validation(Required=false)]
                public List<string> Targets { get; set; }

            }

        }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
