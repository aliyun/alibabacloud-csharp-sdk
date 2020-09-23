// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesResponseBody : TeaModel {
        /// <summary>
        /// 节点信息列表。
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<AttachInstancesResponseBodyList> List { get; set; }
        public class AttachInstancesResponseBodyList : TeaModel {
            /// <summary>
            /// 状态码。
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 实例ID。
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 添加结果描述。
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
