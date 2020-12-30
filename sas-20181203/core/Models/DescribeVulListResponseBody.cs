// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeVulListResponseBodyVulRecords : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("ModifyTs")]
            [Validation(Required=false)]
            public long? ModifyTs { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("ContainerImageId")]
            [Validation(Required=false)]
            public string ContainerImageId { get; set; }

            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }

            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            [NameInMap("K8sNodeId")]
            [Validation(Required=false)]
            public string K8sNodeId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("ContainerInnerPath")]
            [Validation(Required=false)]
            public string ContainerInnerPath { get; set; }

            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }
                [NameInMap("cveList")]
                [Validation(Required=false)]
                public List<string> CveList { get; set; }
                [NameInMap("PrimaryId")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }
                [NameInMap("OsRelease")]
                [Validation(Required=false)]
                public string OsRelease { get; set; }
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    public string FullVersion { get; set; }
                    public string Version { get; set; }
                    public string MatchDetail { get; set; }
                    public string Path { get; set; }
                    public string Name { get; set; }
                    public string UpdateCmd { get; set; }
                }
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }
                [NameInMap("LastTs")]
                [Validation(Required=false)]
                public long? LastTs { get; set; }
                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public DescribeVulListResponseBodyVulRecordsExtendContentJsonNecessity Necessity { get; set; }
                public class DescribeVulListResponseBodyVulRecordsExtendContentJsonNecessity : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Time_factor")]
                    [Validation(Required=false)]
                    public string TimeFactor { get; set; }

                    [NameInMap("Enviroment_factor")]
                    [Validation(Required=false)]
                    public string EnviromentFactor { get; set; }

                    [NameInMap("Is_calc")]
                    [Validation(Required=false)]
                    public string IsCalc { get; set; }

                    [NameInMap("Total_score")]
                    [Validation(Required=false)]
                    public string TotalScore { get; set; }

                    [NameInMap("Cvss_factor")]
                    [Validation(Required=false)]
                    public string CvssFactor { get; set; }

                    [NameInMap("Assets_factor")]
                    [Validation(Required=false)]
                    public string AssetsFactor { get; set; }

                }
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }
                [NameInMap("AbsolutePath")]
                [Validation(Required=false)]
                public string AbsolutePath { get; set; }
            };

            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public long? LastTs { get; set; }

            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public long? FirstTs { get; set; }

            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            [NameInMap("RepairTs")]
            [Validation(Required=false)]
            public long? RepairTs { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("K8sPodName")]
            [Validation(Required=false)]
            public string K8sPodName { get; set; }

            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            [NameInMap("K8sNamespace")]
            [Validation(Required=false)]
            public string K8sNamespace { get; set; }

            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("K8sNodeName")]
            [Validation(Required=false)]
            public string K8sNodeName { get; set; }

            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

    }

}
