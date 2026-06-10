// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAlertItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, authorization succeeded.  </description></item>
        /// <item><description>Any other status code indicates authorization failed. When authorization fails, view the <c>message</c> field to obtain the detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;NODE&quot;: {
        ///       &quot;饱和度&quot;: [
        ///         &quot;节点CPU使用率检测&quot;,
        ///         &quot;节点内核态CPU使用检测&quot;,
        ///         &quot;节点软中断CPU使用检测&quot;,
        ///         &quot;节点内存使用检测&quot;,
        ///         &quot;节点内核内存使用检测&quot;,
        ///         &quot;节点文件描述符使用检测&quot;,
        ///         &quot;节点根文件系统使用检测&quot;,
        ///         &quot;节点cgroup泄漏检测&quot;,
        ///         &quot;节点Sockets使用检测&quot;,
        ///         &quot;节点TCP内存使用检测&quot;
        ///       ],
        ///       &quot;延时&quot;: [
        ///         &quot;节点调度延时检测&quot;,
        ///         &quot;节点网络延时检测&quot;,
        ///         &quot;节点磁盘写入延迟检测&quot;,
        ///         &quot;节点磁盘读取延迟检测&quot;
        ///       ],
        ///       &quot;负载&quot;: [
        ///         &quot;节点磁盘IO流量检测&quot;,
        ///         &quot;节点load average检测&quot;
        ///       ],
        ///       &quot;错误&quot;: [
        ///         &quot;节点网络丢包检测&quot;,
        ///         &quot;节点OOM夯机预测及检测&quot;
        ///       ]
        ///     },
        ///     &quot;POD&quot;: {
        ///       &quot;饱和度&quot;: [
        ///         &quot;Pod内存使用检测&quot;,
        ///         &quot;Pod CPU使用率检测&quot;
        ///       ],
        ///       &quot;错误&quot;: [
        ///         &quot;Pod CPU限流检测&quot;,
        ///         &quot;Pod OOM事件检测&quot;
        ///       ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
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

    }

}
