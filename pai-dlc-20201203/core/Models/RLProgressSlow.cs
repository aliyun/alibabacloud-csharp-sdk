// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressSlow : TeaModel {
        /// <summary>
        /// <para>慢推理明细，最多 20 条</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Elapsed&quot;:42.5,&quot;Time&quot;:1787474487,&quot;Message&quot;:&quot;rollout generation slow&quot;,&quot;Rank&quot;:0,&quot;Pod&quot;:&quot;dlc193cpaitk8eny-master-0&quot;,&quot;WorkerPid&quot;:12345,&quot;Ip&quot;:&quot;192.168.0.12&quot;,&quot;Rid&quot;:&quot;req-8f3a2c1d&quot;,&quot;TokenizerPid&quot;:&quot;12360&quot;,&quot;Ipc&quot;:&quot;ipc://worker-0&quot;,&quot;IsPause&quot;:&quot;false&quot;,&quot;StatePresent&quot;:&quot;true&quot;,&quot;OutQueue&quot;:&quot;3&quot;}]</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<RLProgressSlowDetail> Details { get; set; }

        /// <summary>
        /// <para>最慢一条的已耗时（秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.5</para>
        /// </summary>
        [NameInMap("Elapsed")]
        [Validation(Required=false)]
        public double? Elapsed { get; set; }

        /// <summary>
        /// <para>最慢一条的日志时间（unix 秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

    }

}
