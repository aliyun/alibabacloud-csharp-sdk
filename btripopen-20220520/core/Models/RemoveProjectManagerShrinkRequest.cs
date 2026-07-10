// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class RemoveProjectManagerShrinkRequest : TeaModel {
        [NameInMap("org_entities")]
        [Validation(Required=false)]
        public string OrgEntitiesShrink { get; set; }

        [NameInMap("out_project_id")]
        [Validation(Required=false)]
        public string OutProjectId { get; set; }

        [NameInMap("project_id")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("remove_all")]
        [Validation(Required=false)]
        public bool? RemoveAll { get; set; }

    }

}
