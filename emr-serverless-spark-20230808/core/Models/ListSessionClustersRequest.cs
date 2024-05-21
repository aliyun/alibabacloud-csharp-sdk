// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListSessionClustersRequest : TeaModel {
        /// <summary>
        /// 一次获取的最大记录数。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 标记当前开始读取的位置，置空表示从头开始。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("queueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 作业名称。
        /// </summary>
        [NameInMap("sessionClusterId")]
        [Validation(Required=false)]
        public string SessionClusterId { get; set; }

    }

}
