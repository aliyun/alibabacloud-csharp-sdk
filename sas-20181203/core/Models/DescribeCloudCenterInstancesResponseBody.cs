// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudCenterInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the assets.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeCloudCenterInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeCloudCenterInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>Indicates whether alerts are generated on the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// <remarks>
            /// <para> This parameter is available only when the <b>Vendor</b> parameter is set to 9.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// <remarks>
            /// <para> This parameter is available only when the <b>Vendor</b> parameter is set to 9.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testAppName</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: an ECS instance</description></item>
            /// <item><description><b>1</b>: a Server Load Balancer (SLB) instance</description></item>
            /// <item><description><b>2</b>: a Network Address Translation (NAT) gateway</description></item>
            /// <item><description><b>3</b>: an ApsaraDB RDS instance</description></item>
            /// <item><description><b>4</b>: an ApsaraDB for MongoDB instance</description></item>
            /// <item><description><b>5</b>: an ApsaraDB for Redis instance</description></item>
            /// <item><description><b>6</b>: a container image</description></item>
            /// <item><description><b>7</b>: a container</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The name of the asset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service</para>
            /// </summary>
            [NameInMap("AssetTypeName")]
            [Validation(Required=false)]
            public string AssetTypeName { get; set; }

            /// <summary>
            /// <para>The timestamp when Security Center is authorized to scan the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627974044000</para>
            /// </summary>
            [NameInMap("AuthModifyTime")]
            [Validation(Required=false)]
            public long? AuthModifyTime { get; set; }

            /// <summary>
            /// <para>The edition of Security Center that is authorized to scan the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic edition</description></item>
            /// <item><description><b>6</b>: Anti-virus edition</description></item>
            /// <item><description><b>5</b>: Advanced edition</description></item>
            /// <item><description><b>3</b>: Enterprise edition</description></item>
            /// <item><description><b>7</b>: Ultimate edition</description></item>
            /// <item><description><b>10</b>: Value-added Plan edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>The name of the Security Center edition that is authorized to protect the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Basic edition</description></item>
            /// <item><description>Anti-virus edition</description></item>
            /// <item><description>Advanced edition</description></item>
            /// <item><description>Enterprise edition</description></item>
            /// <item><description>Ultimate edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ultimate Edition</para>
            /// </summary>
            [NameInMap("AuthVersionName")]
            [Validation(Required=false)]
            public string AuthVersionName { get; set; }

            /// <summary>
            /// <para>Indicates whether Security Center is authorized to scan the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Security Center is authorized to scan the asset.</description></item>
            /// <item><description><b>false</b>: Security Center is not authorized to scan the asset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// <para>The status of the Security Center agent installed on the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: The Security Center agent is <b>enabled</b>.</description></item>
            /// <item><description><b>offline</b>: The Security Center agent is <b>disabled</b>.</description></item>
            /// <item><description><b>pause</b>: The Security Center agent is <b>suspended</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The sub-status of the Security Center agent installed on the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: The Security Center agent is <b>enabled</b>.</description></item>
            /// <item><description><b>offline</b>: The Security Center agent is <b>disabled</b>.</description></item>
            /// <item><description><b>pause</b>: The Security Center agent is <b>suspended</b>.</description></item>
            /// <item><description><b>uninstalled</b>: The Security Center agent is <b>uninstalled</b>.</description></item>
            /// <item><description><b>stopped</b>: The Security Center agent is <b>stopped</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientSubStatus")]
            [Validation(Required=false)]
            public string ClientSubStatus { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c690a0789419f4284a4e0a29e12fe****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster1</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The number of the CPU cores used by the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            /// <summary>
            /// <para>The CPU information about the asset.</para>
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

            /// <summary>
            /// <para>Indicates whether the asset is exposed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The asset is not exposed.</description></item>
            /// <item><description><b>1</b>: The asset is exposed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExposedStatus")]
            [Validation(Required=false)]
            public int? ExposedStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset is an Alibaba Cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The asset is an Alibaba Cloud asset.</description></item>
            /// <item><description><b>1</b>: The asset is not an Alibaba Cloud asset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The service provider of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIYUN</b></description></item>
            /// <item><description><b>OUT</b></description></item>
            /// <item><description><b>IDC</b></description></item>
            /// <item><description><b>Tencent</b></description></item>
            /// <item><description><b>HUAWEICLOUD</b></description></item>
            /// <item><description><b>Azure</b></description></item>
            /// <item><description><b>AWS</b></description></item>
            /// <item><description><b>ASK</b></description></item>
            /// <item><description><b>TRIPARTITE</b></description></item>
            /// <item><description><b>SAE</b></description></item>
            /// <item><description><b>PAI</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASK</para>
            /// </summary>
            [NameInMap("FlagName")]
            [Validation(Required=false)]
            public string FlagName { get; set; }

            /// <summary>
            /// <para>The ID of the asset group to which the asset belongs.</para>
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
            /// <para>Indicates whether baseline risks are detected on the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("HcStatus")]
            [Validation(Required=false)]
            public string HcStatus { get; set; }

            /// <summary>
            /// <para>The number of baseline risks that are detected on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HealthCheckCount")]
            [Validation(Required=false)]
            public int? HealthCheckCount { get; set; }

            /// <summary>
            /// <para>The importance of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: an important asset</description></item>
            /// <item><description><b>1</b>: a common asset</description></item>
            /// <item><description><b>0</b>: a test asset</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Importance")]
            [Validation(Required=false)]
            public int? Importance { get; set; }

            /// <summary>
            /// <para>The ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-m5***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yztest-l***</para>
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
            /// <para>The public IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The IP addresses of the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.31.XX.XX,172.171.XX.XX</para>
            /// </summary>
            [NameInMap("IpListString")]
            [Validation(Required=false)]
            public string IpListString { get; set; }

            /// <summary>
            /// <para>The version of the kernel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.10.0-1127.19.1.el7.x86_64</para>
            /// </summary>
            [NameInMap("Kernel")]
            [Validation(Required=false)]
            public string Kernel { get; set; }

            /// <summary>
            /// <para>The timestamp when the Security Center agent was last online. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637592907000</para>
            /// </summary>
            [NameInMap("LastLoginTimestamp")]
            [Validation(Required=false)]
            public long? LastLoginTimestamp { get; set; }

            /// <summary>
            /// <para>The MAC addresses of the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:13:3e:31:13:39,02:12:67:b8:<b>:</b></para>
            /// </summary>
            [NameInMap("MacListString")]
            [Validation(Required=false)]
            public string MacListString { get; set; }

            /// <summary>
            /// <para>The size of the memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>The operating system of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The kernel version of the asset.</para>
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
            /// <para>The number of pods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public int? PodCount { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-cm***-***</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region in which the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The total number of baseline risks that are detected on the asset. The value of this parameter is in the JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>account</b>: the number of accounts that are used to log on from unapproved logon locations and whose passwords are cracked</description></item>
            /// <item><description><b>appNum</b>: the number of scanners</description></item>
            /// <item><description><b>asapVulCount</b>: the total number of high-severity vulnerabilities</description></item>
            /// <item><description><b>baselineHigh</b>: the number of high-risk baseline risks</description></item>
            /// <item><description><b>baselineLow</b>: the number of low-risk baseline risks</description></item>
            /// <item><description><b>baselineMedium</b>: the number of medium-risk baseline risks</description></item>
            /// <item><description><b>baselineNum</b>: the total number of baseline risks</description></item>
            /// <item><description><b>cmsNum</b>: the number of Web-CMS vulnerabilities</description></item>
            /// <item><description><b>containerAsap</b>: the number of high-severity vulnerabilities that are detected on containers</description></item>
            /// <item><description><b>containerLater</b>: the number of medium-severity vulnerabilities that are detected on containers</description></item>
            /// <item><description><b>containerNntf</b>: the number of low-severity vulnerabilities that are detected on containers</description></item>
            /// <item><description><b>containerRemind</b>: the number of alerts whose Emergency level is Reminder on containers</description></item>
            /// <item><description><b>containerSerious</b>: the number of alerts Emergency level is Urgent on containers</description></item>
            /// <item><description><b>containerSuspicious</b>: the number of alerts whose Emergency level is Suspicious on containers</description></item>
            /// <item><description><b>cveNum</b>: the number of Linux software vulnerabilities</description></item>
            /// <item><description><b>emgNum</b>: the number of urgent vulnerabilities</description></item>
            /// <item><description><b>health</b>: the number of baseline alerts that are unhandled</description></item>
            /// <item><description><b>imageBaselineHigh</b>: the number of high-risk baseline risks that are detected on images</description></item>
            /// <item><description><b>imageBaselineLow</b>: the number of low-risk baseline risks that are detected on images</description></item>
            /// <item><description><b>imageBaselineMedium</b>: the number of medium-risk baseline risks that are detected on images</description></item>
            /// <item><description><b>imageBaselineNum</b>: the total number of baseline risks that are detected on images</description></item>
            /// <item><description><b>imageMaliciousFileRemind</b>: the number of malicious files that are detected on images and have the Emergency level of Reminder</description></item>
            /// <item><description><b>imageMaliciousFileSerious</b>: the number of malicious files that are detected on images and have the Emergency level of Urgent</description></item>
            /// <item><description><b>imageMaliciousFileSuspicious</b>: the number of malicious files that are detected on images and have the Emergency level of Suspicious</description></item>
            /// <item><description><b>imageVulAsap</b>: the number of high-severity vulnerabilities that are detected on images</description></item>
            /// <item><description><b>imageVulLater</b>: the number of medium-severity vulnerabilities that are detected on an image</description></item>
            /// <item><description><b>imageVulNntf</b>: the number of low-severity vulnerabilities that are detected on an image</description></item>
            /// <item><description><b>laterVulCount</b>: the number of medium-severity vulnerabilities</description></item>
            /// <item><description><b>newSuspicious</b>: the number of alerts</description></item>
            /// <item><description><b>nntfVulCount</b>: the number of low-severity vulnerabilities.</description></item>
            /// <item><description><b>remindNum</b>: the number of alerts whose Emergency level is Reminder</description></item>
            /// <item><description><b>scaNum</b>: the number of vulnerabilities that are detected based on software component analysis</description></item>
            /// <item><description><b>seriousNum</b>: the number of alerts whose Emergency level is Urgent</description></item>
            /// <item><description><b>suspNum</b>: the number of alerts whose Emergency level is Suspicious</description></item>
            /// <item><description><b>suspicious</b>: the total number of alerts</description></item>
            /// <item><description><b>sysNum</b>: the number of Windows system vulnerabilities</description></item>
            /// <item><description><b>trojan</b>: the number of trojans</description></item>
            /// <item><description><b>uuid</b>: the UUIDs of assets</description></item>
            /// <item><description><b>vul</b>: the number of vulnerabilities</description></item>
            /// <item><description><b>weakPWNum</b>: the number of weak passwords</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;account&quot;:0,&quot;appNum&quot;:0,&quot;asapVulCount&quot;:0,&quot;baselineHigh&quot;:0,&quot;baselineLow&quot;:0,&quot;baselineMedium&quot;:0,&quot;baselineNum&quot;:0,&quot;cmsNum&quot;:0,&quot;containerAsap&quot;:0,&quot;containerLater&quot;:0,&quot;containerNntf&quot;:0,&quot;containerRemind&quot;:0,&quot;containerSerious&quot;:0,&quot;containerSuspicious&quot;:0,&quot;cveNum&quot;:0,&quot;emgNum&quot;:0,&quot;health&quot;:0,&quot;imageBaselineHigh&quot;:0,&quot;imageBaselineLow&quot;:0,&quot;imageBaselineMedium&quot;:0,&quot;imageBaselineNum&quot;:0,&quot;imageMaliciousFileRemind&quot;:0,&quot;imageMaliciousFileSerious&quot;:0,&quot;imageMaliciousFileSuspicious&quot;:0,&quot;imageVulAsap&quot;:0,&quot;imageVulLater&quot;:0,&quot;imageVulNntf&quot;:0,&quot;laterVulCount&quot;:0,&quot;newSuspicious&quot;:0,&quot;nntfVulCount&quot;:0,&quot;remindNum&quot;:0,&quot;scaNum&quot;:0,&quot;seriousNum&quot;:0,&quot;suspNum&quot;:0,&quot;suspicious&quot;:0,&quot;sysNum&quot;:0,&quot;trojan&quot;:0,&quot;uuid&quot;:&quot;inet-37316411-37fe-4b72-b245-346a2721d4b6&quot;,&quot;vul&quot;:0,&quot;weakPWNum&quot;:0}</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public string RiskCount { get; set; }

            /// <summary>
            /// <para>Indicates whether risks are detected on the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The number of alerts that are generated on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SafeEventCount")]
            [Validation(Required=false)]
            public int? SafeEventCount { get; set; }

            /// <summary>
            /// <para>The status of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: running</description></item>
            /// <item><description><b>notRunning</b>: stopped</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the asset tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternetIp,test</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The ID of the asset tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121313,41412</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// <para>The custom tag added to the Lingjun node. This parameter is returned only for LINGJUN GPU-accelerated instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app:test,type:lingjun</para>
            /// </summary>
            [NameInMap("TagResources")]
            [Validation(Required=false)]
            public string TagResources { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c9107c04-942f-40c1-981a-f1c1***</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The service provider of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: an asset provided by Alibaba Cloud</description></item>
            /// <item><description><b>1</b>: an asset outside Alibaba Cloud</description></item>
            /// <item><description><b>2</b>: an asset in a data center</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: an asset from a third-party cloud service provider</description></item>
            /// <item><description><b>8</b>: a lightweight asset</description></item>
            /// <item><description><b>9</b>: a SAE instance</description></item>
            /// <item><description><b>10</b>: an instance in PAI</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

            /// <summary>
            /// <para>The name of the service provider for the asset.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIYUN</b>: Alibaba Cloud</description></item>
            /// <item><description><b>OUT</b>: a third-party service provider</description></item>
            /// <item><description><b>IDC</b>: a data center</description></item>
            /// <item><description><b>TENCENT</b>: Tencent Cloud</description></item>
            /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud</description></item>
            /// <item><description><b>Microsoft</b>: Microsoft Azure</description></item>
            /// <item><description><b>AWS</b>: Amazon Web Services (AWS)</description></item>
            /// <item><description><b>TRIPARTITE</b>: a lightweight server</description></item>
            /// <item><description><b>SAE</b>: a SAE instance</description></item>
            /// <item><description><b>PAI</b>: an instance in PAI</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Tencent</para>
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf60agqq65bs98zoo****</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities that are detected on the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

            /// <summary>
            /// <para>Indicates whether vulnerabilities are detected on the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
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
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

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
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A73759-4C0F-4801-BE98-901223ACEE9A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.</description></item>
        /// <item><description><b>false</b>: The call fails.</description></item>
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
