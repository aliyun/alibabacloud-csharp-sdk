// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateAgentSpecRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateAgentSpecRequestBody Body { get; set; }
        public class CreateAgentSpecRequestBody : TeaModel {
            /// <summary>
            /// <para>The unique name of the AgentSpec.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-worker</para>
            /// </summary>
            [NameInMap("agentSpecName")]
            [Validation(Required=false)]
            public string AgentSpecName { get; set; }

            /// <summary>
            /// <para>The draft version number. If not specified, the default value is 0.0.1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

        }

    }

}
