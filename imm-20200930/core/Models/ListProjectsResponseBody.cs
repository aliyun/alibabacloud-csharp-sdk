// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// 当总结果个数大于MaxResults时，用于翻页的token
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 由ProjectItem组成的数组
        /// </summary>
        [NameInMap("Projects")]
        [Validation(Required=false)]
        public List<Project> Projects { get; set; }

        /// <summary>
        /// 本次请求的唯一 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
