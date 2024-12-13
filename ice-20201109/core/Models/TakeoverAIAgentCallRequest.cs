// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class TakeoverAIAgentCallRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>uid2</para>
        /// </summary>
        [NameInMap("HumanAgentUserId")]
        [Validation(Required=false)]
        public string HumanAgentUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequireToken")]
        [Validation(Required=false)]
        public bool? RequireToken { get; set; }

    }

}
