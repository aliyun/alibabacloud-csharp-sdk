// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCanFixVulListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeCanFixVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeCanFixVulListResponseBodyVulRecords : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("CanFix")]
            [Validation(Required=false)]
            public string CanFix { get; set; }

            [NameInMap("CanUpdate")]
            [Validation(Required=false)]
            public bool? CanUpdate { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeCanFixVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeCanFixVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                [NameInMap("OsRelease")]
                [Validation(Required=false)]
                public string OsRelease { get; set; }

                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeCanFixVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeCanFixVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    [NameInMap("FullVersion")]
                    [Validation(Required=false)]
                    public string FullVersion { get; set; }

                    [NameInMap("Layer")]
                    [Validation(Required=false)]
                    public string Layer { get; set; }

                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    [NameInMap("MatchList")]
                    [Validation(Required=false)]
                    public List<string> MatchList { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("UpdateCmd")]
                    [Validation(Required=false)]
                    public string UpdateCmd { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public long? FirstTs { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public long? LastTs { get; set; }

            [NameInMap("Layers")]
            [Validation(Required=false)]
            public List<string> Layers { get; set; }

            [NameInMap("MaliciousSource")]
            [Validation(Required=false)]
            public string MaliciousSource { get; set; }

            [NameInMap("ModifyTs")]
            [Validation(Required=false)]
            public long? ModifyTs { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
