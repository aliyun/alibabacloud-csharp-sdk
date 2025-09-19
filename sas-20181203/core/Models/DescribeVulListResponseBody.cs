// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListResponseBody : TeaModel {
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
        /// <para>The value of NextToken that is returned when the NextToken method is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E17B501887A2D3AA5E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F26AB2A-1075-488F-8472-40E5DB486ACC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of vulnerabilities returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information about the vulnerability.</para>
        /// </summary>
        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeVulListResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RHSA-2019:0230-Important: polkit security update</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The edition of Security Center that is authorized to scan the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic.</description></item>
            /// <item><description><b>6</b>: Anti-virus.</description></item>
            /// <item><description><b>5</b>: Advanced.</description></item>
            /// <item><description><b>3</b>: Enterprise.</description></item>
            /// <item><description><b>7</b>: Ultimate.</description></item>
            /// <item><description><b>10</b>: Value-added Plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public string AuthVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether Security Center is authorized to scan the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// <para>The extended information about the vulnerability.</para>
            /// </summary>
            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
                /// <summary>
                /// <para>The path to the package of the software that has the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/roo/www/web</para>
                /// </summary>
                [NameInMap("AbsolutePath")]
                [Validation(Required=false)]
                public string AbsolutePath { get; set; }

                /// <summary>
                /// <para>The name of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RHSA-2019:0230-Important: polkit security update</para>
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// <para>The description of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel version:5.10.84-10.2.al8.x86_64</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The returned message that indicates the urgent vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.xxl.rpc.util.XxlRpcException: xxl-rpc request data is empty.\n\tat com.xxl.rpc.remoting.net.impl.servlet.serve&quot;</para>
                /// </summary>
                [NameInMap("EmgProof")]
                [Validation(Required=false)]
                public string EmgProof { get; set; }

                /// <summary>
                /// <para>The public IP address of the asset that is associated with the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The timestamp when the vulnerability was last detected. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620404763000</para>
                /// </summary>
                [NameInMap("LastTs")]
                [Validation(Required=false)]
                public long? LastTs { get; set; }

                /// <summary>
                /// <para>Indicates whether the vulnerability needs to be fixed.</para>
                /// </summary>
                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public DescribeVulListResponseBodyVulRecordsExtendContentJsonNecessity Necessity { get; set; }
                public class DescribeVulListResponseBodyVulRecordsExtendContentJsonNecessity : TeaModel {
                    /// <summary>
                    /// <para>The asset importance score. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>2</b>: important asset.</description></item>
                    /// <item><description><b>1</b>: common asset.</description></item>
                    /// <item><description><b>0</b>: test asset.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Assets_factor")]
                    [Validation(Required=false)]
                    public string AssetsFactor { get; set; }

                    /// <summary>
                    /// <para>The Common Vulnerability Scoring System (CVSS) score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7.8</para>
                    /// </summary>
                    [NameInMap("Cvss_factor")]
                    [Validation(Required=false)]
                    public string CvssFactor { get; set; }

                    /// <summary>
                    /// <para>The environment score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("Enviroment_factor")]
                    [Validation(Required=false)]
                    public string EnviromentFactor { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the vulnerability priority score is calculated. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: no.</description></item>
                    /// <item><description><b>1</b>: yes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Is_calc")]
                    [Validation(Required=false)]
                    public string IsCalc { get; set; }

                    /// <summary>
                    /// <para>The status of the vulnerability priority score. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>none</b>: No score is generated.</description></item>
                    /// <item><description><b>pending</b>: The score is pending calculation.</description></item>
                    /// <item><description><b>normal</b>: The calculation is normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The time score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("Time_factor")]
                    [Validation(Required=false)]
                    public string TimeFactor { get; set; }

                    /// <summary>
                    /// <para>The vulnerability priority score.</para>
                    /// <para>The following list describes scores and related fixing suggestions:</para>
                    /// <list type="bullet">
                    /// <item><description>If the score is from <b>13.5 to 15</b>, the vulnerability is a high-risk vulnerability. You must fix the vulnerability at the earliest opportunity.</description></item>
                    /// <item><description>If the score is <b>greater than or equal to 7 but less than 13.5</b>, the vulnerability is a medium-risk vulnerability. You can fix the vulnerability at your convenience.</description></item>
                    /// <item><description>If the score is <b>less than 7</b>, the vulnerability is a low-risk vulnerability. You can ignore the vulnerability.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7.8</para>
                    /// </summary>
                    [NameInMap("Total_score")]
                    [Validation(Required=false)]
                    public string TotalScore { get; set; }

                }

                /// <summary>
                /// <para>The name of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos</para>
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// <para>The information about the operating system version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("OsRelease")]
                [Validation(Required=false)]
                public string OsRelease { get; set; }

                /// <summary>
                /// <para>The ID of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("PrimaryId")]
                [Validation(Required=false)]
                public long? PrimaryId { get; set; }

                /// <summary>
                /// <para>The information about RPM Package Manager (RPM) packages.</para>
                /// </summary>
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    /// <summary>
                    /// <para>The name of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>k8s_67895c4_xxx</para>
                    /// </summary>
                    [NameInMap("ContainerName")]
                    [Validation(Required=false)]
                    public string ContainerName { get; set; }

                    /// <summary>
                    /// <para>The extended information about the software package that has the vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;msg_no_lookups_configured_CVE_2021_44228&quot;: &quot;false&quot;, &quot;jndi_class_not_exist&quot;: &quot;false&quot;}</para>
                    /// </summary>
                    [NameInMap("ExtendField")]
                    [Validation(Required=false)]
                    public string ExtendField { get; set; }

                    /// <summary>
                    /// <para>The complete version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3.10.0-693.2.2.el7</para>
                    /// </summary>
                    [NameInMap("FullVersion")]
                    [Validation(Required=false)]
                    public string FullVersion { get; set; }

                    /// <summary>
                    /// <para>The name of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry_387ytb_xxx</para>
                    /// </summary>
                    [NameInMap("ImageName")]
                    [Validation(Required=false)]
                    public string ImageName { get; set; }

                    /// <summary>
                    /// <para>The reason why the vulnerability is detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python-perf version less than 0:3.10.0-693.21.1.el7</para>
                    /// </summary>
                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    /// <summary>
                    /// <para>The rules that are used to detect the vulnerability.</para>
                    /// </summary>
                    [NameInMap("MatchList")]
                    [Validation(Required=false)]
                    public List<string> MatchList { get; set; }

                    /// <summary>
                    /// <para>The name of the RPM package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python-perf</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The path to the software that has the vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/lib64/python2.7/site-packages</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The process ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8664</para>
                    /// </summary>
                    [NameInMap("Pid")]
                    [Validation(Required=false)]
                    public string Pid { get; set; }

                    /// <summary>
                    /// <para>The command that is used to fix the vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>*** update python-perf</para>
                    /// </summary>
                    [NameInMap("UpdateCmd")]
                    [Validation(Required=false)]
                    public string UpdateCmd { get; set; }

                    /// <summary>
                    /// <para>The version number of the package of the software that has the vulnerability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3.10.0</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The status of the vulnerability. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: unfixed.</description></item>
                /// <item><description><b>2</b>: fix failed.</description></item>
                /// <item><description>3: rollback failed.</description></item>
                /// <item><description><b>4</b>: being fixed.</description></item>
                /// <item><description><b>5</b>: being rolled back.</description></item>
                /// <item><description><b>6</b>: being verified.</description></item>
                /// <item><description><b>7</b>: fixed.</description></item>
                /// <item><description><b>8</b>: fixed and to be restarted.</description></item>
                /// <item><description><b>9</b>: rolled back.</description></item>
                /// <item><description><b>10</b>: ignored.</description></item>
                /// <item><description><b>11</b>: rolled back and to be restarted.</description></item>
                /// <item><description><b>12</b>: not found.</description></item>
                /// <item><description><b>20</b>: expired.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
                /// <para>The URL of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://39.99.XX.XX:30005/toLogin">http://39.99.XX.XX:30005/toLogin</a></para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The CVE list.</para>
                /// </summary>
                [NameInMap("cveList")]
                [Validation(Required=false)]
                public List<string> CveList { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the vulnerability was first detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554189334000</para>
            /// </summary>
            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public long? FirstTs { get; set; }

            /// <summary>
            /// <para>The ID of the asset group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>281801</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-cn-<b>-vpc.ack.</b>.com/acs/ack-node-problem-detector:v0.8.16-8ed7053-**</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp18t***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

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
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// <remarks>
            /// <para> The value of this parameter is returned only if you use the Ultimate edition of Security Center that can protect container assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>c863dc93bed3843de9934d4346dc4****</para>
            /// </summary>
            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// <remarks>
            /// <para> If you use the Ultimate edition of Security Center, the value of this parameter is queried from container assets. If you do not use the Ultimate edition, the value of this parameter is queried from the Security Center agent.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("K8sNamespace")]
            [Validation(Required=false)]
            public string K8sNamespace { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// <remarks>
            /// <para> The value of this parameter is returned only if you use the Ultimate edition of Security Center that can protect container assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1ifm6suw9mnbsr****</para>
            /// </summary>
            [NameInMap("K8sNodeId")]
            [Validation(Required=false)]
            public string K8sNodeId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// <remarks>
            /// <para> The value of this parameter is returned only if you use the Ultimate edition of Security Center that can protect container assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>deployment-riskai-7b67d68975-m****</para>
            /// </summary>
            [NameInMap("K8sNodeName")]
            [Validation(Required=false)]
            public string K8sNodeName { get; set; }

            /// <summary>
            /// <para>The name of the pod.</para>
            /// <remarks>
            /// <para> The value of this parameter is returned only if you use the Ultimate edition of Security Center that can protect container assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>deployment-riskai-7b67d68975-m****</para>
            /// </summary>
            [NameInMap("K8sPodName")]
            [Validation(Required=false)]
            public string K8sPodName { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620404763000</para>
            /// </summary>
            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public long? LastTs { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability status was modified. Unit: milliseconds.</para>
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
            /// <para>oval:com.redhat.rhsa:def:20170574</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kube-system</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The priority to fix the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>asap</b>: high.</description></item>
            /// <item><description><b>later</b>: medium.</description></item>
            /// <item><description><b>nntf</b>: low.</description></item>
            /// </list>
            /// <remarks>
            /// <para> We recommend that you fix <b>high-risk</b> vulnerabilities at the earliest opportunity.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>asap</para>
            /// </summary>
            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            /// <summary>
            /// <para>Indicates whether the Security Center agent on the asset is online. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>The name of the operating system for your asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS 7.2 64-bit</para>
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>The name of the operating system for your asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// <para>The ID of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101162078</para>
            /// </summary>
            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            /// <summary>
            /// <para>The progress of the vulnerability fixing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>Indicates whether the application protection feature is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no.</description></item>
            /// <item><description><b>1</b>: yes.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If this parameter is not returned, the application protection feature is not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RaspDefend")]
            [Validation(Required=false)]
            public int? RaspDefend { get; set; }

            /// <summary>
            /// <para>The protection mode of the application protection feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unprotected.</description></item>
            /// <item><description><b>1</b>: the Monitor mode.</description></item>
            /// <item><description><b>2</b>: the Block mode.</description></item>
            /// <item><description><b>3</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RaspStatus")]
            [Validation(Required=false)]
            public int? RaspStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the vulnerability is easily exploited. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RealRisk")]
            [Validation(Required=false)]
            public bool? RealRisk { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The Common Vulnerabilities and Exposures (CVE) IDs related to the vulnerability. Multiple CVE IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2017-7518,CVE-2017-12188</para>
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability was fixed. Unit: milliseconds. This parameter is returned only if you fix vulnerabilities in the Security Center console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1541207563000</para>
            /// </summary>
            [NameInMap("RepairTs")]
            [Validation(Required=false)]
            public long? RepairTs { get; set; }

            /// <summary>
            /// <para>The code that indicates the vulnerability fixing result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// <para>The message that indicates the vulnerability fixing result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>timeout</para>
            /// </summary>
            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            /// <summary>
            /// <para>The tag of this vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AI</b>: AI-related components.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("RuleTag")]
            [Validation(Required=false)]
            public string RuleTag { get; set; }

            /// <summary>
            /// <para>The status of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: unfixed.</description></item>
            /// <item><description><b>2</b>: fix failed.</description></item>
            /// <item><description><b>3</b>: rollback failed.</description></item>
            /// <item><description><b>4</b>: being fixed.</description></item>
            /// <item><description><b>5</b>: being rolled back.</description></item>
            /// <item><description><b>6</b>: being verified.</description></item>
            /// <item><description><b>7</b>: fixed.</description></item>
            /// <item><description><b>8</b>: fixed and to be restarted.</description></item>
            /// <item><description><b>9</b>: rolled back.</description></item>
            /// <item><description><b>10</b>: ignored.</description></item>
            /// <item><description><b>11</b>: rolled back and to be restarted.</description></item>
            /// <item><description><b>12</b>: not found.</description></item>
            /// <item><description><b>20</b>: expired.</description></item>
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
            /// <para>The type of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: Linux software vulnerability.</description></item>
            /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
            /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
            /// <item><description><b>emg</b>: urgent vulnerability.</description></item>
            /// <item><description><b>app</b>: application vulnerability.</description></item>
            /// <item><description><b>sca</b>: application vulnerability that is detected by using software component analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04c56617-23fc-43a5-ab9b-****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
