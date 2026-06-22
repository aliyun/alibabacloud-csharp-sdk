// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Operation : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The time when the operation was created. This value is a UNIX timestamp, measured in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1628589439114</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the operation ended. This value is a UNIX timestamp, measured in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1628589439114</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The operation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>op-13c37a77c505****</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The operation state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>IN_PROGRESS</c>: The operation is in progress.</para>
        /// </description></item>
        /// <item><description><para><c>COMPLETED</c>: The operation completed.</para>
        /// </description></item>
        /// <item><description><para><c>HUMAN_PROCESSING</c>: The operation requires manual intervention.</para>
        /// </description></item>
        /// <item><description><para><c>FAILED</c>: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("OperationState")]
        [Validation(Required=false)]
        public string OperationState { get; set; }

        /// <summary>
        /// <para>The operation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_CLUSTER</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The time when the operation started. This value is a UNIX timestamp, measured in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1628589439114</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The reason for the state change.</para>
        /// </summary>
        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public OperationStateChangeReason StateChangeReason { get; set; }

    }

}
