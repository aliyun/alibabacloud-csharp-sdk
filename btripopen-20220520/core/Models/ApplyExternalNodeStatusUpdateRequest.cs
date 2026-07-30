// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyExternalNodeStatusUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("node_id")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The external approval information.</para>
        /// </summary>
        [NameInMap("operation_records")]
        [Validation(Required=false)]
        public List<ApplyExternalNodeStatusUpdateRequestOperationRecords> OperationRecords { get; set; }
        public class ApplyExternalNodeStatusUpdateRequestOperationRecords : TeaModel {
            /// <summary>
            /// <para>The comment content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>评论啊</para>
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The operation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-28 11:33:28</para>
            /// </summary>
            [NameInMap("operate_time")]
            [Validation(Required=false)]
            public string OperateTime { get; set; }

            /// <summary>
            /// <para>The name of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("operator_name")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <para>The operation result.</para>
            /// <remarks>
            /// <para>Warning: This parameter is required when the operation type is approval.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>AGREE</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROCESS_APPROVE</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The process execution result.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESS_AGREE</para>
        /// </summary>
        [NameInMap("process_action_result")]
        [Validation(Required=false)]
        public string ProcessActionResult { get; set; }

    }

}
