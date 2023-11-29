// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetContextLogsResponseBody : TeaModel {
        /// <summary>
        /// The number of logs that are generated before the generation time of the start log.
        /// </summary>
        [NameInMap("back_lines")]
        [Validation(Required=false)]
        public long? BackLines { get; set; }

        /// <summary>
        /// The number of logs that are generated after the generation time of the start log.
        /// </summary>
        [NameInMap("forward_lines")]
        [Validation(Required=false)]
        public long? ForwardLines { get; set; }

        /// <summary>
        /// The logs that are returned.
        /// </summary>
        [NameInMap("logs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Logs { get; set; }

        /// <summary>
        /// Indicates whether the query and analysis results are complete. Valid values:
        /// 
        /// *   Complete: The query is successful, and the complete query and analysis results are returned.
        /// *   Incomplete: The query is successful, but the query and analysis results are incomplete. To obtain the complete results, you must repeat the request.
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

        /// <summary>
        /// The total number of logs that are returned. The logs include the start log that is specified in the request.
        /// </summary>
        [NameInMap("total_lines")]
        [Validation(Required=false)]
        public long? TotalLines { get; set; }

    }

}
