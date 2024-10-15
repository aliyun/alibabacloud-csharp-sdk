// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyExternalNodeStatusUpdateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("node_id")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("operation_records")]
        [Validation(Required=false)]
        public List<ApplyExternalNodeStatusUpdateRequestOperationRecords> OperationRecords { get; set; }
        public class ApplyExternalNodeStatusUpdateRequestOperationRecords : TeaModel {
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-28 11:33:28</para>
            /// </summary>
            [NameInMap("operate_time")]
            [Validation(Required=false)]
            public string OperateTime { get; set; }

            [NameInMap("operator_name")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AGREE</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROCESS_APPROVE</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
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
