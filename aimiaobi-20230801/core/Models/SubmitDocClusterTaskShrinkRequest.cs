// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitDocClusterTaskShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public string DocumentsShrink { get; set; }

        [NameInMap("SummaryLength")]
        [Validation(Required=false)]
        public int? SummaryLength { get; set; }

        [NameInMap("TitleLength")]
        [Validation(Required=false)]
        public int? TitleLength { get; set; }

        [NameInMap("TopicCount")]
        [Validation(Required=false)]
        public int? TopicCount { get; set; }

    }

}
