// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class OnlineSkillRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public OnlineSkillRequestBody Body { get; set; }
        public class OnlineSkillRequestBody : TeaModel {
            /// <summary>
            /// <para>The operation scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>skill: the entire Skill.</description></item>
            /// <item><description>version: a specified version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>version</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The Skill version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("skillVersion")]
            [Validation(Required=false)]
            public string SkillVersion { get; set; }

        }

    }

}
