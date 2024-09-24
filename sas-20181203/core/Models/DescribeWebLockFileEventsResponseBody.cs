// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockFileEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>An array that consists of events on web tamper proofing returned.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeWebLockFileEventsResponseBodyList> List { get; set; }
        public class DescribeWebLockFileEventsResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The number of attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The timestamp at which the event on web tamper proofing was first detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657178400000</para>
            /// </summary>
            [NameInMap("Ds")]
            [Validation(Required=false)]
            public long? Ds { get; set; }

            /// <summary>
            /// <para>The name of the event on web tamper proofing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>modify</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The status of the event on web tamper proofing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: unhandled</description></item>
            /// <item><description><b>2</b>: ignored</description></item>
            /// <item><description><b>4</b>: deprecated</description></item>
            /// <item><description><b>8</b>: marked as false positive</description></item>
            /// <item><description><b>10</b>: added to the whitelist</description></item>
            /// <item><description><b>16</b>: handling</description></item>
            /// <item><description><b>32</b>: defended</description></item>
            /// <item><description><b>64</b>: invalid</description></item>
            /// <item><description><b>128</b>: deleted</description></item>
            /// <item><description><b>512</b>: automatically handled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public string EventStatus { get; set; }

            /// <summary>
            /// <para>The prevention mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>audit</b>: Interception Mode</description></item>
            /// <item><description><b>web_lock</b>: Alert Mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>audit</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The timestamp at which the event on web tamper proofing was last detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657178400000</para>
            /// </summary>
            [NameInMap("GmtEvent")]
            [Validation(Required=false)]
            public long? GmtEvent { get; set; }

            /// <summary>
            /// <para>The ID of the event on web tamper proofing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3555953980</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-001</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The severity of the event on web tamper proofing. Valid values: <b>medium</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>D:\test-tamper-proofing\123.html</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The name of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>python3.7</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The path to the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Windows\explorer.exe</para>
            /// </summary>
            [NameInMap("ProcessPath")]
            [Validation(Required=false)]
            public string ProcessPath { get; set; }

            /// <summary>
            /// <para>The status of the event on web tamper proofing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: unhandled</description></item>
            /// <item><description><b>2</b>: ignored</description></item>
            /// <item><description><b>4</b>: deprecated</description></item>
            /// <item><description><b>8</b>: marked as false positive</description></item>
            /// <item><description><b>10</b>: added to the whitelist</description></item>
            /// <item><description><b>16</b>: handling</description></item>
            /// <item><description><b>32</b>: defended</description></item>
            /// <item><description><b>64</b>: invalid</description></item>
            /// <item><description><b>128</b>: deleted</description></item>
            /// <item><description><b>512</b>: automatically handled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925FDAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of events on web tamper proofing returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
