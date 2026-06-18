// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListSyslogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The object that contains the paginated list of logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<ListSyslogsResponseBodyLogs> Logs { get; set; }
        public class ListSyslogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i119583961673208491760</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The security domain of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_PUBLIC</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>A standard field in Linux syslog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kern</para>
            /// </summary>
            [NameInMap("Facility")]
            [Validation(Required=false)]
            public string Facility { get; set; }

            /// <summary>
            /// <para>The hostname of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>damo-m53kr8kd-0008</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The IP address of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114.55.254.44</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The content of the syslog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bond4: failed to get link speed/duplex for eth8</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-9lb36u4s601</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>A standard field in Linux syslog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>warning</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The unique identifier of the machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21A401332</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// <para>The hostname of the syslog server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>damo-m53kr8kd-0008</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>A standard field in Linux syslog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kernel</para>
            /// </summary>
            [NameInMap("Syslogtag")]
            [Validation(Required=false)]
            public string Syslogtag { get; set; }

            /// <summary>
            /// <para>Tag: Hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>damo-m53kr8kd-0008</para>
            /// </summary>
            [NameInMap("TagHostname")]
            [Validation(Required=false)]
            public string TagHostname { get; set; }

            /// <summary>
            /// <para>Tag: Package ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>D990314D3C25D7E8-1080</para>
            /// </summary>
            [NameInMap("TagPackId")]
            [Validation(Required=false)]
            public string TagPackId { get; set; }

            /// <summary>
            /// <para>Tag: Path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/var/log/kern</para>
            /// </summary>
            [NameInMap("TagPath")]
            [Validation(Required=false)]
            public string TagPath { get; set; }

            /// <summary>
            /// <para>Tag: Receive time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687363348</para>
            /// </summary>
            [NameInMap("TagReceiveTime")]
            [Validation(Required=false)]
            public string TagReceiveTime { get; set; }

            /// <summary>
            /// <para>Tag: User-defined ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application_b</para>
            /// </summary>
            [NameInMap("TagUserDefinedId")]
            [Validation(Required=false)]
            public string TagUserDefinedId { get; set; }

            /// <summary>
            /// <para>The time in UNIX format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687363346</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The topic. Valid values are \<c>logserver\\</c> and \<c>log2sls\\</c>. Note: Both are syslog servers. \<c>logserver\\</c> collects data over TCP. \<c>log2sls\\</c> collects data over UDP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logserver</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>The \<c>NextToken\\</c> for the next page. To retrieve the next page of results, include this return value in the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>563d42ae0b17572449ec8c97f7f66069</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FE2B22C-CF9D-59DE-BF63-DC9B9B33A9D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
