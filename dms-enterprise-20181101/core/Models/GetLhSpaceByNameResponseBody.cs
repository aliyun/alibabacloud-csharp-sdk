// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetLhSpaceByNameResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LakehouseSpace")]
        [Validation(Required=false)]
        public GetLhSpaceByNameResponseBodyLakehouseSpace LakehouseSpace { get; set; }
        public class GetLhSpaceByNameResponseBodyLakehouseSpace : TeaModel {
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DevDbId")]
            [Validation(Required=false)]
            public int? DevDbId { get; set; }
            [NameInMap("DwDbType")]
            [Validation(Required=false)]
            public string DwDbType { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }
            [NameInMap("ProdDbId")]
            [Validation(Required=false)]
            public int? ProdDbId { get; set; }
            [NameInMap("SpaceConfig")]
            [Validation(Required=false)]
            public string SpaceConfig { get; set; }
            [NameInMap("SpaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
