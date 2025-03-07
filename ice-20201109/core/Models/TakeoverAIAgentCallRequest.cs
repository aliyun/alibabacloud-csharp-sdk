// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class TakeoverAIAgentCallRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the human agent that will take over the AI agent (UserId in ARTC). If you do not specify this parameter, it is automatically generated and returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid2</para>
        /// </summary>
        [NameInMap("HumanAgentUserId")]
        [Validation(Required=false)]
        public string HumanAgentUserId { get; set; }

        /// <summary>
        /// <para>The ID of the AI agent that will be taken over.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the ARTC token. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequireToken")]
        [Validation(Required=false)]
        public bool? RequireToken { get; set; }

    }

}
