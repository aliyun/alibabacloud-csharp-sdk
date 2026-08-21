// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class StartAIDiffAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization is successful.</description></item>
        /// <item><description>Other status codes indicate authorization failed. Check the <c>message</c> field for the detailed fault information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The AI differential analysis result data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;[
        ///   {
        ///       name: &quot;xxx&quot;, #operator name
        ///       before_time: 2, # total time of the former
        ///       after_time: 4, # total time of the latter
        ///       time_diff: 2,  # time difference
        ///       before_time_perc: &quot;80%&quot;, # total time percentage of the former
        ///       after_time_perc: &quot;23%&quot;, # total time percentage of the latter
        ///       time_perc_diff: &quot;-54%&quot;,  # time percentage difference
        ///       before_count: 1, # total call count of the former
        ///       after_count: 2,  # total call count of the latter
        ///       count_diff: 1,   # call count difference
        ///       before_count_perc: &quot;56%&quot;, # total call percentage of the former
        ///       after_count_perc: &quot;32%&quot;,  # total call percentage of the latter
        ///       count_perc_diff: &quot;44%&quot;,   # call percentage difference
        ///   },
        ///   {...}
        /// ]&quot;</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error code description. This field is empty if no error occurs.</para>
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
