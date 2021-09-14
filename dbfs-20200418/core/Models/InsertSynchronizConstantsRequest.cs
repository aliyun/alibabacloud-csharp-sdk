// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class InsertSynchronizConstantsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("AccessData")]
        [Validation(Required=false)]
        public string AccessData { get; set; }

        [NameInMap("EndpointData")]
        [Validation(Required=false)]
        public string EndpointData { get; set; }

        [NameInMap("MasterData")]
        [Validation(Required=false)]
        public string MasterData { get; set; }

        [NameInMap("ProductCodeData")]
        [Validation(Required=false)]
        public string ProductCodeData { get; set; }

        [NameInMap("OsversionData")]
        [Validation(Required=false)]
        public string OsversionData { get; set; }

        [NameInMap("ZoneData")]
        [Validation(Required=false)]
        public string ZoneData { get; set; }

        [NameInMap("RegionData")]
        [Validation(Required=false)]
        public string RegionData { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
