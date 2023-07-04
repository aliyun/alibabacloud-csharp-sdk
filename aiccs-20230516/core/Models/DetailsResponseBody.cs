// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class DetailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public DetailsResponseBodyModel Model { get; set; }
        public class DetailsResponseBodyModel : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DetailsResponseBodyModelList> List { get; set; }
            public class DetailsResponseBodyModelList : TeaModel {
                /// <summary>
                /// 批次号
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public long? BatchId { get; set; }

                /// <summary>
                /// 呼叫状态描述
                /// </summary>
                [NameInMap("CallDesc")]
                [Validation(Required=false)]
                public string CallDesc { get; set; }

                /// <summary>
                /// 外呼ID
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// 呼叫状态
                /// </summary>
                [NameInMap("CallStatus")]
                [Validation(Required=false)]
                public long? CallStatus { get; set; }

                /// <summary>
                /// 外呼类型
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public long? CallType { get; set; }

                /// <summary>
                /// 导入时间
                /// </summary>
                [NameInMap("ImportTime")]
                [Validation(Required=false)]
                public string ImportTime { get; set; }

                /// <summary>
                /// 拦截原因
                /// </summary>
                [NameInMap("InterceptReason")]
                [Validation(Required=false)]
                public string InterceptReason { get; set; }

                /// <summary>
                /// 外呼号码
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// 号码状态描述
                /// </summary>
                [NameInMap("NumberDesc")]
                [Validation(Required=false)]
                public string NumberDesc { get; set; }

                /// <summary>
                /// 外呼号码MD5
                /// </summary>
                [NameInMap("NumberMD5")]
                [Validation(Required=false)]
                public string NumberMD5 { get; set; }

                /// <summary>
                /// 号码状态
                /// </summary>
                [NameInMap("NumberStatus")]
                [Validation(Required=false)]
                public long? NumberStatus { get; set; }

                /// <summary>
                /// 用户自定义标签
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// 任务ID
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public float? TotalPage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
