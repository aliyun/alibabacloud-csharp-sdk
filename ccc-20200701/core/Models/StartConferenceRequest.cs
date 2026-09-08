// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class StartConferenceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A JSON-formatted string representing an array of participants. Each array element represents a participant. For internal calls to agents, the participant is the target agent\&quot;s extension number. For external calls to customers, the participant is the customer\&quot;s phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;8045****&quot;,&quot;1317511****&quot;]</para>
        /// </summary>
        [NameInMap("ParticipantListJson")]
        [Validation(Required=false)]
        public string ParticipantListJson { get; set; }

        /// <summary>
        /// <para>Ingest endpoint data. It cannot exceed 128 bytes and is primarily used for extension requirements. Ordinary customers do not need to concern themselves with it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Timeout period. If the call is not answered within the time specified by this parameter, it will be automatically disconnected. This parameter is optional. The default value is 30 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The agent ID initiating the conference call. This parameter is optional. If not specified, the agent mapped to the current RAM account is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
