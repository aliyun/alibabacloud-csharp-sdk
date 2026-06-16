// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeCloudCenterInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudCenterInstancesResponseBodyData Data { get; set; }
        public class DescribeCloudCenterInstancesResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public DescribeCloudCenterInstancesResponseBodyDataBody Body { get; set; }
            public class DescribeCloudCenterInstancesResponseBodyDataBody : TeaModel {
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public List<DescribeCloudCenterInstancesResponseBodyDataBodyInstances> Instances { get; set; }
                public class DescribeCloudCenterInstancesResponseBodyDataBodyInstances : TeaModel {
                    [NameInMap("AlarmStatus")]
                    [Validation(Required=false)]
                    public string AlarmStatus { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("AssetType")]
                    [Validation(Required=false)]
                    public string AssetType { get; set; }

                    [NameInMap("AssetTypeName")]
                    [Validation(Required=false)]
                    public string AssetTypeName { get; set; }

                    [NameInMap("AuthModifyTime")]
                    [Validation(Required=false)]
                    public long? AuthModifyTime { get; set; }

                    [NameInMap("AuthVersion")]
                    [Validation(Required=false)]
                    public int? AuthVersion { get; set; }

                    [NameInMap("AuthVersionName")]
                    [Validation(Required=false)]
                    public string AuthVersionName { get; set; }

                    [NameInMap("Bind")]
                    [Validation(Required=false)]
                    public bool? Bind { get; set; }

                    [NameInMap("BindFileProtectType")]
                    [Validation(Required=false)]
                    public string BindFileProtectType { get; set; }

                    [NameInMap("ClientStatus")]
                    [Validation(Required=false)]
                    public string ClientStatus { get; set; }

                    [NameInMap("ClientSubStatus")]
                    [Validation(Required=false)]
                    public string ClientSubStatus { get; set; }

                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public int? Cores { get; set; }

                    [NameInMap("CpuInfo")]
                    [Validation(Required=false)]
                    public string CpuInfo { get; set; }

                    [NameInMap("CreatedTime")]
                    [Validation(Required=false)]
                    public long? CreatedTime { get; set; }

                    [NameInMap("ExposedStatus")]
                    [Validation(Required=false)]
                    public int? ExposedStatus { get; set; }

                    [NameInMap("Flag")]
                    [Validation(Required=false)]
                    public int? Flag { get; set; }

                    [NameInMap("FlagName")]
                    [Validation(Required=false)]
                    public string FlagName { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public long? GroupId { get; set; }

                    [NameInMap("GroupTrace")]
                    [Validation(Required=false)]
                    public string GroupTrace { get; set; }

                    [NameInMap("HasContainer")]
                    [Validation(Required=false)]
                    public string HasContainer { get; set; }

                    [NameInMap("HcStatus")]
                    [Validation(Required=false)]
                    public string HcStatus { get; set; }

                    [NameInMap("HealthCheckCount")]
                    [Validation(Required=false)]
                    public int? HealthCheckCount { get; set; }

                    [NameInMap("Importance")]
                    [Validation(Required=false)]
                    public int? Importance { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    [NameInMap("InternetIp")]
                    [Validation(Required=false)]
                    public string InternetIp { get; set; }

                    [NameInMap("IntranetIp")]
                    [Validation(Required=false)]
                    public string IntranetIp { get; set; }

                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    [NameInMap("IpListString")]
                    [Validation(Required=false)]
                    public string IpListString { get; set; }

                    [NameInMap("Kernel")]
                    [Validation(Required=false)]
                    public string Kernel { get; set; }

                    [NameInMap("LastLoginTimestamp")]
                    [Validation(Required=false)]
                    public long? LastLoginTimestamp { get; set; }

                    [NameInMap("MacListString")]
                    [Validation(Required=false)]
                    public string MacListString { get; set; }

                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public string Mem { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("Os")]
                    [Validation(Required=false)]
                    public string Os { get; set; }

                    [NameInMap("OsName")]
                    [Validation(Required=false)]
                    public string OsName { get; set; }

                    [NameInMap("PodCount")]
                    [Validation(Required=false)]
                    public int? PodCount { get; set; }

                    [NameInMap("PostPaidFlag")]
                    [Validation(Required=false)]
                    public int? PostPaidFlag { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("RegionName")]
                    [Validation(Required=false)]
                    public string RegionName { get; set; }

                    [NameInMap("RiskCount")]
                    [Validation(Required=false)]
                    public string RiskCount { get; set; }

                    [NameInMap("RiskStatus")]
                    [Validation(Required=false)]
                    public string RiskStatus { get; set; }

                    [NameInMap("SafeEventCount")]
                    [Validation(Required=false)]
                    public string SafeEventCount { get; set; }

                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("TagId")]
                    [Validation(Required=false)]
                    public string TagId { get; set; }

                    [NameInMap("TagResources")]
                    [Validation(Required=false)]
                    public string TagResources { get; set; }

                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    [NameInMap("Vendor")]
                    [Validation(Required=false)]
                    public int? Vendor { get; set; }

                    [NameInMap("VendorName")]
                    [Validation(Required=false)]
                    public string VendorName { get; set; }

                    [NameInMap("VendorUid")]
                    [Validation(Required=false)]
                    public string VendorUid { get; set; }

                    [NameInMap("VendorUserName")]
                    [Validation(Required=false)]
                    public string VendorUserName { get; set; }

                    [NameInMap("VpcInstanceId")]
                    [Validation(Required=false)]
                    public string VpcInstanceId { get; set; }

                    [NameInMap("VulCount")]
                    [Validation(Required=false)]
                    public int? VulCount { get; set; }

                    [NameInMap("VulStatus")]
                    [Validation(Required=false)]
                    public string VulStatus { get; set; }

                }

                [NameInMap("PageInfo")]
                [Validation(Required=false)]
                public DescribeCloudCenterInstancesResponseBodyDataBodyPageInfo PageInfo { get; set; }
                public class DescribeCloudCenterInstancesResponseBodyDataBodyPageInfo : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("CurrentPage")]
                    [Validation(Required=false)]
                    public int? CurrentPage { get; set; }

                    [NameInMap("NextToken")]
                    [Validation(Required=false)]
                    public string NextToken { get; set; }

                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
