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
        /// <item><description>If code is Success, the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate that the authorization has failed. Check the message field for the detailed fault information.</description></item>
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
        ///       name: &quot;xxx&quot;, # Operator name
        ///       before_time: 2, # Total time of the former
        ///       after_time: 4, # Total time of the latter
        ///       time_diff: 2,  # Time difference
        ///       before_time_perc: &quot;80%&quot;, # Total time percentage of the former
        ///       after_time_perc: &quot;23%&quot;, # Total time percentage of the latter
        ///       time_perc_diff: &quot;-54%&quot;,  # Time percentage difference
        ///       before_count: 1, # Total call count of the former
        ///       after_count: 2,  # Total call count of the latter
        ///       count_diff: 1,   # Call count difference
        ///       before_count_perc: &quot;56%&quot;, # Total call percentage of the former
        ///       after_count_perc: &quot;32%&quot;,  # Total call percentage of the latter
        ///       count_perc_diff: &quot;44%&quot;,   # Call percentage difference
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
