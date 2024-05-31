// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListJobRunsShrinkRequest : TeaModel {
        /// <summary>
        /// 创建用户Uid。
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTimeShrink { get; set; }

        [NameInMap("jobRunDeploymentId")]
        [Validation(Required=false)]
        public string JobRunDeploymentId { get; set; }

        /// <summary>
        /// 作业id。
        /// </summary>
        [NameInMap("jobRunId")]
        [Validation(Required=false)]
        public string JobRunId { get; set; }

        /// <summary>
        /// 一次获取的最大记录数。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 作业名称。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 标记当前开始读取的位置，置空表示从头开始。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resourceQueueId")]
        [Validation(Required=false)]
        public string ResourceQueueId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTimeShrink { get; set; }

        /// <summary>
        /// 作业状态。
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public string StatesShrink { get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
