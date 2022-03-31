// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateLakeHouseSpaceRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DevDbId")]
        [Validation(Required=false)]
        public string DevDbId { get; set; }

        [NameInMap("DwDbType")]
        [Validation(Required=false)]
        public string DwDbType { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("ProdDbId")]
        [Validation(Required=false)]
        public string ProdDbId { get; set; }

        [NameInMap("SpaceConfig")]
        [Validation(Required=false)]
        public string SpaceConfig { get; set; }

        [NameInMap("SpaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
