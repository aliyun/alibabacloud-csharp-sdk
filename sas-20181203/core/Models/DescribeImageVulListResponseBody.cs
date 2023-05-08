// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageVulListResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned per page. Default value: **10**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
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

        /// <summary>
        /// The vulnerabilities.
        /// </summary>
        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeImageVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeImageVulListResponseBodyVulRecords : TeaModel {
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
            /// The ID of the container.
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// The extended information about the vulnerability.
            /// </summary>
            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeImageVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeImageVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
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
                /// The details of the packages of the software that has the vulnerability.
                /// </summary>
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeImageVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeImageVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    /// <summary>
                    /// The complete version number of the package.
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
                    /// The reason why the vulnerability is detected.
                    /// </summary>
                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    /// <summary>
                    /// The details of the rules that are used to detect the vulnerability.
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
                    /// The path to the software that has the vulnerability.
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
                    /// The version number of the package.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// The timestamp when the first scan was performed. Unit: milliseconds.
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
            /// The digest of the image.
            /// </summary>
            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            /// <summary>
            /// The name of the asset.
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
            /// The timestamp when the last scan was performed. Unit: milliseconds.
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
            /// *   **agentless**: agentless detection
            /// *   **image**: image
            /// *   **container**: container
            /// </summary>
            [NameInMap("MaliciousSource")]
            [Validation(Required=false)]
            public string MaliciousSource { get; set; }

            /// <summary>
            /// The timestamp when the information about the vulnerability was updated. Unit: milliseconds.
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
            /// *   **asap**: high. You must fix the vulnerability at the earliest opportunity.
            /// *   **later**: medium. You can fix the vulnerability based on your business requirements.
            /// *   **nntf**: low. You can ignore the vulnerability.
            /// </summary>
            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// The pod.
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// The ID of the vulnerability.
            /// </summary>
            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            /// <summary>
            /// The Common Vulnerabilities and Exposures (CVE) ID of the associated vulnerability.
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
            /// The time at which the scan was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            /// <summary>
            /// The status of the vulnerability. Valid values:
            /// 
            /// *   **1**: unfixed
            /// *   **7**: fixed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The tag that is added to the vulnerability.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The ID of the asset on which the vulnerability is detected.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the asset on which the vulnerability is detected.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The type of the asset on which the vulnerability is detected. Valid values:
            /// 
            /// *   **ECS_IMAGE**: image
            /// *   **ECS_SNAPSHOT**: snapshot
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The type of the vulnerability. The value is fixed as cve, which indicates image vulnerabilities.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
