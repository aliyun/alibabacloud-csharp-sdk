// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// The number of the resources. Default value: 1.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// The maximum public bandwidth. Unit: Mbit/s.
        /// 
        /// *   Valid values if the PayByTraffic parameter is set to PayByBandwidth: 10 to 1000
        /// *   Valid values if the PayByTraffic parameter is set to PayByTraffic: 10 to 200
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("BundleModels")]
        [Validation(Required=false)]
        public List<DescribePriceRequestBundleModels> BundleModels { get; set; }
        public class DescribePriceRequestBundleModels : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("RootDiskId")]
            [Validation(Required=false)]
            public string RootDiskId { get; set; }

            [NameInMap("UserDiskId")]
            [Validation(Required=false)]
            public string UserDiskId { get; set; }

        }

        [NameInMap("EduCdsEnable")]
        [Validation(Required=false)]
        public string EduCdsEnable { get; set; }

        [NameInMap("EduCdsSize")]
        [Validation(Required=false)]
        public int? EduCdsSize { get; set; }

        [NameInMap("EduCommittedTime")]
        [Validation(Required=false)]
        public int? EduCommittedTime { get; set; }

        [NameInMap("EduDesktopBundleId")]
        [Validation(Required=false)]
        public string EduDesktopBundleId { get; set; }

        [NameInMap("EduDesktopNum")]
        [Validation(Required=false)]
        public int? EduDesktopNum { get; set; }

        [NameInMap("EduRoomClassify")]
        [Validation(Required=false)]
        public string EduRoomClassify { get; set; }

        [NameInMap("EduStudentBundleId")]
        [Validation(Required=false)]
        public string EduStudentBundleId { get; set; }

        [NameInMap("EduStudentNum")]
        [Validation(Required=false)]
        public int? EduStudentNum { get; set; }

        [NameInMap("EduTeacherBundleId")]
        [Validation(Required=false)]
        public string EduTeacherBundleId { get; set; }

        [NameInMap("EduTeacherNum")]
        [Validation(Required=false)]
        public int? EduTeacherNum { get; set; }

        [NameInMap("GroupDesktopCount")]
        [Validation(Required=false)]
        public int? GroupDesktopCount { get; set; }

        /// <summary>
        /// The model of the WUYING hardware client.
        /// </summary>
        [NameInMap("HardwareVersion")]
        [Validation(Required=false)]
        public string HardwareVersion { get; set; }

        /// <summary>
        /// The resource specifications.
        /// 
        /// *   If you set ResourceType to Desktop, set this parameter to one of the following values:
        /// 
        ///     *   ecd.basic.small
        ///     *   ecd.basic.large
        ///     *   ecd.advanced.large
        ///     *   ecd.advanced.xlarge
        ///     *   ecd.performance.2xlarge
        ///     *   ecd.graphics.xlarge
        ///     *   ecd.graphics.2xlarge
        ///     *   ecd.advanced.xlarge_s8d2
        ///     *   ecd.advanced.xlarge_s8d7
        ///     *   ecd.graphics.1g72c
        ///     *   eds.general.2c2g
        ///     *   eds.general.2c4g
        ///     *   eds.general.2c8g
        ///     *   eds.general.4c8g
        ///     *   eds.general.4c16g
        ///     *   eds.general.8c16g
        ///     *   eds.general.8c32g
        ///     *   eds.general.16c32g
        /// 
        /// *   If you set ResourceType to OfficeSite, set this parameter to large.
        /// 
        /// *   If you set ResourceType to Bandwidth, leave this parameter empty.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The metering method of the Internet access package. Valid values:
        /// 
        /// *   PayByBandwidth: pay-by-bandwidth
        /// *   PayByTraffic: pay-by-data-transfer
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The OS. Valid values:
        /// 
        /// *   Windows
        /// *   Linux
        /// 
        /// Default value: Windows.
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("PackageSize")]
        [Validation(Required=false)]
        public int? PackageSize { get; set; }

        /// <summary>
        /// The subscription duration. Default value: 1.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the billing cycle. Valid values:
        /// 
        /// *   Hour
        /// *   Month
        /// *   Year
        /// 
        /// Default value: Hour.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The promotion ID.
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource type. Valid values:
        /// 
        /// *   Desktop: cloud desktop
        /// *   OfficeSite: workspace
        /// *   Bandwidth: network bandwidth
        /// 
        /// Default value: Desktop.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The performance level (PL) of the system disk. Valid values:
        /// 
        /// *   PL0
        /// *   PL1
        /// *   PL2
        /// *   PL3
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// The system disk size. Unit: GiB.
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        [NameInMap("SpPeriodInfo")]
        [Validation(Required=false)]
        public string SpPeriodInfo { get; set; }

        [NameInMap("SpPrice")]
        [Validation(Required=false)]
        public bool? SpPrice { get; set; }

        [NameInMap("SpType")]
        [Validation(Required=false)]
        public string SpType { get; set; }

        /// <summary>
        /// The PL of the data disk. Valid values:
        /// 
        /// *   PL0
        /// *   PL1
        /// *   PL2
        /// *   PL3
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        /// <summary>
        /// The data disk size. Unit: GiB.
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public int? UserDiskSizeGib { get; set; }

    }

}
