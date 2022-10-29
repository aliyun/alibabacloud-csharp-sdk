// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelinesRequest : TeaModel {
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        [NameInMap("creatorAccountIds")]
        [Validation(Required=false)]
        public string CreatorAccountIds { get; set; }

        [NameInMap("executeAccountIds")]
        [Validation(Required=false)]
        public string ExecuteAccountIds { get; set; }

        [NameInMap("executeEndTime")]
        [Validation(Required=false)]
        public long? ExecuteEndTime { get; set; }

        [NameInMap("executeStartTime")]
        [Validation(Required=false)]
        public long? ExecuteStartTime { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        [NameInMap("statusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

    }

}
