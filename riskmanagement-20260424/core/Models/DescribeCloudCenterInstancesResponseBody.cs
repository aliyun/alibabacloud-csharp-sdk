// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeCloudCenterInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudCenterInstancesResponseBodyData Data { get; set; }
        public class DescribeCloudCenterInstancesResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public DescribeCloudCenterInstancesResponseBodyDataBody Body { get; set; }
            public class DescribeCloudCenterInstancesResponseBodyDataBody : TeaModel {
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public List<DescribeCloudCenterInstancesResponseBodyDataBodyInstances> Instances { get; set; }
                public class DescribeCloudCenterInstancesResponseBodyDataBodyInstances : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NO</para>
                    /// </summary>
                    [NameInMap("AlarmStatus")]
                    [Validation(Required=false)]
                    public string AlarmStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>FC2U0JVHWS49S2OT</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>guokent</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AssetType")]
                    [Validation(Required=false)]
                    public string AssetType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxxxxx</para>
                    /// </summary>
                    [NameInMap("AssetTypeName")]
                    [Validation(Required=false)]
                    public string AssetTypeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1627974044000</para>
                    /// </summary>
                    [NameInMap("AuthModifyTime")]
                    [Validation(Required=false)]
                    public long? AuthModifyTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("AuthVersion")]
                    [Validation(Required=false)]
                    public int? AuthVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>免费版</para>
                    /// </summary>
                    [NameInMap("AuthVersionName")]
                    [Validation(Required=false)]
                    public string AuthVersionName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Bind")]
                    [Validation(Required=false)]
                    public bool? Bind { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("BindFileProtectType")]
                    [Validation(Required=false)]
                    public string BindFileProtectType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>online</para>
                    /// </summary>
                    [NameInMap("ClientStatus")]
                    [Validation(Required=false)]
                    public string ClientStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>online</para>
                    /// </summary>
                    [NameInMap("ClientSubStatus")]
                    [Validation(Required=false)]
                    public string ClientSubStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cb703cb0ba6bd40d4a6d8de5bff050fb9</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>auto-cn-heyuan</para>
                    /// </summary>
                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public int? Cores { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Intel(R) Xeon(R) Platinum 8269CY CPU @ 2.50GHz</para>
                    /// </summary>
                    [NameInMap("CpuInfo")]
                    [Validation(Required=false)]
                    public string CpuInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1607365213000</para>
                    /// </summary>
                    [NameInMap("CreatedTime")]
                    [Validation(Required=false)]
                    public long? CreatedTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExposedStatus")]
                    [Validation(Required=false)]
                    public int? ExposedStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0,1,2</para>
                    /// </summary>
                    [NameInMap("Flag")]
                    [Validation(Required=false)]
                    public int? Flag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ALIYUN</para>
                    /// </summary>
                    [NameInMap("FlagName")]
                    [Validation(Required=false)]
                    public string FlagName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>86d30f8b0e124aadb7ef3197f9dbd1f5</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public long? GroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("GroupTrace")]
                    [Validation(Required=false)]
                    public string GroupTrace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>YES</para>
                    /// </summary>
                    [NameInMap("HasContainer")]
                    [Validation(Required=false)]
                    public string HasContainer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>YES</para>
                    /// </summary>
                    [NameInMap("HcStatus")]
                    [Validation(Required=false)]
                    public string HcStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HealthCheckCount")]
                    [Validation(Required=false)]
                    public int? HealthCheckCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Importance")]
                    [Validation(Required=false)]
                    public int? Importance { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ls-cn-tl32rf**008</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ra-supabase-22u1iv3hr**5v9</para>
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>47.1**.52.125</para>
                    /// </summary>
                    [NameInMap("InternetIp")]
                    [Validation(Required=false)]
                    public string InternetIp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>172.16.1**.245</para>
                    /// </summary>
                    [NameInMap("IntranetIp")]
                    [Validation(Required=false)]
                    public string IntranetIp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>114.55.*4.*6</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>172.31.XX.XX,172.171.XX.XX</para>
                    /// </summary>
                    [NameInMap("IpListString")]
                    [Validation(Required=false)]
                    public string IpListString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3.10.0-1127.19.1.el7.x86_64</para>
                    /// </summary>
                    [NameInMap("Kernel")]
                    [Validation(Required=false)]
                    public string Kernel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1637592907000</para>
                    /// </summary>
                    [NameInMap("LastLoginTimestamp")]
                    [Validation(Required=false)]
                    public long? LastLoginTimestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>00:13:3e:31:13:39,02:12:67:b8:<b>:</b></para>
                    /// </summary>
                    [NameInMap("MacListString")]
                    [Validation(Required=false)]
                    public string MacListString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public string Mem { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>slsshpcorlsmetrics</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>linux</para>
                    /// </summary>
                    [NameInMap("Os")]
                    [Validation(Required=false)]
                    public string Os { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AliOS7U2-x86-64</para>
                    /// </summary>
                    [NameInMap("OsName")]
                    [Validation(Required=false)]
                    public string OsName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("PodCount")]
                    [Validation(Required=false)]
                    public int? PodCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PostPaidFlag")]
                    [Validation(Required=false)]
                    public int? PostPaidFlag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhouxxxx</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("RegionName")]
                    [Validation(Required=false)]
                    public string RegionName { get; set; }

                    /// <summary>
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
                    /// <b>Example:</b>
                    /// <para>NO</para>
                    /// </summary>
                    [NameInMap("RiskStatus")]
                    [Validation(Required=false)]
                    public string RiskStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("SafeEventCount")]
                    [Validation(Required=false)]
                    public string SafeEventCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dsw-76jlywunsif09bp15p</para>
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Running</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pre_20250714_idpt_adjust</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>d8586ab8be4549e3815995858d277763</para>
                    /// </summary>
                    [NameInMap("TagId")]
                    [Validation(Required=false)]
                    public string TagId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>app:test,type:lingjun</para>
                    /// </summary>
                    [NameInMap("TagResources")]
                    [Validation(Required=false)]
                    public string TagResources { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1f0459ee-ed49-6484-8958-4f10f61e6362</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Vendor")]
                    [Validation(Required=false)]
                    public int? Vendor { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>IDC</para>
                    /// </summary>
                    [NameInMap("VendorName")]
                    [Validation(Required=false)]
                    public string VendorName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("VendorUid")]
                    [Validation(Required=false)]
                    public string VendorUid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>VendorUserName</para>
                    /// </summary>
                    [NameInMap("VendorUserName")]
                    [Validation(Required=false)]
                    public string VendorUserName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vpc-2zek7v0z4r6lbp02xckei</para>
                    /// </summary>
                    [NameInMap("VpcInstanceId")]
                    [Validation(Required=false)]
                    public string VpcInstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("VulCount")]
                    [Validation(Required=false)]
                    public int? VulCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>YES</para>
                    /// </summary>
                    [NameInMap("VulStatus")]
                    [Validation(Required=false)]
                    public string VulStatus { get; set; }

                }

                [NameInMap("PageInfo")]
                [Validation(Required=false)]
                public DescribeCloudCenterInstancesResponseBodyDataBodyPageInfo PageInfo { get; set; }
                public class DescribeCloudCenterInstancesResponseBodyDataBodyPageInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CurrentPage")]
                    [Validation(Required=false)]
                    public int? CurrentPage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>m1NGAAAAAABzLzIwMjQwMg==</para>
                    /// </summary>
                    [NameInMap("NextToken")]
                    [Validation(Required=false)]
                    public string NextToken { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20EBDE7B-AA36-5D60-9DCA-151C48EDB9F8</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B4C9A14-94E6-5EEB-BF39-7DACCE9AC0D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
