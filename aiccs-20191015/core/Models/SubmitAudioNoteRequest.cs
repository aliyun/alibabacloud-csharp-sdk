// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class SubmitAudioNoteRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the notes agent. Specify the ID of a published recording notes agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The custom task ID defined by the business side. This ID is used to associate external business records during callbacks or troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>biz-001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The storage path of the recording file in OSS. Use the FilePath returned by the upload address retrieval operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audio-note/100/uuid/test.wav</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The ID of the LLM model used for notes inference. If this parameter is not specified, the default model configuration of the agent is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88</para>
        /// </summary>
        [NameInMap("LlmModelId")]
        [Validation(Required=false)]
        public long? LlmModelId { get; set; }

    }

}
