// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetChatContentRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The backend will return output starting from this checkpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>The current DMS unit. Chinese mainland users of Alibaba Cloud should use cn-hangzhou by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The session ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sess_12345</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
