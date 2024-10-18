// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateTodoTaskExecutorStatusRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdateTodoTaskExecutorStatusRequestTenantContext TenantContext { get; set; }
        public class UpdateTodoTaskExecutorStatusRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("executorStatusList")]
        [Validation(Required=false)]
        public List<UpdateTodoTaskExecutorStatusRequestExecutorStatusList> ExecutorStatusList { get; set; }
        public class UpdateTodoTaskExecutorStatusRequestExecutorStatusList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>userId</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15002141</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
