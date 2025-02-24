// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunGenerateQuestionsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>oOgIwodFANW1u5MnqxysOh1rtld3xn</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        [NameInMap("ReferenceContent")]
        [Validation(Required=false)]
        public string ReferenceContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f486c4e2-b773-4d65-88f8-2ba540610456</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-w335gauzlbba2vze</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
