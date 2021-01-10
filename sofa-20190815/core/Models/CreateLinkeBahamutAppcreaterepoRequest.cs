// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeBahamutAppcreaterepoRequest : TeaModel {
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("InitProject")]
        [Validation(Required=false)]
        public string InitProject { get; set; }

        [NameInMap("Repo")]
        [Validation(Required=false)]
        public string Repo { get; set; }

        [NameInMap("RepoDescription")]
        [Validation(Required=false)]
        public string RepoDescription { get; set; }

        [NameInMap("TenantIdOrg")]
        [Validation(Required=false)]
        public string TenantIdOrg { get; set; }

        [NameInMap("VisibilityLevel")]
        [Validation(Required=false)]
        public string VisibilityLevel { get; set; }

    }

}
