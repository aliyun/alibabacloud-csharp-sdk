// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateAgentSpecVersionRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateAgentSpecVersionRequestBody Body { get; set; }
        public class CreateAgentSpecVersionRequestBody : TeaModel {
            /// <summary>
            /// <para>The existing version on which to base the draft.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("basedOnVersion")]
            [Validation(Required=false)]
            public string BasedOnVersion { get; set; }

            /// <summary>
            /// <para>The version number for the draft. If not specified, the version number is automatically incremented.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

        }

    }

}
