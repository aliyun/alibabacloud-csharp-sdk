// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionLOAResponseBody : TeaModel {
        /// <summary>
        /// The LOA information about the Express Connect circuit.
        /// </summary>
        [NameInMap("PhysicalConnectionLOAType")]
        [Validation(Required=false)]
        public DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOAType PhysicalConnectionLOAType { get; set; }
        public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOAType : TeaModel {
            /// <summary>
            /// The name of the construction company.
            /// </summary>
            [NameInMap("CompanyLocalizedName")]
            [Validation(Required=false)]
            public string CompanyLocalizedName { get; set; }

            /// <summary>
            /// The name of the organization that requires the Express Connect circuit.
            /// </summary>
            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            /// <summary>
            /// The time when construction starts.
            /// </summary>
            [NameInMap("ConstructionTime")]
            [Validation(Required=false)]
            public string ConstructionTime { get; set; }

            /// <summary>
            /// The ID of the Express Connect circuit.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The circuit code provided by the connectivity provider.
            /// </summary>
            [NameInMap("LineCode")]
            [Validation(Required=false)]
            public string LineCode { get; set; }

            /// <summary>
            /// The label of the cable in the data center.
            /// </summary>
            [NameInMap("LineLabel")]
            [Validation(Required=false)]
            public string LineLabel { get; set; }

            [NameInMap("LineSPContactInfo")]
            [Validation(Required=false)]
            public string LineSPContactInfo { get; set; }

            [NameInMap("LineServiceProvider")]
            [Validation(Required=false)]
            public string LineServiceProvider { get; set; }

            /// <summary>
            /// The type of the Express Connect circuit. Valid values:
            /// 
            /// *   **MSTP**
            /// *   **MPLSVPN**
            /// *   **FIBRE**
            /// *   **Other**
            /// </summary>
            [NameInMap("LineType")]
            [Validation(Required=false)]
            public string LineType { get; set; }

            /// <summary>
            /// The download URL of the LOA file.
            /// </summary>
            [NameInMap("LoaUrl")]
            [Validation(Required=false)]
            public string LoaUrl { get; set; }

            /// <summary>
            /// The information about the construction workers.
            /// </summary>
            [NameInMap("PMInfo")]
            [Validation(Required=false)]
            public DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfo PMInfo { get; set; }
            public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfo : TeaModel {
                [NameInMap("PMInfo")]
                [Validation(Required=false)]
                public List<DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfoPMInfo> PMInfo { get; set; }
                public class DescribePhysicalConnectionLOAResponseBodyPhysicalConnectionLOATypePMInfoPMInfo : TeaModel {
                    /// <summary>
                    /// The identity document number of the construction worker.
                    /// </summary>
                    [NameInMap("PMCertificateNo")]
                    [Validation(Required=false)]
                    public string PMCertificateNo { get; set; }

                    /// <summary>
                    /// The identity document type of the construction worker. Valid values:
                    /// 
                    /// *   **IDCard**: identity card
                    /// *   **Passport**: passport
                    /// *   **Other**: other identity documents
                    /// </summary>
                    [NameInMap("PMCertificateType")]
                    [Validation(Required=false)]
                    public string PMCertificateType { get; set; }

                    /// <summary>
                    /// The phone number of the construction worker.
                    /// </summary>
                    [NameInMap("PMContactInfo")]
                    [Validation(Required=false)]
                    public string PMContactInfo { get; set; }

                    /// <summary>
                    /// The gender of the construction worker. Valid values:
                    /// 
                    /// *   **Male**: male
                    /// *   **Female**: female
                    /// </summary>
                    [NameInMap("PMGender")]
                    [Validation(Required=false)]
                    public string PMGender { get; set; }

                    /// <summary>
                    /// The name of the construction worker.
                    /// </summary>
                    [NameInMap("PMName")]
                    [Validation(Required=false)]
                    public string PMName { get; set; }

                }

            }

            /// <summary>
            /// The on-site construction company.
            /// </summary>
            [NameInMap("SI")]
            [Validation(Required=false)]
            public string SI { get; set; }

            /// <summary>
            /// The status of the LOA. Valid values:
            /// 
            /// *   **Applying**: The LOA is pending for approval.
            /// *   **Accept**: The LOA is approved.
            /// *   **Available**: The LOA is available.
            /// *   **Rejected**: The LOA is rejected.
            /// *   **Completing**: The Express Connect circuit is under construction.
            /// *   **Complete**: The Express Connect circuit is installed.
            /// *   **Deleted**: The LOA is deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
