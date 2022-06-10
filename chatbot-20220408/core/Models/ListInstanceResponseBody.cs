// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListInstanceResponseBody : TeaModel {
        /// <summary>
        /// 机器人列表信息
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstanceResponseBodyInstances> Instances { get; set; }
        public class ListInstanceResponseBodyInstances : TeaModel {
            /// <summary>
            /// 机器人头像的URL
            /// </summary>
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// 机器人创建的 UTC 时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 机器人唯一标识
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 机器人备注
            /// </summary>
            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            /// <summary>
            /// 机器人服务的语言
            /// </summary>
            [NameInMap("LanguageCode")]
            [Validation(Required=false)]
            public string LanguageCode { get; set; }

            /// <summary>
            /// 机器人名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 机器人类型
            /// </summary>
            [NameInMap("RobotType")]
            [Validation(Required=false)]
            public string RobotType { get; set; }

        }

        /// <summary>
        /// 分页-第几页
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页-页面大小
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
