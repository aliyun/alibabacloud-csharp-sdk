// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCanFixVulListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1408FDB3-46F4-513C-9918-FE7D356DF048</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the vulnerability.</para>
        /// </summary>
        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeCanFixVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeCanFixVulListResponseBodyVulRecords : TeaModel {
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
            /// <para>The cluster ID.</para>
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
            /// <para>The container ID.</para>
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
            public DescribeCanFixVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeCanFixVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
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
                /// <para>The RPM packages.</para>
                /// </summary>
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeCanFixVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeCanFixVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    /// <summary>
                    /// <para>The complete version number of the software package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3.10.0-693.2.2.el7</para>
                    /// </summary>
                    [NameInMap("FullVersion")]
                    [Validation(Required=false)]
                    public string FullVersion { get; set; }

                    /// <summary>
                    /// <para>The SHA-256 value of the digest of the image layer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b1f5b9420803ad0657cf21566e3e20acc08581e7f22991249ef3aa80b8b1****</para>
                    /// </summary>
                    [NameInMap("Layer")]
                    [Validation(Required=false)]
                    public string Layer { get; set; }

                    /// <summary>
                    /// <para>The information about the detected vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python-perf version less than 0:3.10.0-693.21.1.el7</para>
                    /// </summary>
                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    /// <summary>
                    /// <para>The rule that is used to detect the vulnerability.</para>
                    /// </summary>
                    [NameInMap("MatchList")]
                    [Validation(Required=false)]
                    public List<string> MatchList { get; set; }

                    /// <summary>
                    /// <para>The name of the software package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python-perf</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The path of the software that has the vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/lib64/python2.7/site-packages</para>
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
                    /// <para>The version number of the software package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3.10.0</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The timestamp generated when the vulnerability was first detected. Unit: milliseconds.</para>
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
            /// <para>The unique identifier of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8f0fbdb41d3d1ade4ffdf21558443f4c03342010563bb8c43ccc09594d50****</para>
            /// </summary>
            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// <para>The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testInstance</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.19.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the vulnerability was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620404763000</para>
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
            /// <item><description><b>agentless</b></description></item>
            /// <item><description><b>image</b></description></item>
            /// <item><description><b>container</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agentless</para>
            /// </summary>
            [NameInMap("MaliciousSource")]
            [Validation(Required=false)]
            public string MaliciousSource { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the vulnerability status was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620404763000</para>
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
            /// <item><description><b>asap</b>: high</description></item>
            /// <item><description><b>later</b>: medium</description></item>
            /// <item><description><b>nntf</b>: low</description></item>
            /// </list>
            /// <remarks>
            /// <para> We recommend that you fix high-level vulnerabilities as soon as possible.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>asap,later,nntf</para>
            /// </summary>
            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// <para>The name of the container group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22222-7xsqq</para>
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// <para>The vulnerability ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>782661</para>
            /// </summary>
            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            /// <summary>
            /// <para>The CVE IDs related to the vulnerability. Multiple CVE IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2017-7518,CVE-2017-12188</para>
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
            /// <para>3rdparty</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the scan task was performed. Unit: milliseconds.</para>
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
            /// <item><description><b>1</b>: The vulnerability is unfixed.</description></item>
            /// <item><description><b>4</b>: The vulnerability is being fixed.</description></item>
            /// <item><description><b>7</b>: The vulnerability is fixed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The tag that is added to the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The ID of the asset that is scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300269</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the asset that is scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source-test-obj-XM0Ma</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The type of the asset that is scanned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IMAGE</b></description></item>
            /// <item><description><b>ECS_IMAGE</b></description></item>
            /// <item><description><b>ECS_SNAPSHOT</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_IMAGE</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The type of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: system vulnerability</description></item>
            /// <item><description><b>sca</b>: application vulnerability</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The UUID of the container image.</para>
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
