// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUninstallAegisMachinesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of the information about servers.
        /// </summary>
        [NameInMap("MachineList")]
        [Validation(Required=false)]
        public List<ListUninstallAegisMachinesResponseBodyMachineList> MachineList { get; set; }
        public class ListUninstallAegisMachinesResponseBodyMachineList : TeaModel {
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
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The region in which the server resides.
            /// </summary>
            [NameInMap("MachineRegion")]
            [Validation(Required=false)]
            public string MachineRegion { get; set; }

            /// <summary>
            /// The operating system of the server. Valid values:
            /// 
            /// *   **linux**
            /// *   **windows**
            /// *   **windows-2003**
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The ID of the region in which the server resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The source of the server. Valid values:
            /// 
            /// *   **0**: an asset provided by Alibaba Cloud
            /// *   **1**: a third-party cloud server
            /// *   **2**: a server in a data center
            /// *   **3**, **4**, **5**, and **7**: other cloud asset
            /// *   **8**: a lightweight asset
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

            /// <summary>
            /// The name of the service provider (SP) for the server.
            /// 
            /// Valid values:
            /// 
            /// *   **ALIYUN**: Alibaba Cloud
            /// *   **OUT**: a third-party service provider
            /// *   **IDC**: a data center
            /// *   **TENCENT**: Tencent Cloud
            /// *   **HUAWEICLOUD**: Huawei Cloud
            /// *   **Microsoft**: Microsoft
            /// *   **AWS**: Amazon Web Services (AWS)
            /// *   **TRIPARTITE**: a lightweight server
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
