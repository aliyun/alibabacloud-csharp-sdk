// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunAgentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d6zxykawk9</para>
        /// </summary>
        [NameInMap("botId")]
        [Validation(Required=false)]
        public string BotId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4vlag5ken3</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useDraft")]
        [Validation(Required=false)]
        public bool? UseDraft { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userContent")]
        [Validation(Required=false)]
        public string UserContent { get; set; }

        [NameInMap("userInputs")]
        [Validation(Required=false)]
        public Dictionary<string, object> UserInputs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>w4paqoezm2</para>
        /// </summary>
        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
