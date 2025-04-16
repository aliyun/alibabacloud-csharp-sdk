// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDynamicDisposalProcessesResponseBody : TeaModel {
        [NameInMap("DisposalProcesses")]
        [Validation(Required=false)]
        public List<ListDynamicDisposalProcessesResponseBodyDisposalProcesses> DisposalProcesses { get; set; }
        public class ListDynamicDisposalProcessesResponseBodyDisposalProcesses : TeaModel {
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FD7554AD-4CDE-6359-6B49-4FE950606C2C</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            [NameInMap("DeviceBasicInfo")]
            [Validation(Required=false)]
            public ListDynamicDisposalProcessesResponseBodyDisposalProcessesDeviceBasicInfo DeviceBasicInfo { get; set; }
            public class ListDynamicDisposalProcessesResponseBodyDisposalProcessesDeviceBasicInfo : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                [NameInMap("DevTag")]
                [Validation(Required=false)]
                public string DevTag { get; set; }

                [NameInMap("DevType")]
                [Validation(Required=false)]
                public string DevType { get; set; }

                [NameInMap("Disk")]
                [Validation(Required=false)]
                public string Disk { get; set; }

                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                [NameInMap("OsVersion")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

            }

            [NameInMap("DeviceStatusInfo")]
            [Validation(Required=false)]
            public ListDynamicDisposalProcessesResponseBodyDisposalProcessesDeviceStatusInfo DeviceStatusInfo { get; set; }
            public class ListDynamicDisposalProcessesResponseBodyDisposalProcessesDeviceStatusInfo : TeaModel {
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                [NameInMap("Department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("DlpStatus")]
                [Validation(Required=false)]
                public string DlpStatus { get; set; }

                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                [NameInMap("LaStatus")]
                [Validation(Required=false)]
                public string LaStatus { get; set; }

                [NameInMap("LoginStatus")]
                [Validation(Required=false)]
                public string LoginStatus { get; set; }

                [NameInMap("NacStatus")]
                [Validation(Required=false)]
                public string NacStatus { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("SaseUserId")]
                [Validation(Required=false)]
                public string SaseUserId { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("Workshop")]
                [Validation(Required=false)]
                public string Workshop { get; set; }

                [NameInMap("ZtnaStatus")]
                [Validation(Required=false)]
                public string ZtnaStatus { get; set; }

            }

            [NameInMap("DisposalActions")]
            [Validation(Required=false)]
            public List<string> DisposalActions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dp-xxxxxxxx</para>
            /// </summary>
            [NameInMap("DisposalProcessId")]
            [Validation(Required=false)]
            public string DisposalProcessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1743059249</para>
            /// </summary>
            [NameInMap("DisposalTime")]
            [Validation(Required=false)]
            public string DisposalTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dynamic-policy-xxxxxxxx</para>
            /// </summary>
            [NameInMap("DynamicPolicyId")]
            [Validation(Required=false)]
            public string DynamicPolicyId { get; set; }

            [NameInMap("DynamicPolicyName")]
            [Validation(Required=false)]
            public string DynamicPolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WANGCHENCHENNBB</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("RecoveryType")]
            [Validation(Required=false)]
            public string RecoveryType { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>asdqwedg-xzczvzdaf-asfafs</para>
            /// </summary>
            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>disposal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xiaoming</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
