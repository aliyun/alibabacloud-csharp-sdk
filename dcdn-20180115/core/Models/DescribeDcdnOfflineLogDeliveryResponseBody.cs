// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnOfflineLogDeliveryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDcdnOfflineLogDeliveryResponseBodyDomains> Domains { get; set; }
        public class DescribeDcdnOfflineLogDeliveryResponseBodyDomains : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeDcdnOfflineLogDeliveryResponseBodyRegions> Regions { get; set; }
        public class DescribeDcdnOfflineLogDeliveryResponseBodyRegions : TeaModel {
            [NameInMap("OssId")]
            [Validation(Required=false)]
            public int? OssId { get; set; }

            [NameInMap("OssPathPrefix")]
            [Validation(Required=false)]
            public string OssPathPrefix { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            [NameInMap("DlaTableName")]
            [Validation(Required=false)]
            public string DlaTableName { get; set; }

            [NameInMap("DlaVcName")]
            [Validation(Required=false)]
            public string DlaVcName { get; set; }

            [NameInMap("DlaDbName")]
            [Validation(Required=false)]
            public string DlaDbName { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("IsOverseas")]
            [Validation(Required=false)]
            public string IsOverseas { get; set; }

            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

        }

    }

}
