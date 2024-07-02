// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAndroidInstanceGroupsResponseBody : TeaModel {
        [NameInMap("InstanceGroupModel")]
        [Validation(Required=false)]
        public List<DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModel> InstanceGroupModel { get; set; }
        public class DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModel : TeaModel {
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            [NameInMap("ArchitectureType")]
            [Validation(Required=false)]
            public string ArchitectureType { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelDisks> Disks { get; set; }
            public class DescribeAndroidInstanceGroupsResponseBodyInstanceGroupModelDisks : TeaModel {
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("InstalledAppList")]
            [Validation(Required=false)]
            public string InstalledAppList { get; set; }

            [NameInMap("InstanceGroupId")]
            [Validation(Required=false)]
            public string InstanceGroupId { get; set; }

            [NameInMap("InstanceGroupName")]
            [Validation(Required=false)]
            public string InstanceGroupName { get; set; }

            [NameInMap("InstanceGroupSpec")]
            [Validation(Required=false)]
            public string InstanceGroupSpec { get; set; }

            [NameInMap("InstanceGroupSpecDescribe")]
            [Validation(Required=false)]
            public string InstanceGroupSpecDescribe { get; set; }

            [NameInMap("InstanceGroupStatus")]
            [Validation(Required=false)]
            public string InstanceGroupStatus { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            [NameInMap("NumberOfInstances")]
            [Validation(Required=false)]
            public string NumberOfInstances { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

            [NameInMap("SaleMode")]
            [Validation(Required=false)]
            public string SaleMode { get; set; }

            [NameInMap("SystemVersion")]
            [Validation(Required=false)]
            public string SystemVersion { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
