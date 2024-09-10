// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotTopicsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("TopicIds")]
        [Validation(Required=false)]
        public List<string> TopicIds { get; set; }

        [NameInMap("TopicQuery")]
        [Validation(Required=false)]
        public string TopicQuery { get; set; }

        [NameInMap("TopicSource")]
        [Validation(Required=false)]
        public string TopicSource { get; set; }

        [NameInMap("TopicVersion")]
        [Validation(Required=false)]
        public string TopicVersion { get; set; }

        [NameInMap("Topics")]
        [Validation(Required=false)]
        public List<string> Topics { get; set; }

        [NameInMap("WithNews")]
        [Validation(Required=false)]
        public bool? WithNews { get; set; }

    }

}
