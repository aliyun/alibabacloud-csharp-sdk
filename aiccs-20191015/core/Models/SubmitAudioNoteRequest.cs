// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class SubmitAudioNoteRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the audio note agent. You must specify the ID of an online audio note agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The custom task ID defined by your business system, used to associate external business records for callbacks or troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>biz-001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The storage path of the audio file in OSS. You must use the FilePath returned by the operation for obtaining the upload URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audio-note/100/uuid/test.wav</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The ID of the large language model (LLM) used for audio note inference. If you do not specify this parameter, the default model configuration of the agent is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88</para>
        /// </summary>
        [NameInMap("LlmModelId")]
        [Validation(Required=false)]
        public long? LlmModelId { get; set; }

    }

}
