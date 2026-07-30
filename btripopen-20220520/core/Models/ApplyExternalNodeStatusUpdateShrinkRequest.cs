// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyExternalNodeStatusUpdateShrinkRequest : TeaModel {
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
        public string OperationRecordsShrink { get; set; }

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
