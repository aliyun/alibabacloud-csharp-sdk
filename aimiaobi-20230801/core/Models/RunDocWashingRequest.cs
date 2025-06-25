// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocWashingRequest : TeaModel {
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReferenceContent")]
        [Validation(Required=false)]
        public string ReferenceContent { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("WordNumber")]
        [Validation(Required=false)]
        public int? WordNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WritingTypeName")]
        [Validation(Required=false)]
        public string WritingTypeName { get; set; }

        [NameInMap("WritingTypeRefDoc")]
        [Validation(Required=false)]
        public string WritingTypeRefDoc { get; set; }

    }

}
