// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAICoachTaskSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>rtctoken</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("channelToken")]
        [Validation(Required=false)]
        public string ChannelToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4830493A-728F-5F19-BBCC-1443292E9C49</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptInfo")]
        [Validation(Required=false)]
        public CreateAICoachTaskSessionResponseBodyScriptInfo ScriptInfo { get; set; }
        public class CreateAICoachTaskSessionResponseBodyScriptInfo : TeaModel {
            [NameInMap("agentIconUrl")]
            [Validation(Required=false)]
            public string AgentIconUrl { get; set; }

            [NameInMap("characterName")]
            [Validation(Required=false)]
            public string CharacterName { get; set; }

            [NameInMap("dialogueTextFlag")]
            [Validation(Required=false)]
            public bool? DialogueTextFlag { get; set; }

            [NameInMap("dialogueTipFlag")]
            [Validation(Required=false)]
            public bool? DialogueTipFlag { get; set; }

            [NameInMap("initiator")]
            [Validation(Required=false)]
            public string Initiator { get; set; }

            [NameInMap("inputTypeList")]
            [Validation(Required=false)]
            public List<string> InputTypeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("maxDuration")]
            [Validation(Required=false)]
            public long? MaxDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("scriptDesc")]
            [Validation(Required=false)]
            public string ScriptDesc { get; set; }

            [NameInMap("scriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            [NameInMap("scriptRecordId")]
            [Validation(Required=false)]
            public string ScriptRecordId { get; set; }

            [NameInMap("scriptType")]
            [Validation(Required=false)]
            public long? ScriptType { get; set; }

            [NameInMap("sparringTipContent")]
            [Validation(Required=false)]
            public string SparringTipContent { get; set; }

            [NameInMap("sparringTipTitle")]
            [Validation(Required=false)]
            public string SparringTipTitle { get; set; }

            [NameInMap("studentThinkTimeFlag")]
            [Validation(Required=false)]
            public bool? StudentThinkTimeFlag { get; set; }

            [NameInMap("studentThinkTimeLimit")]
            [Validation(Required=false)]
            public long? StudentThinkTimeLimit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("sessionStatus")]
        [Validation(Required=false)]
        public long? SessionStatus { get; set; }

        /// <summary>
        /// <para>Token</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("webSocketUrl")]
        [Validation(Required=false)]
        public string WebSocketUrl { get; set; }

    }

}
