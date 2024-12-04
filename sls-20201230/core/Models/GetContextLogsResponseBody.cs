// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetContextLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of logs that are generated before the generation time of the start log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("back_lines")]
        [Validation(Required=false)]
        public long? BackLines { get; set; }

        /// <summary>
        /// <para>The number of logs that are generated after the generation time of the start log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("forward_lines")]
        [Validation(Required=false)]
        public long? ForwardLines { get; set; }

        /// <summary>
        /// <para>The logs that are returned.</para>
        /// </summary>
        [NameInMap("logs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Logs { get; set; }

        /// <summary>
        /// <para>Indicates whether the query and analysis results are complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Complete: The query is successful, and the complete query and analysis results are returned.</description></item>
        /// <item><description>Incomplete: The query is successful, but the query and analysis results are incomplete. To obtain the complete results, you must repeat the request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Complete</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

        /// <summary>
        /// <para>The total number of logs that are returned. The logs include the start log that is specified in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201</para>
        /// </summary>
        [NameInMap("total_lines")]
        [Validation(Required=false)]
        public long? TotalLines { get; set; }

    }

}
