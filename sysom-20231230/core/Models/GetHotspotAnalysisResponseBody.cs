// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotspotAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned Data</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;AliYunDun:1657494进程(1657494):根据提供的热点调用栈信息，热点主要集中在<c>__nanosleep_nocancel</c>以及相关的系统调用<c>SyS_nanosleep</c>上，这表明进程在等待特定的时间间隔。通常这是由于应用中存在长时间的睡眠或高频率的定时操作导致的，比如定时任务、心跳检测等。\n\n应用代码在需要定期执行某些检查或等待外部事件时会使用<c>nanosleep</c>来实现精确的延时控制。为了优化这种情况，可以考虑以下方案：\n- 评估是否可以减少定时任务的频率。\n- 使用条件变量替代单纯的睡眠等待，以响应更快的事件触发。\n- 如果是I/O密集型操作等待，考虑优化I/O路径或提升I/O效率。建议使用SysOM平台的IO诊断工具来进一步定位具体的I/O瓶颈。&quot;</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the invocation is successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
