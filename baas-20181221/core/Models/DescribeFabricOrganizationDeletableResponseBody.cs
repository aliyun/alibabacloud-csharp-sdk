// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeFabricOrganizationDeletableResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeFabricOrganizationDeletableResponseBodyResult Result { get; set; }
        public class DescribeFabricOrganizationDeletableResponseBodyResult : TeaModel {
            [NameInMap("Deletable")]
            [Validation(Required=false)]
            public bool? Deletable { get; set; }
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
            [NameInMap("OrganizationName")]
            [Validation(Required=false)]
            public string OrganizationName { get; set; }
            [NameInMap("CodeName")]
            [Validation(Required=false)]
            public string CodeName { get; set; }
            [NameInMap("OrganizationDescription")]
            [Validation(Required=false)]
            public string OrganizationDescription { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }
        };

    }

}
