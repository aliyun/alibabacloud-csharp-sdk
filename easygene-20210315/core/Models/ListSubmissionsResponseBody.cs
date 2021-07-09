// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListSubmissionsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 最大返回结果
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 下次查询Token
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 返回个数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 投递列表
        /// </summary>
        [NameInMap("Submissions")]
        [Validation(Required=false)]
        public List<ListSubmissionsResponseBodySubmissions> Submissions { get; set; }
        public class ListSubmissionsResponseBodySubmissions : TeaModel {
            /// <summary>
            /// 提交ID
            /// </summary>
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

            /// <summary>
            /// 提交ID
            /// </summary>
            [NameInMap("SubmissionId")]
            [Validation(Required=false)]
            public string SubmissionId { get; set; }

            /// <summary>
            /// 任务状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 提交时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// 实体类型
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("RunStats")]
            [Validation(Required=false)]
            public ListSubmissionsResponseBodySubmissionsRunStats RunStats { get; set; }
            public class ListSubmissionsResponseBodySubmissionsRunStats : TeaModel {
                [NameInMap("Submitted")]
                [Validation(Required=false)]
                public long? Submitted { get; set; }
                [NameInMap("Pending")]
                [Validation(Required=false)]
                public long? Pending { get; set; }
                [NameInMap("Running")]
                [Validation(Required=false)]
                public long? Running { get; set; }
                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }
                [NameInMap("Aborting")]
                [Validation(Required=false)]
                public long? Aborting { get; set; }
                [NameInMap("Aborted")]
                [Validation(Required=false)]
                public long? Aborted { get; set; }
            };

        }

    }

}
