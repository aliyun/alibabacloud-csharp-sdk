// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomEntitiesResponseBody : TeaModel {
        [NameInMap("CustomEntities")]
        [Validation(Required=false)]
        public ListCustomEntitiesResponseBodyCustomEntities CustomEntities { get; set; }
        public class ListCustomEntitiesResponseBodyCustomEntities : TeaModel {
            [NameInMap("CustomEntity")]
            [Validation(Required=false)]
            public List<ListCustomEntitiesResponseBodyCustomEntitiesCustomEntity> CustomEntity { get; set; }
            public class ListCustomEntitiesResponseBodyCustomEntitiesCustomEntity : TeaModel {
                [NameInMap("CustomEntityId")]
                [Validation(Required=false)]
                public string CustomEntityId { get; set; }

                [NameInMap("CustomEntityInfo")]
                [Validation(Required=false)]
                public string CustomEntityInfo { get; set; }

                [NameInMap("CustomEntityName")]
                [Validation(Required=false)]
                public string CustomEntityName { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
