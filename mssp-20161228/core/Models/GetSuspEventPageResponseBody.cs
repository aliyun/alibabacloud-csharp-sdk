// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetSuspEventPageResponseBody : TeaModel {
        /// <summary>
        /// <para>API response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSuspEventPageResponseBodyData> Data { get; set; }
        public class GetSuspEventPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Alarm event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>精准防御</para>
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// <para>Alarm ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5b1eeebe4f22daa2b177298234214fa3</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            /// <summary>
            /// <para>Alarm name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Web服务漏洞利用</para>
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
            /// <para>1722515522000</para>
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
            /// <para>Alarm handling time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1732515522000</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public string DealTime { get; set; }

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
            /// <para>Ticket primary key id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9947</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shells-azhou</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.99.188.31</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>Private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.109.130</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>First occurrence time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>该字段暂未使用，有问题请联系管理员</para>
            /// </summary>
            [NameInMap("OccurrenceTime")]
            [Validation(Required=false)]
            public string OccurrenceTime { get; set; }

            /// <summary>
            /// <para>Owner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Disposal method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>处理完成</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Handling status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>未处理</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>Prompt message of the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetSuspEventPageResponseBodyPageInfo PageInfo { get; set; }
        public class GetSuspEventPageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number in pagination queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of items displayed per page in the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AFA6F7B7-7C4B-58BB-B8FB-E0FFA4483561</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful. - <b>false</b>: The call failed.</description></item>
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
