// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetAlarmDetailByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>API response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlarmDetailByIdResponseBodyData Data { get; set; }
        public class GetAlarmDetailByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Alarm event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// <para>Alarm event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login with unusual location</para>
            /// </summary>
            [NameInMap("AlarmEventTypeDisplay")]
            [Validation(Required=false)]
            public string AlarmEventTypeDisplay { get; set; }

            /// <summary>
            /// <para>Alarm ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202427220</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            /// <summary>
            /// <para>Alarm name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>负载均衡可挂载服务器数量告警</para>
            /// </summary>
            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }

            /// <summary>
            /// <para>Alarm source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUSP_EVENT</para>
            /// </summary>
            [NameInMap("AlarmSource")]
            [Validation(Required=false)]
            public string AlarmSource { get; set; }

            /// <summary>
            /// <para>Latest alarm time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-26 01:51:01</para>
            /// </summary>
            [NameInMap("AlarmTime")]
            [Validation(Required=false)]
            public string AlarmTime { get; set; }

            /// <summary>
            /// <para>Analysis process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;value&quot;:&quot;服务器可能已被黑客攻击，存在恶意进程在运行。 分析过程：告警显示，服务端存在一个名为”dns.exe”的进程在访问”polling.burpcollaborator.net”，这是一个被黑名单列出的恶意域名。在正常情况下,”dns.exe”不应该单独存在于系统的路径下，并且也不应该访问这类恶意域名。因此，这个进程可能是黑客留下的恶意进程。&quot;,&quot;key&quot;:&quot;结论&quot;},{&quot;value&quot;:&quot;尽快对服务器进行全面扫描，清除恶意进程。同时，联系网络安全专家进行深入调查，以确定是否有其他潜在的安全威胁。&quot;,&quot;key&quot;:&quot;处置建议&quot;}]</para>
            /// </summary>
            [NameInMap("AnalysisResult")]
            [Validation(Required=false)]
            public string AnalysisResult { get; set; }

            /// <summary>
            /// <para>Whether high-protection mode is enabled. true means enabled, false means not enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }

            /// <summary>
            /// <para>Alarm handling time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-26 01:51:01</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public string DealTime { get; set; }

            /// <summary>
            /// <para>Description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>webshell</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>Event details information.</para>
            /// </summary>
            [NameInMap("EventDetails")]
            [Validation(Required=false)]
            public List<GetAlarmDetailByIdResponseBodyDataEventDetails> EventDetails { get; set; }
            public class GetAlarmDetailByIdResponseBodyDataEventDetails : TeaModel {
                /// <summary>
                /// <para>Alarm event display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Login with unusual location</para>
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// <para>Alarm event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Path where the alarm event occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/etc/crontab</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>Path where the alarm event occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/etc/crontab</para>
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// <para>Alarm level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>suspicious</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <para>Primary key ID of the work order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9772</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Public IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.116.126.79</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>Private IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.19.195.176</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>First occurrence time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-26 01:51:01</para>
            /// </summary>
            [NameInMap("OccurrenceTime")]
            [Validation(Required=false)]
            public string OccurrenceTime { get; set; }

            /// <summary>
            /// <para>Owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>324546</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Disposal method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Handling status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>要查询的告警事件状态。取值：</para>
            /// <para>0：全部
            /// 1：待处理
            /// 2：已忽略
            /// 4：已确认
            /// 8：已标记为误报
            /// 16：处理中
            /// 32：处理完毕
            /// 64：已经过期
            /// 128：已经删除
            /// 512：自动拦截中
            /// 513：自动拦截完毕</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>ATT&amp;CK tactic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Malicious scripts-Malicious script code execution</para>
            /// </summary>
            [NameInMap("TacticDisplayName")]
            [Validation(Required=false)]
            public string TacticDisplayName { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C1B0668-442C-57AE-9668-D894B0B012EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the operation was successful: - true: Success. - false: Failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
