// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class DescribeSitePairsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SitePairs")]
        [Validation(Required=false)]
        public DescribeSitePairsResponseBodySitePairs SitePairs { get; set; }
        public class DescribeSitePairsResponseBodySitePairs : TeaModel {
            [NameInMap("sitePair")]
            [Validation(Required=false)]
            public List<DescribeSitePairsResponseBodySitePairsSitePair> SitePair { get; set; }
            public class DescribeSitePairsResponseBodySitePairsSitePair : TeaModel {
                [NameInMap("CloudSiteName")]
                [Validation(Required=false)]
                public string CloudSiteName { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("LocalSiteName")]
                [Validation(Required=false)]
                public string LocalSiteName { get; set; }

                [NameInMap("PrimarySiteId")]
                [Validation(Required=false)]
                public string PrimarySiteId { get; set; }

                [NameInMap("PrimarySiteName")]
                [Validation(Required=false)]
                public string PrimarySiteName { get; set; }

                [NameInMap("ReplicationStatistics")]
                [Validation(Required=false)]
                public DescribeSitePairsResponseBodySitePairsSitePairReplicationStatistics ReplicationStatistics { get; set; }
                public class DescribeSitePairsResponseBodySitePairsSitePairReplicationStatistics : TeaModel {
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public long? Critical { get; set; }

                    [NameInMap("Healthy")]
                    [Validation(Required=false)]
                    public long? Healthy { get; set; }

                    [NameInMap("NotApplicable")]
                    [Validation(Required=false)]
                    public long? NotApplicable { get; set; }

                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public long? Warning { get; set; }

                }

                [NameInMap("SecondarySiteId")]
                [Validation(Required=false)]
                public string SecondarySiteId { get; set; }

                [NameInMap("SecondarySiteName")]
                [Validation(Required=false)]
                public string SecondarySiteName { get; set; }

                [NameInMap("ServerCount")]
                [Validation(Required=false)]
                public int? ServerCount { get; set; }

                [NameInMap("SitePairId")]
                [Validation(Required=false)]
                public string SitePairId { get; set; }

                [NameInMap("SitePairType")]
                [Validation(Required=false)]
                public string SitePairType { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
