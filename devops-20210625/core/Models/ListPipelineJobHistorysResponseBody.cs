// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelineJobHistorysResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<ListPipelineJobHistorysResponseBodyJobs> Jobs { get; set; }
        public class ListPipelineJobHistorysResponseBodyJobs : TeaModel {
            [NameInMap("executeNumber")]
            [Validation(Required=false)]
            public int? ExecuteNumber { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("jobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            [NameInMap("jobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("operatorAccountId")]
            [Validation(Required=false)]
            public string OperatorAccountId { get; set; }

            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }

            [NameInMap("pipelineRunId")]
            [Validation(Required=false)]
            public long? PipelineRunId { get; set; }

            [NameInMap("sources")]
            [Validation(Required=false)]
            public string Sources { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true 接口调用成功，false 接口调用失败
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
