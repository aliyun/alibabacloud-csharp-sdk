// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionLOAResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PhysicalConnectionLOAType")]
        [Validation(Required=false)]
        public DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOAType PhysicalConnectionLOAType { get; set; }
        public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOAType : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("LineLabel")]
            [Validation(Required=false)]
            public string LineLabel { get; set; }
            [NameInMap("LineCode")]
            [Validation(Required=false)]
            public string LineCode { get; set; }
            [NameInMap("ConstructionTime")]
            [Validation(Required=false)]
            public string ConstructionTime { get; set; }
            [NameInMap("SI")]
            [Validation(Required=false)]
            public string SI { get; set; }
            [NameInMap("LoaUrl")]
            [Validation(Required=false)]
            public string LoaUrl { get; set; }
            [NameInMap("CompanyLocalizedName")]
            [Validation(Required=false)]
            public string CompanyLocalizedName { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("PMInfo")]
            [Validation(Required=false)]
            public DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfo PMInfo { get; set; }
            public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfo : TeaModel {
                [NameInMap("PMInfo")]
                [Validation(Required=false)]
                public List<DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfoPMInfo> PMInfo { get; set; }
                public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfoPMInfo : TeaModel {
                    [NameInMap("PMCertificateNo")]
                    [Validation(Required=false)]
                    public string PMCertificateNo { get; set; }

                    [NameInMap("PMName")]
                    [Validation(Required=false)]
                    public string PMName { get; set; }

                    [NameInMap("PMCertificateType")]
                    [Validation(Required=false)]
                    public string PMCertificateType { get; set; }

                    [NameInMap("PMGender")]
                    [Validation(Required=false)]
                    public string PMGender { get; set; }

                    [NameInMap("PMContactInfo")]
                    [Validation(Required=false)]
                    public string PMContactInfo { get; set; }

                }

            }
            [NameInMap("LineType")]
            [Validation(Required=false)]
            public string LineType { get; set; }
            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }
        };

    }

}
