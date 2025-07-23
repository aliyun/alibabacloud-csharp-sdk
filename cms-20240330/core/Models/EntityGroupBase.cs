// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EntityGroupBase : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("entityGroupId")]
        [Validation(Required=false)]
        public string EntityGroupId { get; set; }

        [NameInMap("entityGroupName")]
        [Validation(Required=false)]
        public string EntityGroupName { get; set; }

        [NameInMap("entityQueries")]
        [Validation(Required=false)]
        public List<EntityGroupBaseEntityQueries> EntityQueries { get; set; }
        public class EntityGroupBaseEntityQueries : TeaModel {
            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("spl")]
            [Validation(Required=false)]
            public string Spl { get; set; }

        }

        [NameInMap("entityRules")]
        [Validation(Required=false)]
        public EntityDiscoverRule EntityRules { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
