// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class ListTemplateCacheRequest : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
