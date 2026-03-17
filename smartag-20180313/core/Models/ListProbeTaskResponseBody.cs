// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListProbeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the probe task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>probe-xxx</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListProbeTaskResponseBodyData> Data { get; set; }
        public class ListProbeTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain name that is probed by the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether the probe task is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled</description></item>
            /// <item><description><b>false</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The time when the probe task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-23 14:09</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the probe task was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-23 14:09</para>
            /// </summary>
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            /// <summary>
            /// <para>The number of probe packets transmitted by the probe task per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PacketNumber")]
            [Validation(Required=false)]
            public int? PacketNumber { get; set; }

            /// <summary>
            /// <para>The port that is probed by the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ID of the probe task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>probe-****</para>
            /// </summary>
            [NameInMap("ProbeTaskId")]
            [Validation(Required=false)]
            public string ProbeTaskId { get; set; }

            /// <summary>
            /// <para>The source address of the probe task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("ProbeTaskSourceAddress")]
            [Validation(Required=false)]
            public string ProbeTaskSourceAddress { get; set; }

            /// <summary>
            /// <para>The protocol of the probe task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ICMP</b></description></item>
            /// <item><description><b>TCP</b></description></item>
            /// <item><description><b>HTTP</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>Tasks that probe private networks support only ICMP and TCP.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ICMP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The ID of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-asdfz6ac74oj5v****</para>
            /// </summary>
            [NameInMap("SagId")]
            [Validation(Required=false)]
            public string SagId { get; set; }

            /// <summary>
            /// <para>The serial number of the SAG device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag****</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// <para>The name of the probe task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-ping</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the probe task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Internet</b>: probes a public network.</description></item>
            /// <item><description><b>Intranet</b>: probes a private network.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>324223F3-93D3-4CE4-B26F-66C0C3809922</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
