// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunHotwordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>84ufBYEeLMZOjRFo84HJ7ySL3Efr55</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("ReferenceContent")]
        [Validation(Required=false)]
        public string ReferenceContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e32a1a3f-1f7e-41dd-b888-ef1d91b96d1e</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-baw8as25ll3wnzjr</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
