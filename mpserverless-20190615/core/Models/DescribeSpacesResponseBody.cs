// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeSpacesResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Spaces")]
        [Validation(Required=false)]
        public List<DescribeSpacesResponseBodySpaces> Spaces { get; set; }
        public class DescribeSpacesResponseBodySpaces : TeaModel {
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EmasWorkspaceId")]
            [Validation(Required=false)]
            public long? EmasWorkspaceId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            [NameInMap("PackageEndDate")]
            [Validation(Required=false)]
            public string PackageEndDate { get; set; }

            [NameInMap("PackageStartDate")]
            [Validation(Required=false)]
            public string PackageStartDate { get; set; }

            [NameInMap("PackageStatus")]
            [Validation(Required=false)]
            public string PackageStatus { get; set; }

            [NameInMap("RenewDuration")]
            [Validation(Required=false)]
            public string RenewDuration { get; set; }

            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("SpecCode")]
            [Validation(Required=false)]
            public string SpecCode { get; set; }

        }

    }

}
