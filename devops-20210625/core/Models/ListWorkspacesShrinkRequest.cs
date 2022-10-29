// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkspacesShrinkRequest : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("statusList")]
        [Validation(Required=false)]
        public string StatusListShrink { get; set; }

        [NameInMap("workspaceTemplateList")]
        [Validation(Required=false)]
        public string WorkspaceTemplateListShrink { get; set; }

    }

}
