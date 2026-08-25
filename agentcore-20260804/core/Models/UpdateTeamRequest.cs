// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateTeamRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateTeamRequestBody Body { get; set; }
        public class UpdateTeamRequestBody : TeaModel {
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<UpdateTeamRequestBodyAgents> Agents { get; set; }
            public class UpdateTeamRequestBodyAgents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>agent-123456</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>WORKER</para>
                /// </summary>
                [NameInMap("teamRole")]
                [Validation(Required=false)]
                public string TeamRole { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>负责智能客服业务的团队</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("users")]
            [Validation(Required=false)]
            public List<UpdateTeamRequestBodyUsers> Users { get; set; }
            public class UpdateTeamRequestBodyUsers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ADMIN</para>
                /// </summary>
                [NameInMap("teamRole")]
                [Validation(Required=false)]
                public string TeamRole { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>usr-123456</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>暂不支持</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
