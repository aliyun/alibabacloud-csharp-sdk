// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudCenterInstancesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details about the asset.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeCloudCenterInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeCloudCenterInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// Indicates whether alerts are generated on the asset. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The type of the asset. Valid values:
            /// 
            /// *   **0**: an ECS instance
            /// *   **1**: a Server Load Balancer (SLB) instance
            /// *   **2**: a Network Address Translation (NAT) gateway
            /// *   **3**: an ApsaraDB RDS instance
            /// *   **4**: an ApsaraDB for MongoDB instance
            /// *   **5**: an ApsaraDB for Redis instance
            /// *   **6**: a container image
            /// *   **7**: a container
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            [NameInMap("AssetTypeName")]
            [Validation(Required=false)]
            public string AssetTypeName { get; set; }

            /// <summary>
            /// The timestamp when Security Center is authorized to scan the asset.
            /// </summary>
            [NameInMap("AuthModifyTime")]
            [Validation(Required=false)]
            public long? AuthModifyTime { get; set; }

            /// <summary>
            /// The edition of Security Center that is authorized to scan the asset. Valid values:
            /// 
            /// *   **1**: Basic edition
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
            /// The name of the Security Center edition that is authorized to scan the asset. Valid values:
            /// 
            /// *   Basic edition
            /// *   Anti-virus edition
            /// *   Advanced edition
            /// *   Enterprise edition
            /// *   Ultimate edition
            /// *   Value-added Plan edition
            /// </summary>
            [NameInMap("AuthVersionName")]
            [Validation(Required=false)]
            public string AuthVersionName { get; set; }

            /// <summary>
            /// Indicates whether Security Center is authorized to scan the asset. Valid values:
            /// 
            /// *   **true**: Security Center is authorized to scan the asset.
            /// *   **false**: Security Center is not authorized to scan the asset.
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// The status of the Security Center agent installed on the asset. Valid values:
            /// 
            /// *   **online**: The Security Center agent is **enabled**.
            /// *   **offline**: The Security Center agent is **disabled**.
            /// *   **pause**: The Security Center agent is **suspended**.
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The number of the CPU cores used by the asset.
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            /// <summary>
            /// The CPU information about the asset.
            /// </summary>
            [NameInMap("CpuInfo")]
            [Validation(Required=false)]
            public string CpuInfo { get; set; }

            /// <summary>
            /// The timestamp when the cluster was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// Indicates whether the asset is exposed. Valid values:
            /// 
            /// *   **0**: The asset is not exposed.
            /// *   **1**: The asset is exposed.
            /// </summary>
            [NameInMap("ExposedStatus")]
            [Validation(Required=false)]
            public int? ExposedStatus { get; set; }

            /// <summary>
            /// Indicates whether the asset is an Alibaba Cloud asset. Valid values:
            /// 
            /// *   **0**: The asset is an Alibaba Cloud asset.
            /// *   **1**: The asset is not an Alibaba Cloud asset.
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            [NameInMap("FlagName")]
            [Validation(Required=false)]
            public string FlagName { get; set; }

            /// <summary>
            /// The ID of the asset group to which the asset belongs.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// The name of the group to which the asset belongs.
            /// </summary>
            [NameInMap("GroupTrace")]
            [Validation(Required=false)]
            public string GroupTrace { get; set; }

            /// <summary>
            /// Indicates whether baseline risks are detected on the asset. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("HcStatus")]
            [Validation(Required=false)]
            public string HcStatus { get; set; }

            /// <summary>
            /// The number of baseline risks that are detected on the asset.
            /// </summary>
            [NameInMap("HealthCheckCount")]
            [Validation(Required=false)]
            public int? HealthCheckCount { get; set; }

            /// <summary>
            /// The importance of the asset. Valid values:
            /// 
            /// *   **2**: an important asset
            /// *   **1**: a common asset
            /// *   **0**: a test asset
            /// </summary>
            [NameInMap("Importance")]
            [Validation(Required=false)]
            public int? Importance { get; set; }

            /// <summary>
            /// The ID of the asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the asset.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the asset.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The public IP address of the asset.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The IP addresses of the system.
            /// </summary>
            [NameInMap("IpListString")]
            [Validation(Required=false)]
            public string IpListString { get; set; }

            /// <summary>
            /// The version of the kernel.
            /// </summary>
            [NameInMap("Kernel")]
            [Validation(Required=false)]
            public string Kernel { get; set; }

            /// <summary>
            /// The timestamp when the Security Center agent was last online. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastLoginTimestamp")]
            [Validation(Required=false)]
            public long? LastLoginTimestamp { get; set; }

            /// <summary>
            /// The MAC addresses of the system.
            /// </summary>
            [NameInMap("MacListString")]
            [Validation(Required=false)]
            public string MacListString { get; set; }

            /// <summary>
            /// The size of the memory. Unit: MB.
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// The operating system of the asset.
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The kernel version of the asset.
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// The number of pods.
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public int? PodCount { get; set; }

            /// <summary>
            /// The region ID of the asset.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The ID of the region in which the asset resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the region in which the asset resides.
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// The total number of baseline risks that are detected on the asset. The value of this parameter is in the JSON format and contains the following fields:
            /// 
            /// *   **account**: the number of accounts that are used to log on from unapproved logon locations and whose passwords are cracked
            /// *   **appNum**: the number of scanners
            /// *   **asapVulCount**: the total number of high-severity vulnerabilities
            /// *   **baselineHigh**: the number of high-risk baseline risks
            /// *   **baselineLow**: the number of low-risk baseline risks
            /// *   **baselineMedium**: the number of medium-risk baseline risks
            /// *   **baselineNum**: the total number of baseline risks
            /// *   **cmsNum**: the number of Web-CMS vulnerabilities
            /// *   **containerAsap**: the number of high-severity vulnerabilities that are detected on containers
            /// *   **containerLater**: the number of medium-severity vulnerabilities that are detected on containers
            /// *   **containerNntf**: the number of low-severity vulnerabilities that are detected on containers
            /// *   **containerRemind**: the number of alerts whose Emergency level is Reminder on containers
            /// *   **containerSerious**: the number of alerts Emergency level is Urgent on containers
            /// *   **containerSuspicious**: the number of alerts whose Emergency level is Suspicious on containers
            /// *   **cveNum**: the number of Linux software vulnerabilities
            /// *   **emgNum**: the number of urgent vulnerabilities
            /// *   **health**: the number of baseline alerts that are unhandled
            /// *   **imageBaselineHigh**: the number of high-risk baseline risks that are detected on images
            /// *   **imageBaselineLow**: the number of low-risk baseline risks that are detected on images
            /// *   **imageBaselineMedium**: the number of medium-risk baseline risks that are detected on images
            /// *   **imageBaselineNum**: the total number of baseline risks that are detected on images
            /// *   **imageMaliciousFileRemind**: the number of malicious files that are detected on images and have the Emergency level of Reminder
            /// *   **imageMaliciousFileSerious**: the number of malicious files that are detected on images and have the Emergency level of Urgent
            /// *   **imageMaliciousFileSuspicious**: the number of malicious files that are detected on images and have the Emergency level of Suspicious
            /// *   **imageVulAsap**: the number of high-severity vulnerabilities that are detected on images
            /// *   **imageVulLater**: the number of medium-severity vulnerabilities that are detected on an image
            /// *   **imageVulNntf**: the number of low-severity vulnerabilities that are detected on an image
            /// *   **laterVulCount**: the number of medium-severity vulnerabilities
            /// *   **newSuspicious**: the number of alerts
            /// *   **nntfVulCount**: the number of low-severity vulnerabilities.
            /// *   **remindNum**: the number of alerts whose Emergency level is Reminder
            /// *   **scaNum**: the number of vulnerabilities that are detected based on software component analysis
            /// *   **seriousNum**: the number of alerts whose Emergency level is Urgent
            /// *   **suspNum**: the number of alerts whose Emergency level is Suspicious
            /// *   **suspicious**: the total number of alerts
            /// *   **sysNum**: the number of Windows system vulnerabilities
            /// *   **trojan**: the number of trojans
            /// *   **uuid**: the UUIDs of assets
            /// *   **vul**: the number of vulnerabilities
            /// *   **weakPWNum**: the number of weak passwords
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public string RiskCount { get; set; }

            /// <summary>
            /// Indicates whether risks are detected on the asset. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// The number of alerts that are generated on the asset.
            /// </summary>
            [NameInMap("SafeEventCount")]
            [Validation(Required=false)]
            public int? SafeEventCount { get; set; }

            /// <summary>
            /// The status of the asset. Valid values:
            /// 
            /// *   **Running**: running
            /// *   **notRunning**: stopped
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the asset tag.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The ID of the asset tag.
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The type of the asset by source. Valid values:
            /// 
            /// *   **0**: an ECS instance.
            /// *   **1**: a third-party cloud server.
            /// *   **2**: a server in a data center.
            /// *   **3**: a server deployed on Tencent Cloud. This value is returned only after the asset is protected by Security Center.
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

            /// <summary>
            /// The name of the service provider (SP) for the asset.
            /// 
            /// Valid values:
            /// 
            /// *   **TENCENT**: Tencent Cloud
            /// *   **ALIYUN**: Alibaba Cloud
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

            /// <summary>
            /// The ID of the VPC to which the asset belongs.
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// The number of vulnerabilities that are detected on the asset.
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

            /// <summary>
            /// Indicates whether vulnerabilities are detected on the asset. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("VulStatus")]
            [Validation(Required=false)]
            public string VulStatus { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCloudCenterInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCloudCenterInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
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
            /// The value of NextToken that is returned when the NextToken method is used.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
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

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   **true**: The call is successful.
        /// *   **false**: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
