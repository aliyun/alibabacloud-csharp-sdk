// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningMachineResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of the servers on which the alerts are generated.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListCheckItemWarningMachineResponseBodyList> List { get; set; }
        public class ListCheckItemWarningMachineResponseBodyList : TeaModel {
            /// <summary>
            /// The edition of Security Center that is authorized to protect the asset. Valid values:
            /// 
            /// *   **1**: Basic edition (Unauthorized)
            /// *   **6**: Anti-virus edition
            /// *   **5**: Advanced edition
            /// *   **3**: Enterprise edition
            /// *   **7**: Ultimate edition
            /// *   **10**: Value-added Plan edition
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// Indicates whether Security Center is authorized to scan the asset. Valid values:
            /// 
            /// *   **true**: Security Center is authorized to scan the asset.
            /// *   **false**: Security Center is not authorized to scan the asset.
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// An array consisting of the details about the baselines for which the risk item can be fixed.
            /// </summary>
            [NameInMap("FixList")]
            [Validation(Required=false)]
            public List<ListCheckItemWarningMachineResponseBodyListFixList> FixList { get; set; }
            public class ListCheckItemWarningMachineResponseBodyListFixList : TeaModel {
                /// <summary>
                /// The ID of the baseline.
                /// </summary>
                [NameInMap("RiskId")]
                [Validation(Required=false)]
                public long? RiskId { get; set; }

                /// <summary>
                /// The name of the baseline.
                /// </summary>
                [NameInMap("RiskName")]
                [Validation(Required=false)]
                public string RiskName { get; set; }

            }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the affected asset.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the affected asset.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// Indicates whether a port on the server is accessible over the Internet. Valid values:
            /// 
            /// *   **true**: A port on the server is accessible over the Internet.
            /// *   **false**: No ports on the server are accessible over the Internet.
            /// </summary>
            [NameInMap("PortOpen")]
            [Validation(Required=false)]
            public bool? PortOpen { get; set; }

            /// <summary>
            /// The prompt for the risk item.
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// The region ID of the asset.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the check item.
            /// 
            /// > Valid values:
            /// 
            /// *   1: failed
            /// 
            /// *   2: verifying
            /// 
            /// *   3: passed
            /// 
            /// *   6: ignored
            /// 
            /// *   7: fixing
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// An array consisting of the details about the baselines based on which the risk item is detected.
            /// </summary>
            [NameInMap("WarningRiskList")]
            [Validation(Required=false)]
            public List<ListCheckItemWarningMachineResponseBodyListWarningRiskList> WarningRiskList { get; set; }
            public class ListCheckItemWarningMachineResponseBodyListWarningRiskList : TeaModel {
                /// <summary>
                /// The ID of the baseline.
                /// </summary>
                [NameInMap("RiskId")]
                [Validation(Required=false)]
                public long? RiskId { get; set; }

                /// <summary>
                /// The name of the baseline.
                /// </summary>
                [NameInMap("RiskName")]
                [Validation(Required=false)]
                public string RiskName { get; set; }

            }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemWarningMachineResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemWarningMachineResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of affected assets returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of affected assets.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
