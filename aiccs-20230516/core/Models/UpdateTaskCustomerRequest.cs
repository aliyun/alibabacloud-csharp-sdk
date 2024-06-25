// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class UpdateTaskCustomerRequest : TeaModel {
        /// <summary>
        /// 外呼客户
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Customers")]
        [Validation(Required=false)]
        public List<UpdateTaskCustomerRequestCustomers> Customers { get; set; }
        public class UpdateTaskCustomerRequestCustomers : TeaModel {
            /// <summary>
            /// 是否取消外呼 0否，1是
            /// </summary>
            [NameInMap("Cancel")]
            [Validation(Required=false)]
            public long? Cancel { get; set; }

            /// <summary>
            /// 电话号码
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// 需根据具体任务参数要求传输
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// 用户自定义标签
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// 任务ID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
