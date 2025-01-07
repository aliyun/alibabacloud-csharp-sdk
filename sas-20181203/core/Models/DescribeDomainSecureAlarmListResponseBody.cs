// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainSecureAlarmListResponseBody : TeaModel {
        /// <summary>
        /// <para>The security alerts in your website assets.</para>
        /// </summary>
        [NameInMap("AlarmList")]
        [Validation(Required=false)]
        public List<DescribeDomainSecureAlarmListResponseBodyAlarmList> AlarmList { get; set; }
        public class DescribeDomainSecureAlarmListResponseBodyAlarmList : TeaModel {
            /// <summary>
            /// <para>The name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Trojan</para>
            /// </summary>
            [NameInMap("AlarmEventName")]
            [Validation(Required=false)]
            public string AlarmEventName { get; set; }

            /// <summary>
            /// <para>The original parent name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_location</para>
            /// </summary>
            [NameInMap("AlarmEventNameOriginal")]
            [Validation(Required=false)]
            public string AlarmEventNameOriginal { get; set; }

            /// <summary>
            /// <para>The type of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Malicious Software</para>
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// <para>The unique ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8df914418f4211fbf756efe7a6f4****</para>
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic defense is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoBreaking")]
            [Validation(Required=false)]
            public bool? AutoBreaking { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert event can be handled online, such as quarantining the source file of the malicious process, adding the alert event to the whitelist, and ignoring the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }

            /// <summary>
            /// <para>Indicates whether you can cancel marking the alert event as a false positive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }

            /// <summary>
            /// <para>Indicates whether the safeguard mode for major activities is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }

            /// <summary>
            /// <para>The data source of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis_****</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert event is handled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N</b>: unhandled</description></item>
            /// <item><description><b>Y</b>: handled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>y</para>
            /// </summary>
            [NameInMap("Dealed")]
            [Validation(Required=false)]
            public bool? Dealed { get; set; }

            /// <summary>
            /// <para>The description of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The detection model finds that there is a Trojan horse program on your server. The Trojan horse program is a program specially used to invade the user\&quot;s host. Generally, it will download and release another malicious program after being implanted into the system through disguise.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the alert event was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1543740301000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The time of the last modification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1656901794000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert event has tracing information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasTraceInfo")]
            [Validation(Required=false)]
            public bool? HasTraceInfo { get; set; }

            /// <summary>
            /// <para>The instance ID of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-e****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestInstance</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95.214.<em>.</em></para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the affected instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The risk level of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>serious</b></description></item>
            /// <item><description><b>suspicious</b></description></item>
            /// <item><description><b>remind</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>serious</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The handling result code of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kill_and_quara.Success</para>
            /// </summary>
            [NameInMap("OperateErrorCode")]
            [Validation(Required=false)]
            public string OperateErrorCode { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the alert event was handled. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631699497000</para>
            /// </summary>
            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public long? OperateTime { get; set; }

            /// <summary>
            /// <para>The edition of Security Center in which the alert event can be detected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Basic edition.</description></item>
            /// <item><description><b>1</b>: Advanced edition.</description></item>
            /// <item><description><b>2</b>: Enterprise edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public string SaleVersion { get; set; }

            /// <summary>
            /// <para>The ID of the associated alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>270789</para>
            /// </summary>
            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public string SecurityEventIds { get; set; }

            /// <summary>
            /// <para>The solution to the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A malicious program implanted by hacker after intrusion will occupy your bandwidth and attack other servers, and may affect you own service. The malicious process may also have self-deleting behavior or disguise as a system service to evade detection.</para>
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            /// <summary>
            /// <para>The stage at which the attack or intrusion is detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;authority_maintenance\&quot;]</para>
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public string Stages { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the alert event was first detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1543740301000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The total number of security alerts in your website assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuspiciousEventCount")]
            [Validation(Required=false)]
            public int? SuspiciousEventCount { get; set; }

            /// <summary>
            /// <para>The unique ID of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47900178-885d-4fa4-9d77-****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D03DD0FD-6041-5107-AC00-383E28F1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
