// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetContextLogsResponseBody : TeaModel {
        /// <summary>
        /// 向前查询到的日志条数。
        /// </summary>
        [NameInMap("back_lines")]
        [Validation(Required=false)]
        public long? BackLines { get; set; }

        /// <summary>
        /// 向后查询到的日志条数。
        /// </summary>
        [NameInMap("forward_lines")]
        [Validation(Required=false)]
        public long? ForwardLines { get; set; }

        /// <summary>
        /// 获取到的日志，按上下文顺序排列。当根据指定起始日志查询不到上下文日志时，此参数为空。
        /// </summary>
        [NameInMap("logs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Logs { get; set; }

        /// <summary>
        /// 查询的结果是否完整。
        /// Complete：查询已经完成，返回结果为完整结果。
        /// Incomplete：查询已经完成，返回结果为不完整结果，需要重复请求以获得完整结果。
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

        /// <summary>
        /// 返回的总日志条数，包含请求参数中所指定的起始日志。
        /// </summary>
        [NameInMap("total_lines")]
        [Validation(Required=false)]
        public long? TotalLines { get; set; }

    }

}
