// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDynamicDisposalProcessesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of disposal processes.</para>
        /// </summary>
        [NameInMap("DisposalProcesses")]
        [Validation(Required=false)]
        public List<ListDynamicDisposalProcessesResponseBodyDisposalProcesses> DisposalProcesses { get; set; }
        public class ListDynamicDisposalProcessesResponseBodyDisposalProcesses : TeaModel {
            /// <summary>
            /// <para>User\&quot;s department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IT</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FD7554AD-4CDE-6359-6B49-4FE950606C2C</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <para>Basic device information.</para>
            /// </summary>
            [NameInMap("DeviceBasicInfo")]
            [Validation(Required=false)]
            public ListDynamicDisposalProcessesResponseBodyDisposalProcessesDeviceBasicInfo DeviceBasicInfo { get; set; }
            public class ListDynamicDisposalProcessesResponseBodyDisposalProcessesDeviceBasicInfo : TeaModel {
                /// <summary>
                /// <para>CPU model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Intel(R) Core(TM) i5-10210U CPU @ 1.60GHz</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <para>Device ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A84D0AF0-1ACC-02B8-6A07-FC898F71BE09</para>
                /// </summary>
                [NameInMap("DevTag")]
                [Validation(Required=false)]
                public string DevTag { get; set; }

                /// <summary>
                /// <para>Device operating system type. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>Windows</b>：Windows system.</description></item>
                /// <item><description><b>macOS</b>：macOS system.</description></item>
                /// <item><description><b>Linux</b>：Linux system.</description></item>
                /// <item><description><b>Android</b>：Android system.</description></item>
                /// <item><description><b>iOS</b>：iOS system.</description></item>
                /// <item><description><b>Windows_Wuying</b>：Wuying cloud desktop system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("DevType")]
                [Validation(Required=false)]
                public string DevType { get; set; }

                /// <summary>
                /// <para>Device disk model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KXG6AZNV512G TOSHIBA</para>
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public string Disk { get; set; }

                /// <summary>
                /// <para>Device name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DESKTOP-ERLV3AK</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>Device MAC address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CE:3B:<b>:</b>:FD:FB</para>
                /// </summary>
                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                /// <summary>
                /// <para>Device memory capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <para>Operating system version</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OsVersion")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

            }

            /// <summary>
            /// <para>设备状态信息。</para>
            /// </summary>
            [NameInMap("DeviceStatusInfo")]
            [Validation(Required=false)]
            public ListDynamicDisposalProcessesResponseBodyDisposalProcessesDeviceStatusInfo DeviceStatusInfo { get; set; }
            public class ListDynamicDisposalProcessesResponseBodyDisposalProcessesDeviceStatusInfo : TeaModel {
                /// <summary>
                /// <para>Client version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.5.1</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>Department to which the user belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IT运维部</para>
                /// </summary>
                [NameInMap("Department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <para>Office data protection status. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enabled</b>: Enabled.</description></item>
                /// <item><description><b>Disabled</b>: Disabled.</description></item>
                /// <item><description><b>Unprovisioned</b>: Not configured.</description></item>
                /// <item><description><b>Unauthorized</b>: Unauthorized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("DlpStatus")]
                [Validation(Required=false)]
                public string DlpStatus { get; set; }

                /// <summary>
                /// <para>Public IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120.26.XX.XX</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>Internet behavior management enablement status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("LaStatus")]
                [Validation(Required=false)]
                public string LaStatus { get; set; }

                /// <summary>
                /// <para>Login status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("LoginStatus")]
                [Validation(Required=false)]
                public string LoginStatus { get; set; }

                /// <summary>
                /// <para>Network access control status. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enabled</b>: Enabled.</description></item>
                /// <item><description><b>Disabled</b>: Disabled.</description></item>
                /// <item><description><b>Unprovisioned</b>: Not configured.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("NacStatus")]
                [Validation(Required=false)]
                public string NacStatus { get; set; }

                /// <summary>
                /// <para>Private IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.20.XX.XX</para>
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// <para>Unique ID of the SASE user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>su_dfsdfsdgasgsgag</para>
                /// </summary>
                [NameInMap("SaseUserId")]
                [Validation(Required=false)]
                public string SaseUserId { get; set; }

                /// <summary>
                /// <para>Username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <para>Identified office area name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>office</para>
                /// </summary>
                [NameInMap("Workshop")]
                [Validation(Required=false)]
                public string Workshop { get; set; }

                /// <summary>
                /// <para>ZTNA enablement status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("ZtnaStatus")]
                [Validation(Required=false)]
                public string ZtnaStatus { get; set; }

            }

            /// <summary>
            /// <para>List of disposal actions.</para>
            /// </summary>
            [NameInMap("DisposalActions")]
            [Validation(Required=false)]
            public List<string> DisposalActions { get; set; }

            /// <summary>
            /// <para>Disposal process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp-xxxxxxxx</para>
            /// </summary>
            [NameInMap("DisposalProcessId")]
            [Validation(Required=false)]
            public string DisposalProcessId { get; set; }

            /// <summary>
            /// <para>Disposal time, in seconds since the epoch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743059249</para>
            /// </summary>
            [NameInMap("DisposalTime")]
            [Validation(Required=false)]
            public string DisposalTime { get; set; }

            /// <summary>
            /// <para>Dynamic policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dynamic-policy-xxxxxxxx</para>
            /// </summary>
            [NameInMap("DynamicPolicyId")]
            [Validation(Required=false)]
            public string DynamicPolicyId { get; set; }

            /// <summary>
            /// <para>Dynamic policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>动态策略1</para>
            /// </summary>
            [NameInMap("DynamicPolicyName")]
            [Validation(Required=false)]
            public string DynamicPolicyName { get; set; }

            /// <summary>
            /// <para>Terminal device name. Length: 1~128 characters, supporting Chinese and uppercase/lowercase English letters, and can include numbers, half-width periods (.), commas (,), semicolons (;), hyphens (-), underscores (<em>), slashes (/), at (@) symbols, and spaces. Entering an underscore (</em>) alone will additionally query all terminal devices with 4-byte UTF-8 characters in their names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WANGCHENCHENNBB</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Recovery type.</para>
            /// <list type="bullet">
            /// <item><description><b>auto</b>：Automatic recovery.</description></item>
            /// <item><description><b>console</b>：Console recovery.</description></item>
            /// <item><description><b>auth</b>：Certification and reporting recovery.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("RecoveryType")]
            [Validation(Required=false)]
            public string RecoveryType { get; set; }

            /// <summary>
            /// <para>Rule content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;Combinator&quot;: &quot;OR&quot;,
            ///   &quot;Rules&quot;: [
            ///     {
            ///       &quot;Operator&quot;: &quot;version_gt&quot;,
            ///       &quot;Values&quot;: [
            ///         &quot;1&quot;
            ///       ],
            ///       &quot;RuleType&quot;: &quot;device_info&quot;,
            ///       &quot;Id&quot;: &quot;1&quot;,
            ///       &quot;RuleSubType&quot;: &quot;basic_info&quot;,
            ///       &quot;Name&quot;: &quot;app_version&quot;
            ///     }
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("RuleContent")]
            [Validation(Required=false)]
            public object RuleContent { get; set; }

            /// <summary>
            /// <para>SASE用户ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdqwedg-xzczvzdaf-asfafs</para>
            /// </summary>
            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            /// <summary>
            /// <para>Disposal status. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>disposal</b>: In the disposal state.</description></item>
            /// <item><description><b>finished</b>: Already automatically recovered.</description></item>
            /// <item><description><b>recovery</b>: Recovered by authentication and reporting or console recovery.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disposal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xiaoming</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of dynamic disposal processes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
