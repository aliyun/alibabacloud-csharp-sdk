// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddProjectManagerRequest : TeaModel {
        [NameInMap("org_entities")]
        [Validation(Required=false)]
        public List<AddProjectManagerRequestOrgEntities> OrgEntities { get; set; }
        public class AddProjectManagerRequestOrgEntities : TeaModel {
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        [NameInMap("out_project_id")]
        [Validation(Required=false)]
        public string OutProjectId { get; set; }

        [NameInMap("project_id")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
