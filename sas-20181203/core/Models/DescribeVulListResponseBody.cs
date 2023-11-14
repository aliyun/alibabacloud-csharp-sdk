// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListResponseBody : TeaModel {
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
        /// The number of entries per page.
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
        /// The total number of vulnerabilities returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the vulnerability.
        /// </summary>
        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeVulListResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The edition of Security Center that is authorized to protect the asset. Valid values:
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
            public string AuthVersion { get; set; }

            /// <summary>
            /// Indicates whether Security Center is authorized to protect the asset. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// The extended information about the vulnerability.
            /// </summary>
            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
                /// <summary>
                /// The package path of the software that has the vulnerability.
                /// </summary>
                [NameInMap("AbsolutePath")]
                [Validation(Required=false)]
                public string AbsolutePath { get; set; }

                /// <summary>
                /// The name of the vulnerability.
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// The description of the vulnerability.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EmgProof")]
                [Validation(Required=false)]
                public string EmgProof { get; set; }

                /// <summary>
                /// The public IP address of the asset that is associated with the vulnerability.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The timestamp that was generated when the vulnerability was last detected. Unit: milliseconds.
                /// </summary>
                [NameInMap("LastTs")]
                [Validation(Required=false)]
                public long? LastTs { get; set; }

                /// <summary>
                /// Indicates whether the vulnerability needs to be fixed.
                /// </summary>
                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public DescribeVulListResponseBodyVulRecordsExtendContentJsonNecessity Necessity { get; set; }
                public class DescribeVulListResponseBodyVulRecordsExtendContentJsonNecessity : TeaModel {
                    /// <summary>
                    /// The asset importance score. Valid values:
                    /// 
                    /// *   **2**: important asset
                    /// *   **1**: common asset
                    /// *   **0**: test asset
                    /// </summary>
                    [NameInMap("Assets_factor")]
                    [Validation(Required=false)]
                    public string AssetsFactor { get; set; }

                    /// <summary>
                    /// The Common Vulnerability Scoring System (CVSS) score.
                    /// </summary>
                    [NameInMap("Cvss_factor")]
                    [Validation(Required=false)]
                    public string CvssFactor { get; set; }

                    /// <summary>
                    /// The environment score.
                    /// </summary>
                    [NameInMap("Enviroment_factor")]
                    [Validation(Required=false)]
                    public string EnviromentFactor { get; set; }

                    /// <summary>
                    /// Indicates whether the score of urgency to fix a vulnerability is calculated. Valid values:
                    /// 
                    /// *   **0**: The score is not calculated.
                    /// *   **1**: The score is calculated.
                    /// </summary>
                    [NameInMap("Is_calc")]
                    [Validation(Required=false)]
                    public string IsCalc { get; set; }

                    /// <summary>
                    /// The status of the score of urgency to fix a vulnerability. Valid values:
                    /// 
                    /// *   **none**: No score is generated.
                    /// *   **pending**: The score is to be calculated.
                    /// *   **normal**: The calculation is normal.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The time score.
                    /// </summary>
                    [NameInMap("Time_factor")]
                    [Validation(Required=false)]
                    public string TimeFactor { get; set; }

                    /// <summary>
                    /// The score of urgency to fix a vulnerability.
                    /// 
                    /// The fixing suggestions vary based on the score of urgency of a vulnerability.
                    /// 
                    /// *   **\[13.5,15]**: The vulnerability is a high-risk vulnerability. You must fix the vulnerability at the earliest opportunity.
                    /// *   **\[7,13.5)**: The vulnerability is a medium-risk vulnerability. You can fix the vulnerability at your convenience.
                    /// *   **\[0,7)**: The vulnerability is a low-risk vulnerability. You can ignore the vulnerability.
                    /// </summary>
                    [NameInMap("Total_score")]
                    [Validation(Required=false)]
                    public string TotalScore { get; set; }

                }

                /// <summary>
                /// The name of the operating system.
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// The information about the operating system version.
                /// </summary>
                [NameInMap("OsRelease")]
                [Validation(Required=false)]
                public string OsRelease { get; set; }

                /// <summary>
                /// The vulnerability ID.
                /// </summary>
                [NameInMap("PrimaryId")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// The information about RPM Package Manager (RPM) packages.
                /// </summary>
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    /// <summary>
                    /// The name of the container.
                    /// </summary>
                    [NameInMap("ContainerName")]
                    [Validation(Required=false)]
                    public string ContainerName { get; set; }

                    /// <summary>
                    /// The full version number.
                    /// </summary>
                    [NameInMap("FullVersion")]
                    [Validation(Required=false)]
                    public string FullVersion { get; set; }

                    /// <summary>
                    /// The name of the image.
                    /// </summary>
                    [NameInMap("ImageName")]
                    [Validation(Required=false)]
                    public string ImageName { get; set; }

                    /// <summary>
                    /// The reason why the vulnerability is detected.
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
                    /// The name of the RPM package.
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
                    /// The process ID.
                    /// </summary>
                    [NameInMap("Pid")]
                    [Validation(Required=false)]
                    public string Pid { get; set; }

                    /// <summary>
                    /// The command that is used to fix the vulnerability.
                    /// </summary>
                    [NameInMap("UpdateCmd")]
                    [Validation(Required=false)]
                    public string UpdateCmd { get; set; }

                    /// <summary>
                    /// The package version number of the software that has the vulnerability.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// The status of the vulnerability. Valid values:
                /// 
                /// *   **1**: The vulnerability is unfixed.
                /// *   **2**: The vulnerability failed to be fixed.
                /// *   3: The system failed to be rolled back.
                /// *   **4**: The vulnerability is being fixed.
                /// *   **5**: The system is being rolled back.
                /// *   **6**: The vulnerability is being verified.
                /// *   **7**: The vulnerability is fixed.
                /// *   **8**: The vulnerability is fixed and the system is to be restarted.
                /// *   **9**: The system is rolled back.
                /// *   **10**: The vulnerability is ignored.
                /// *   **11**: The system is rolled back and is to be restarted.
                /// *   **12**: The vulnerability is not found.
                /// *   **20**: The vulnerability expires.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tag of the vulnerability.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// The CVE.
                /// </summary>
                [NameInMap("cveList")]
                [Validation(Required=false)]
                public List<string> CveList { get; set; }

            }

            /// <summary>
            /// The timestamp that was generated when the vulnerability was first detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public long? FirstTs { get; set; }

            /// <summary>
            /// The ID of the asset group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// The instance ID of the asset.
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
            /// The timestamp that was generated when the vulnerability was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public long? LastTs { get; set; }

            /// <summary>
            /// The timestamp that was generated when the vulnerability status was modified. Unit: milliseconds.
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
            /// The priority to fix the vulnerability. Valid values:
            /// 
            /// *   **asap**: high
            /// *   **later**: medium
            /// *   **nntf**: low
            /// 
            /// >  We recommend that you fix **high-level** vulnerabilities as soon as possible.
            /// </summary>
            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// Indicates whether the Security Center agent of the asset is online. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// The name of the operating system of your asset.
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// The name of the operating system of your asset.
            /// </summary>
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// The vulnerability ID.
            /// </summary>
            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            /// <summary>
            /// Indicates whether the runtime application self-protection (RASP) feature is supported. Valid values:
            /// 
            /// *   **0**: TheRASP feature is not supported.
            /// *   **1**: The RASP feature is supported
            /// 
            /// >  If this parameter is not returned, the RASP is not supported.
            /// </summary>
            [NameInMap("RaspDefend")]
            [Validation(Required=false)]
            public int? RaspDefend { get; set; }

            /// <summary>
            /// The protection mode of the RASP feature. Valid values:
            /// 
            /// *   **0**: The RASP feature is not supported.
            /// *   **1**: The RASP feature is in Monitor mode.
            /// *   **2**: The RASP feature is in Block mode.
            /// *   **3**: The RASP feature is disabled.
            /// </summary>
            [NameInMap("RaspStatus")]
            [Validation(Required=false)]
            public int? RaspStatus { get; set; }

            /// <summary>
            /// The ID of the region in which the instance resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The Common Vulnerabilities and Exposures (CVE) IDs related to the vulnerability. Multiple CVE IDs are separated by commas (,).
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// The timestamp that was generated when the vulnerability was fixed. Unit: milliseconds.
            /// </summary>
            [NameInMap("RepairTs")]
            [Validation(Required=false)]
            public long? RepairTs { get; set; }

            /// <summary>
            /// The code that indicates the fixing result of the vulnerability.
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// The message that indicates the fixing result of the vulnerability.
            /// </summary>
            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            /// <summary>
            /// The status of the vulnerability. Valid values:
            /// 
            /// *   **1**: The vulnerability is unfixed.
            /// *   **2**: The vulnerability failed to be fixed.
            /// *   **3**: The system failed to be rolled back.
            /// *   **4**: The vulnerability is being fixed.
            /// *   **5**: The system is being rolled back.
            /// *   **6**: The vulnerability is being verified.
            /// *   **7**: The vulnerability is fixed.
            /// *   **8**: The vulnerability is fixed and the system is to be restarted.
            /// *   **9**: The system is rolled back.
            /// *   **10**: The vulnerability is ignored.
            /// *   **11**: The system is rolled back and is to be restarted.
            /// *   **12**: The vulnerability is not found.
            /// *   **20**: The vulnerability expires.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The tag of the vulnerability.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The type of the vulnerability. Valid values:
            /// 
            /// *   **cve**: Linux software vulnerability
            /// *   **sys**: Windows system vulnerability
            /// *   **cms**: Web-CMS vulnerability
            /// *   **emg**: urgent vulnerability
            /// *   **app**: application vulnerability
            /// *   **sca**: application vulnerability that is detected by using Software Component Analysis (SCA).
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The instance UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
