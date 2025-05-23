// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class UpdateTaskCustomerRequest : TeaModel {
        /// <summary>
        /// <para>外呼客户</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Customers")]
        [Validation(Required=false)]
        public List<UpdateTaskCustomerRequestCustomers> Customers { get; set; }
        public class UpdateTaskCustomerRequestCustomers : TeaModel {
            /// <summary>
            /// <para>是否取消外呼 0否，1是</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Cancel")]
            [Validation(Required=false)]
            public long? Cancel { get; set; }

            /// <summary>
            /// <para>电话号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>13661109390</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <para>需根据具体任务参数要求传输</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;test&quot;:&quot;234&quot;}</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <para>用户自定义标签</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
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
        /// <para>任务ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
