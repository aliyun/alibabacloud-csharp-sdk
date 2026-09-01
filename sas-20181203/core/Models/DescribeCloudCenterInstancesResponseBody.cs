// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudCenterInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of asset details.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeCloudCenterInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeCloudCenterInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>Indicates whether security alerts exist on the asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testAppName</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The type name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service</para>
            /// </summary>
            [NameInMap("AssetTypeName")]
            [Validation(Required=false)]
            public string AssetTypeName { get; set; }

            /// <summary>
            /// <para>The timestamp when the authorization was bound to the asset. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627974044000</para>
            /// </summary>
            [NameInMap("AuthModifyTime")]
            [Validation(Required=false)]
            public long? AuthModifyTime { get; set; }

            /// <summary>
            /// <para>The authorization version of the asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>The authorization version name of the asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ultimate Edition</para>
            /// </summary>
            [NameInMap("AuthVersionName")]
            [Validation(Required=false)]
            public string AuthVersionName { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset is bound to an authorization. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// <para>Indicates whether the tamper-proofing authorization is bound. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("BindFileProtectType")]
            [Validation(Required=false)]
            public string BindFileProtectType { get; set; }

            /// <summary>
            /// <para>The online status of the client on the instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The sub-status of the client on the instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientSubStatus")]
            [Validation(Required=false)]
            public string ClientSubStatus { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c690a0789419f4284a4e0a29e12fe****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster1</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            /// <summary>
            /// <para>The CPU information of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intel(R) Xeon(R) Platinum 8269CY CPU @ 2.50GHz</para>
            /// </summary>
            [NameInMap("CpuInfo")]
            [Validation(Required=false)]
            public string CpuInfo { get; set; }

            /// <summary>
            /// <para>The timestamp when the cluster was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607365213000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("EdrAuthVersion")]
            [Validation(Required=false)]
            public string EdrAuthVersion { get; set; }

            /// <summary>
            /// <para>The exposure status of the asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExposedStatus")]
            [Validation(Required=false)]
            public int? ExposedStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is an Alibaba Cloud asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The asset vendor. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASK</para>
            /// </summary>
            [NameInMap("FlagName")]
            [Validation(Required=false)]
            public string FlagName { get; set; }

            [NameInMap("FreeType")]
            [Validation(Required=false)]
            public string FreeType { get; set; }

            /// <summary>
            /// <para>The ID of the group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4120080</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the group to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("GroupTrace")]
            [Validation(Required=false)]
            public string GroupTrace { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset contains containers. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("HasContainer")]
            [Validation(Required=false)]
            public string HasContainer { get; set; }

            /// <summary>
            /// <para>Indicates whether baseline risks are detected on the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: Baseline risks are detected.</description></item>
            /// <item><description><b>NO</b>: No baseline risks are detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("HcStatus")]
            [Validation(Required=false)]
            public string HcStatus { get; set; }

            /// <summary>
            /// <para>The number of baseline risks on the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HealthCheckCount")]
            [Validation(Required=false)]
            public int? HealthCheckCount { get; set; }

            /// <summary>
            /// <para>The importance of the asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Importance")]
            [Validation(Required=false)]
            public int? Importance { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-m5***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yztest-l***</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The public IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The IP address list of the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.31.XX.XX,172.171.XX.XX</para>
            /// </summary>
            [NameInMap("IpListString")]
            [Validation(Required=false)]
            public string IpListString { get; set; }

            /// <summary>
            /// <para>The kernel version information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.10.0-1127.19.1.el7.x86_64</para>
            /// </summary>
            [NameInMap("Kernel")]
            [Validation(Required=false)]
            public string Kernel { get; set; }

            /// <summary>
            /// <para>The timestamp when the client last went online. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637592907000</para>
            /// </summary>
            [NameInMap("LastLoginTimestamp")]
            [Validation(Required=false)]
            public long? LastLoginTimestamp { get; set; }

            /// <summary>
            /// <para>The MAC address of the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:13:3e:31:13:39,02:12:67:b8:<b>:</b></para>
            /// </summary>
            [NameInMap("MacListString")]
            [Validation(Required=false)]
            public string MacListString { get; set; }

            /// <summary>
            /// <para>The memory size, in MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crm-test</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The operating system of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The kernel version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>The number of pod groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public int? PodCount { get; set; }

            /// <summary>
            /// <para>The billing method of the protection edition bound to the current asset. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PostPaidFlag")]
            [Validation(Required=false)]
            public int? PostPaidFlag { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-cm***-***</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The region name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>Statistics on risk items of the asset. The value is in JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>account</b>: The number of accounts with unusual logons and successful brute-force attacks.</description></item>
            /// <item><description><b>appNum</b>: The number of scanner vulnerabilities.</description></item>
            /// <item><description><b>asapVulCount</b>: The total number of high-priority vulnerabilities.</description></item>
            /// <item><description><b>baselineHigh</b>: The number of high-risk baseline risks.</description></item>
            /// <item><description><b>baselineLow</b>: The number of low-risk baseline risks.</description></item>
            /// <item><description><b>baselineMedium</b>: The number of medium-risk baseline risks.</description></item>
            /// <item><description><b>baselineNum</b>: The total number of cloud product configuration risks.</description></item>
            /// <item><description><b>cmsNum</b>: The number of Web-CMS vulnerabilities.</description></item>
            /// <item><description><b>containerAsap</b>: The number of high-priority container vulnerabilities.</description></item>
            /// <item><description><b>containerLater</b>: The number of medium-priority container vulnerabilities.</description></item>
            /// <item><description><b>containerNntf</b>: The number of low-priority container vulnerabilities.</description></item>
            /// <item><description><b>containerRemind</b>: The number of container reminder alerts.</description></item>
            /// <item><description><b>containerSerious</b>: The number of container critical alerts.</description></item>
            /// <item><description><b>containerSuspicious</b>: The number of container suspicious alerts.</description></item>
            /// <item><description><b>cveNum</b>: The number of Linux vulnerabilities.</description></item>
            /// <item><description><b>emgNum</b>: The number of emergency vulnerabilities.</description></item>
            /// <item><description><b>health</b>: The number of unhandled baseline alerts.</description></item>
            /// <item><description><b>imageBaselineHigh</b>: The number of high-risk image baseline risks.</description></item>
            /// <item><description><b>imageBaselineLow</b>: The number of low-risk image baseline risks.</description></item>
            /// <item><description><b>imageBaselineMedium</b>: The number of medium-risk image baseline risks.</description></item>
            /// <item><description><b>imageBaselineNum</b>: The total number of image baseline risks.</description></item>
            /// <item><description><b>imageMaliciousFileRemind</b>: The number of image reminder-level malicious files.</description></item>
            /// <item><description><b>imageMaliciousFileSerious</b>: The number of image critical-level malicious files.</description></item>
            /// <item><description><b>imageMaliciousFileSuspicious</b>: The number of image suspicious-level malicious files.</description></item>
            /// <item><description><b>imageVulAsap</b>: The number of high-priority image vulnerabilities.</description></item>
            /// <item><description><b>imageVulLater</b>: The number of medium-priority image vulnerabilities.</description></item>
            /// <item><description><b>imageVulNntf</b>: The number of low-priority image vulnerabilities.</description></item>
            /// <item><description><b>laterVulCount</b>: The number of medium-priority vulnerabilities.</description></item>
            /// <item><description><b>newSuspicious</b>: The number of alerts.</description></item>
            /// <item><description><b>nntfVulCount</b>: The number of low-priority vulnerabilities.</description></item>
            /// <item><description><b>remindNum</b>: The number of reminder alerts.</description></item>
            /// <item><description><b>scaNum</b>: The number of software composition analysis vulnerabilities.</description></item>
            /// <item><description><b>seriousNum</b>: The number of critical alerts.</description></item>
            /// <item><description><b>suspNum</b>: The number of suspicious alerts.</description></item>
            /// <item><description><b>suspicious</b>: The total number of alerts.</description></item>
            /// <item><description><b>sysNum</b>: The number of Windows vulnerabilities.</description></item>
            /// <item><description><b>trojan</b>: The number of trojans.</description></item>
            /// <item><description><b>uuid</b>: The UUID of the asset.</description></item>
            /// <item><description><b>vul</b>: The number of vulnerabilities.</description></item>
            /// <item><description><b>weakPWNum</b>: The number of weak passwords.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;account&quot;: 0,
            ///       &quot;appNum&quot;: 0,
            ///       &quot;asapVulCount&quot;: 0,
            ///       &quot;baselineHigh&quot;: 0,
            ///       &quot;baselineLow&quot;: 0,
            ///       &quot;baselineMedium&quot;: 0,
            ///       &quot;baselineNum&quot;: 0,
            ///       &quot;cmsNum&quot;: 0,
            ///       &quot;containerAsap&quot;: 0,
            ///       &quot;containerLater&quot;: 0,
            ///       &quot;containerNntf&quot;: 0,
            ///       &quot;containerRemind&quot;: 0,
            ///       &quot;containerSerious&quot;: 0,
            ///       &quot;containerSuspicious&quot;: 0,
            ///       &quot;cveNum&quot;: 0,
            ///       &quot;emgNum&quot;: 0,
            ///       &quot;health&quot;: 0,
            ///       &quot;imageBaselineHigh&quot;: 0,
            ///       &quot;imageBaselineLow&quot;: 0,
            ///       &quot;imageBaselineMedium&quot;: 0,
            ///       &quot;imageBaselineNum&quot;: 0,
            ///       &quot;imageMaliciousFileRemind&quot;: 0,
            ///       &quot;imageMaliciousFileSerious&quot;: 0,
            ///       &quot;imageMaliciousFileSuspicious&quot;: 0,
            ///       &quot;imageVulAsap&quot;: 0,
            ///       &quot;imageVulLater&quot;: 0,
            ///       &quot;imageVulNntf&quot;: 0,
            ///       &quot;laterVulCount&quot;: 0,
            ///       &quot;newSuspicious&quot;: 0,
            ///       &quot;nntfVulCount&quot;: 0,
            ///       &quot;remindNum&quot;: 0,
            ///       &quot;scaNum&quot;: 0,
            ///       &quot;seriousNum&quot;: 0,
            ///       &quot;suspNum&quot;: 0,
            ///       &quot;suspicious&quot;: 0,
            ///       &quot;sysNum&quot;: 0,
            ///       &quot;trojan&quot;: 0,
            ///       &quot;uuid&quot;: &quot;inet-37316411-37fe-4b72-b245-346a2721****&quot;,
            ///       &quot;vul&quot;: 0,
            ///       &quot;weakPWNum&quot;: 0
            /// }</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public string RiskCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset has security risks. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The number of security alerts on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SafeEventCount")]
            [Validation(Required=false)]
            public int? SafeEventCount { get; set; }

            /// <summary>
            /// <para>The service ID. This field has a value only when the instance is a serverless instance that belongs to the PAI platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsw-76jlywunsif09bp15p</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The running status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: Running.</description></item>
            /// <item><description><b>notRunning</b>: Stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag name of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternetIp,test</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The tag ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121313,41412</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <para>The custom tags of the Lingjun node. This field is returned only when the machine is a Lingjun machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app:test,type:lingjun</para>
            /// </summary>
            [NameInMap("TagResources")]
            [Validation(Required=false)]
            public string TagResources { get; set; }

            /// <summary>
            /// <para>The UUID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c9107c04-942f-40c1-981a-f1c1***</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The asset vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud asset.</description></item>
            /// <item><description><b>1</b>: Non-cloud asset.</description></item>
            /// <item><description><b>2</b>: IDC asset.</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>, <b>14</b>, <b>16</b>: Third-party cloud asset.</description></item>
            /// <item><description><b>8</b>: Lightweight asset.</description></item>
            /// <item><description><b>9</b>: SAE.</description></item>
            /// <item><description><b>10</b>: PAI.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

            /// <summary>
            /// <para>The service provider name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IDC</para>
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

            /// <summary>
            /// <para>The account ID of the multi-cloud instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("VendorUid")]
            [Validation(Required=false)]
            public string VendorUid { get; set; }

            /// <summary>
            /// <para>The account name of the multi-cloud instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VendorUserName</para>
            /// </summary>
            [NameInMap("VendorUserName")]
            [Validation(Required=false)]
            public string VendorUserName { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf60agqq65bs98zoo****</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities on the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

            /// <summary>
            /// <para>Indicates whether vulnerabilities exist on the instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("VulStatus")]
            [Validation(Required=false)]
            public string VulStatus { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCloudCenterInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCloudCenterInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of assets displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The value of NextToken returned when the NextToken-based pagination method is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of assets displayed per page in a paging query. Default value: <b>20</b>, which indicates that 20 asset records are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of assets returned by the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A73759-4C0F-4801-BE98-901223ACEE9A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result status of the API call. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The API call was successful.</description></item>
        /// <item><description><b>false</b>: The API call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
