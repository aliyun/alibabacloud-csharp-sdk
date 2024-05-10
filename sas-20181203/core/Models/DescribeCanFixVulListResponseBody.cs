// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCanFixVulListResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the vulnerability.
        /// </summary>
        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeCanFixVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeCanFixVulListResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// The alias of the vulnerability.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// Indicates whether the vulnerability can be fixed in the Security Center console. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("CanFix")]
            [Validation(Required=false)]
            public string CanFix { get; set; }

            /// <summary>
            /// Indicates whether the packages of the software that has the vulnerability can be upgraded by using Security Center. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CanUpdate")]
            [Validation(Required=false)]
            public bool? CanUpdate { get; set; }

            /// <summary>
            /// The cluster ID.
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
            /// The container ID.
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// The extended information about the vulnerability.
            /// </summary>
            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeCanFixVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeCanFixVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
                /// <summary>
                /// The name of the operating system.
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// The version of the operating system in the image.
                /// </summary>
                [NameInMap("OsRelease")]
                [Validation(Required=false)]
                public string OsRelease { get; set; }

                /// <summary>
                /// The RPM packages.
                /// </summary>
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeCanFixVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeCanFixVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    /// <summary>
                    /// The complete version number of the software package.
                    /// </summary>
                    [NameInMap("FullVersion")]
                    [Validation(Required=false)]
                    public string FullVersion { get; set; }

                    /// <summary>
                    /// The SHA-256 value of the digest of the image layer.
                    /// </summary>
                    [NameInMap("Layer")]
                    [Validation(Required=false)]
                    public string Layer { get; set; }

                    /// <summary>
                    /// The information about the detected vulnerability.
                    /// </summary>
                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    /// <summary>
                    /// The rule that is used to detect the vulnerability.
                    /// </summary>
                    [NameInMap("MatchList")]
                    [Validation(Required=false)]
                    public List<string> MatchList { get; set; }

                    /// <summary>
                    /// The name of the software package.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The path of the software that has the vulnerability.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The command that is used to fix the vulnerability.
                    /// </summary>
                    [NameInMap("UpdateCmd")]
                    [Validation(Required=false)]
                    public string UpdateCmd { get; set; }

                    /// <summary>
                    /// The version number of the software package.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// The timestamp generated when the vulnerability was first detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public long? FirstTs { get; set; }

            /// <summary>
            /// The name of the image.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The unique identifier of the image.
            /// </summary>
            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            /// <summary>
            /// The name of the instance.
            /// 
            /// The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).
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
            /// The timestamp generated when the vulnerability was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public long? LastTs { get; set; }

            /// <summary>
            /// The image layers.
            /// </summary>
            [NameInMap("Layers")]
            [Validation(Required=false)]
            public List<string> Layers { get; set; }

            /// <summary>
            /// The source of the malicious file. Valid values:
            /// 
            /// *   **agentless**
            /// *   **image**
            /// *   **container**
            /// </summary>
            [NameInMap("MaliciousSource")]
            [Validation(Required=false)]
            public string MaliciousSource { get; set; }

            /// <summary>
            /// The timestamp generated when the vulnerability status was modified. Unit: milliseconds.
            /// </summary>
            [NameInMap("ModifyTs")]
            [Validation(Required=false)]
            public long? ModifyTs { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The priority to fix the vulnerability. Valid values:
            /// 
            /// *   **asap**: high
            /// *   **later**: medium
            /// *   **nntf**: low
            /// 
            /// >  We recommend that you fix high-level vulnerabilities as soon as possible.
            /// </summary>
            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// The name of the container group.
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// The vulnerability ID.
            /// </summary>
            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            /// <summary>
            /// The CVE IDs related to the vulnerability. Multiple CVE IDs are separated by commas (,).
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The namespace to which the image repository belongs.
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// The timestamp generated when the scan task was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            /// <summary>
            /// The status of the vulnerability. Valid values:
            /// 
            /// *   **1**: The vulnerability is unfixed.
            /// *   **4**: The vulnerability is being fixed.
            /// *   **7**: The vulnerability is fixed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The tag that is added to the image.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The ID of the asset that is scanned.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the asset that is scanned.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The type of the asset that is scanned. Valid values:
            /// 
            /// *   **IMAGE**
            /// *   **ECS_IMAGE**
            /// *   **ECS_SNAPSHOT**
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The type of the vulnerability. Valid values:
            /// 
            /// *   **cve**: system vulnerability
            /// *   **sca**: application vulnerability
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The UUID of the container image.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
