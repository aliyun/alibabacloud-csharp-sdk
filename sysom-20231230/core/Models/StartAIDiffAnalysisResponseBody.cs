// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class StartAIDiffAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization succeeded.  </description></item>
        /// <item><description>Other status codes indicate that authorization failed. When authorization fails, view the <c>message</c> field to obtain detailed error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>AI differential analysis result data</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;[
        ///   {
        ///       name: &quot;xxx&quot;, #算子名称
        ///       before_time: 2, # 前者总耗时
        ///       after_time: 4, # 后者总耗时
        ///       time_diff: 2,  # 耗时差异
        ///       before_time_perc: &quot;80%&quot;, # 前者总耗时百分比
        ///       after_time_perc: &quot;23%&quot;, # 后者总耗时百分比
        ///       time_perc_diff: &quot;-54%&quot;,  # 耗时差异
        ///       before_count: 1, # 前者总调用差异
        ///       after_count: 2,  # 后者总调用差异
        ///       count_diff: 1,   # 调用差异
        ///       before_count_perc: &quot;56%&quot;, # 前者总调用差异
        ///       after_count_perc: &quot;32%&quot;,  # 后者总调用差异
        ///       count_perc_diff: &quot;44%&quot;,   # 调用差异
        ///   },
        ///   {...}
        /// ]&quot;</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>Error message description; empty if no error occurred</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
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
