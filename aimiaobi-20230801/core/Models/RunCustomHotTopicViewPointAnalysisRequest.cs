// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCustomHotTopicViewPointAnalysisRequest : TeaModel {
        [NameInMap("AskUser")]
        [Validation(Required=false)]
        public string AskUser { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("SearchQuery")]
        [Validation(Required=false)]
        public string SearchQuery { get; set; }

        [NameInMap("SkipAskUser")]
        [Validation(Required=false)]
        public bool? SkipAskUser { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

        [NameInMap("TopicSource")]
        [Validation(Required=false)]
        public string TopicSource { get; set; }

        [NameInMap("TopicVersion")]
        [Validation(Required=false)]
        public string TopicVersion { get; set; }

        [NameInMap("UserBack")]
        [Validation(Required=false)]
        public string UserBack { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
