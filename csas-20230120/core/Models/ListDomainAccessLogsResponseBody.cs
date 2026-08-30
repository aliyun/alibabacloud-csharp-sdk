// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDomainAccessLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of access log records.</para>
        /// </summary>
        [NameInMap("AccessLogs")]
        [Validation(Required=false)]
        public List<ListDomainAccessLogsResponseBodyAccessLogs> AccessLogs { get; set; }
        public class ListDomainAccessLogsResponseBodyAccessLogs : TeaModel {
            /// <summary>
            /// <para>The action taken upon a rule hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WhiteList</para>
            /// </summary>
            [NameInMap("BlockAction")]
            [Validation(Required=false)]
            public string BlockAction { get; set; }

            /// <summary>
            /// <para>The department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IT department</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>The destination URL accessed.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/a">https://www.example.com/a</a></para>
            /// </summary>
            [NameInMap("DestAddress")]
            [Validation(Required=false)]
            public string DestAddress { get; set; }

            /// <summary>
            /// <para>The event time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-10 14:03:22</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// <para>The Layer 4 protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("L4ProtocolType")]
            [Validation(Required=false)]
            public string L4ProtocolType { get; set; }

            /// <summary>
            /// <para>The name of the client process that initiated the access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chrome.exe</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.3.4</para>
            /// </summary>
            [NameInMap("RemoteAddress")]
            [Validation(Required=false)]
            public string RemoteAddress { get; set; }

            /// <summary>
            /// <para>The destination domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("RemoteHost")]
            [Validation(Required=false)]
            public string RemoteHost { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("RemotePort")]
            [Validation(Required=false)]
            public string RemotePort { get; set; }

            /// <summary>
            /// <para>The source address of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.5</para>
            /// </summary>
            [NameInMap("SrcAddress")]
            [Validation(Required=false)]
            public string SrcAddress { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F68B6-A17E-5ECD-B053-820242E5ADBF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
