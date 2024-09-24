// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageVulListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: <b>10</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6B20156-49B0-5CF0-B14D-7ECA4B50DAAB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The vulnerabilities.</para>
        /// </summary>
        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeImageVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeImageVulListResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// <para>The alias of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2018-25010:libwebp up to 1.0.0 ApplyFilter out-of-bounds read</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>Indicates whether the vulnerability can be fixed in the Security Center console. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>yes</b></description></item>
            /// <item><description><b>no</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("CanFix")]
            [Validation(Required=false)]
            public string CanFix { get; set; }

            /// <summary>
            /// <para>Indicates whether the packages of the software that has the vulnerability can be upgraded by using Security Center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanUpdate")]
            [Validation(Required=false)]
            public bool? CanUpdate { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c08d5fc1a329a4b88950a253d082f1****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docker-law</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The ID of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04d20e98c8e2c93b7b864372084320a15a58c8671e53c972ce3a71d9c163****</para>
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// <para>The extended information about the vulnerability.</para>
            /// </summary>
            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeImageVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeImageVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
                /// <summary>
                /// <para>The name of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>debian</para>
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// <para>The version of the operating system in the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.9</para>
                /// </summary>
                [NameInMap("OsRelease")]
                [Validation(Required=false)]
                public string OsRelease { get; set; }

                /// <summary>
                /// <para>The details of the packages of the software that has the vulnerability.</para>
                /// </summary>
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeImageVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeImageVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    /// <summary>
                    /// <para>The complete version number of the package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.3.3-4</para>
                    /// </summary>
                    [NameInMap("FullVersion")]
                    [Validation(Required=false)]
                    public string FullVersion { get; set; }

                    /// <summary>
                    /// <para>The SHA-256 value of the digest of the image layer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b1f5b9420803ad0657cf21566e3e20acc08581e7f22991249ef3aa80b8b1c587</para>
                    /// </summary>
                    [NameInMap("Layer")]
                    [Validation(Required=false)]
                    public string Layer { get; set; }

                    /// <summary>
                    /// <para>The reason why the vulnerability is detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>libseccomp2 version less than equals 2.3.3-4</para>
                    /// </summary>
                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    /// <summary>
                    /// <para>The details of the rules that are used to detect the vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;libseccomp2 version less than equals 2.3.3-4&quot;]</para>
                    /// </summary>
                    [NameInMap("MatchList")]
                    [Validation(Required=false)]
                    public List<string> MatchList { get; set; }

                    /// <summary>
                    /// <para>The name of the software package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>libseccomp2</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The path to the software that has the vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/lib64/libssh2.so.1</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The command that is used to fix the vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>apt-get update &amp;&amp; apt-get install libseccomp2  --only-upgrade</para>
                    /// </summary>
                    [NameInMap("UpdateCmd")]
                    [Validation(Required=false)]
                    public string UpdateCmd { get; set; }

                    /// <summary>
                    /// <para>The version number of the package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.3.3-4</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The timestamp when the first scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620752053000</para>
            /// </summary>
            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public long? FirstTs { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry.cn-wulanchabu.aliyuncs.com/sas_test/huxin-test-001:nuxeo6-conta****</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The digest of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8f0fbdb41d3d1ade4ffdf21558443f4c03342010563bb8c43ccc09594d507012</para>
            /// </summary>
            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testInstance</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.19.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The timestamp when the last scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631779996000</para>
            /// </summary>
            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public long? LastTs { get; set; }

            /// <summary>
            /// <para>The image layers.</para>
            /// </summary>
            [NameInMap("Layers")]
            [Validation(Required=false)]
            public List<string> Layers { get; set; }

            /// <summary>
            /// <para>The source of the malicious file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>agentless</b>: agentless detection</description></item>
            /// <item><description><b>image</b>: image</description></item>
            /// <item><description><b>container</b>: container</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agentless</para>
            /// </summary>
            [NameInMap("MaliciousSource")]
            [Validation(Required=false)]
            public string MaliciousSource { get; set; }

            /// <summary>
            /// <para>The timestamp when the information about the vulnerability was updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1580808765000</para>
            /// </summary>
            [NameInMap("ModifyTs")]
            [Validation(Required=false)]
            public long? ModifyTs { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>debian:10:CVE-2019-9893</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-002</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The priority to fix the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>asap</b>: high. You must fix the vulnerability at the earliest opportunity.</description></item>
            /// <item><description><b>later</b>: medium. You can fix the vulnerability based on your business requirements.</description></item>
            /// <item><description><b>nntf</b>: low. You can ignore the vulnerability.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>asap</para>
            /// </summary>
            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// <para>The pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22222-7xsqq</para>
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// <para>The ID of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>782661</para>
            /// </summary>
            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            /// <summary>
            /// <para>The Common Vulnerabilities and Exposures (CVE) ID of the associated vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2019-9893</para>
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varnish</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace to which the image repository belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The time at which the scan was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649814050000</para>
            /// </summary>
            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            /// <summary>
            /// <para>The status of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: unfixed</description></item>
            /// <item><description><b>7</b>: fixed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The tag that is added to the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oval</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The ID of the asset on which the vulnerability is detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp17m0pc0xprzbwo****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the asset on which the vulnerability is detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source-test-obj-XM0Ma</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The type of the asset on which the vulnerability is detected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_IMAGE</b>: image</description></item>
            /// <item><description><b>ECS_SNAPSHOT</b>: snapshot</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_IMAGE</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The type of the vulnerability. The value is fixed as cve, which indicates image vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0004a32a0305a7f6ab5ff9600d47****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
