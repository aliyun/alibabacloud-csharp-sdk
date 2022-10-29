// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListHostGroupsRequest : TeaModel {
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        [NameInMap("creatorAccountIds")]
        [Validation(Required=false)]
        public string CreatorAccountIds { get; set; }

        [NameInMap("ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("pageOrder")]
        [Validation(Required=false)]
        public string PageOrder { get; set; }

        [NameInMap("pageSort")]
        [Validation(Required=false)]
        public string PageSort { get; set; }

    }

}
