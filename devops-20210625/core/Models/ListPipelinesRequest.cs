// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelinesRequest : TeaModel {
        /// <summary>
        /// 流水线名称
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// 创建人阿里云账号Id
        /// </summary>
        [NameInMap("creatorAccountIds")]
        [Validation(Required=false)]
        public string CreatorAccountIds { get; set; }

        /// <summary>
        /// 执行人阿里云账号id
        /// </summary>
        [NameInMap("executeAccountIds")]
        [Validation(Required=false)]
        public string ExecuteAccountIds { get; set; }

        /// <summary>
        /// 状态列表，多个逗号分割
        /// </summary>
        [NameInMap("statusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// 创建开始时间
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        /// <summary>
        /// 创建结束时间
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// 执行开始时间
        /// </summary>
        [NameInMap("executeStartTime")]
        [Validation(Required=false)]
        public long? ExecuteStartTime { get; set; }

        /// <summary>
        /// 执行结束时间
        /// </summary>
        [NameInMap("executeEndTime")]
        [Validation(Required=false)]
        public long? ExecuteEndTime { get; set; }

        /// <summary>
        /// 返回的总数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 分页Token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
