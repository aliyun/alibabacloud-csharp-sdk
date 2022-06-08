// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartJobsResponseBody : TeaModel {
        /// <summary>
        /// 本次请求所返回的最大记录条数，最后一页前每页记录条数为MaxResults取值。  例如：  正例：10,10,5，反例：10,5,10
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// 用来表示当前调用返回读取到的位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartJobList")]
        [Validation(Required=false)]
        public List<ListSmartJobsResponseBodySmartJobList> SmartJobList { get; set; }
        public class ListSmartJobsResponseBodySmartJobList : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 任务描述
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 输入配置
            /// </summary>
            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }

            /// <summary>
            /// 任务输入配置
            /// </summary>
            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public ListSmartJobsResponseBodySmartJobListInputConfig InputConfig { get; set; }
            public class ListSmartJobsResponseBodySmartJobListInputConfig : TeaModel {
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public string InputFile { get; set; }
                [NameInMap("Keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }
            };

            /// <summary>
            /// 任务Id
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// 任务状态
            /// </summary>
            [NameInMap("JobState")]
            [Validation(Required=false)]
            public string JobState { get; set; }

            /// <summary>
            /// 任务类型
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// 最后修改时间
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// 任务输出配置
            /// </summary>
            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public ListSmartJobsResponseBodySmartJobListOutputConfig OutputConfig { get; set; }
            public class ListSmartJobsResponseBodySmartJobListOutputConfig : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }
            };

            /// <summary>
            /// 任务标题
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 用户自定义字段
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// 用户Id
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
