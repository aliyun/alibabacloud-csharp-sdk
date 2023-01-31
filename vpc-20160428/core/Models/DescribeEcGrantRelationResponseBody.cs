// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEcGrantRelationResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("EcGrantRelations")]
        [Validation(Required=false)]
        public List<DescribeEcGrantRelationResponseBodyEcGrantRelations> EcGrantRelations { get; set; }
        public class DescribeEcGrantRelationResponseBodyEcGrantRelations : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceRouterId")]
            [Validation(Required=false)]
            public string InstanceRouterId { get; set; }

            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VbrInstanceId")]
            [Validation(Required=false)]
            public string VbrInstanceId { get; set; }

            [NameInMap("VbrOwnerUid")]
            [Validation(Required=false)]
            public long? VbrOwnerUid { get; set; }

            [NameInMap("VbrRegionNo")]
            [Validation(Required=false)]
            public string VbrRegionNo { get; set; }

        }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
