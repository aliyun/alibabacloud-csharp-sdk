// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunKeywordsExtractionGenerationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReferenceData")]
        [Validation(Required=false)]
        public RunKeywordsExtractionGenerationRequestReferenceData ReferenceData { get; set; }
        public class RunKeywordsExtractionGenerationRequestReferenceData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Contents")]
            [Validation(Required=false)]
            public List<string> Contents { get; set; }

        }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
