// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionLOAResponse : TeaModel {
        /// <summary>
        /// description: The ID of the request. ; 
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// description: The LOA information of the physical connection. 
        /// </summary>
        [NameInMap("PhysicalConnectionLOAType")]
        [Validation(Required=true)]
        public DescribePhysicalConnectionLOAResponsePhysicalConnectionLOAType PhysicalConnectionLOAType { get; set; }
        public class DescribePhysicalConnectionLOAResponsePhysicalConnectionLOAType : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }
            [NameInMap("CompanyName")]
            [Validation(Required=true)]
            public string CompanyName { get; set; }
            [NameInMap("CompanyLocalizedName")]
            [Validation(Required=true)]
            public string CompanyLocalizedName { get; set; }
            [NameInMap("LineType")]
            [Validation(Required=true)]
            public string LineType { get; set; }
            [NameInMap("LineCode")]
            [Validation(Required=true)]
            public string LineCode { get; set; }
            [NameInMap("LineLabel")]
            [Validation(Required=true)]
            public string LineLabel { get; set; }
            [NameInMap("ConstructionTime")]
            [Validation(Required=true)]
            public string ConstructionTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("LoaUrl")]
            [Validation(Required=true)]
            public string LoaUrl { get; set; }
            [NameInMap("SI")]
            [Validation(Required=true)]
            public string SI { get; set; }
            [NameInMap("PMInfo")]
            [Validation(Required=true)]
            public DescribePhysicalConnectionLOAResponsePhysicalConnectionLOATypePMInfo PMInfo { get; set; }
            public class DescribePhysicalConnectionLOAResponsePhysicalConnectionLOATypePMInfo : TeaModel {
                [NameInMap("PMInfo")]
                [Validation(Required=true)]
                public List<DescribePhysicalConnectionLOAResponsePhysicalConnectionLOATypePMInfoPMInfo> PMInfo { get; set; }
                public class DescribePhysicalConnectionLOAResponsePhysicalConnectionLOATypePMInfoPMInfo : TeaModel {
                    /// <summary>
                    /// description: The name of the data center cable installation technician or representative. ; 
                    /// </summary>
                    [NameInMap("PMName")]
                    [Validation(Required=true)]
                    public string PMName { get; set; }

                    /// <summary>
                    /// description: The contact information of the data center cable installation technician or representative. ; 
                    /// </summary>
                    [NameInMap("PMContactInfo")]
                    [Validation(Required=true)]
                    public string PMContactInfo { get; set; }

                    /// <summary>
                    /// description: The type of certificate or licence held by the data center cable installation technician or representative. ; 
                    /// </summary>
                    [NameInMap("PMCertificateType")]
                    [Validation(Required=true)]
                    public string PMCertificateType { get; set; }

                    /// <summary>
                    /// description: The certificate or licence number of the data center cable installation technician or representative.; 
                    /// </summary>
                    [NameInMap("PMCertificateNo")]
                    [Validation(Required=true)]
                    public string PMCertificateNo { get; set; }

                    /// <summary>
                    /// description: The gender of the data center cable installation technician or representative.; 
                    /// </summary>
                    [NameInMap("PMGender")]
                    [Validation(Required=true)]
                    public string PMGender { get; set; }

                }

            }
        };

    }

}
