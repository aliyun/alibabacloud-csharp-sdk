// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackDriftDetectionStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the drift detection operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7044f0d-6f2e-4128-a307-4524ef88****</para>
        /// </summary>
        [NameInMap("DriftDetectionId")]
        [Validation(Required=false)]
        public string DriftDetectionId { get; set; }

        /// <summary>
        /// <para>The drift detection status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DETECTION_COMPLETE: The drift detection operation has been completed for all resources that support drift detection in the stack.</description></item>
        /// <item><description>DETECTION_FAILED: The stack drift detection operation has failed for at least one resource in the stack.</description></item>
        /// <item><description>DETECTION_IN_PROGRESS: The stack drift detection operation is in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DETECTION_COMPLETE</para>
        /// </summary>
        [NameInMap("DriftDetectionStatus")]
        [Validation(Required=false)]
        public string DriftDetectionStatus { get; set; }

        /// <summary>
        /// <para>The reason why the stack drift detection operation has its current status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Detect stack drift successfully</para>
        /// </summary>
        [NameInMap("DriftDetectionStatusReason")]
        [Validation(Required=false)]
        public string DriftDetectionStatusReason { get; set; }

        /// <summary>
        /// <para>The time when the stack drift detection operation was initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-27T07:47:47</para>
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// <para>The total number of stack resources that have drifted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DriftedStackResourceCount")]
        [Validation(Required=false)]
        public int? DriftedStackResourceCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The drift status of the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DRIFTED: The actual configuration of the stack differs, or has drifted, from its expected template configuration. A stack is considered to have drifted if one or more of its resources have drifted.</description></item>
        /// <item><description>NOT_CHECKED: Resource Orchestration Service (ROS) has not checked whether the actual configuration of the resource differs from its expected template configuration.</description></item>
        /// <item><description>IN_SYNC: The current configuration of each supported resource matches its expected template configuration. A stack with no resources that support drift detection also has a status of IN_SYNC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DRIFTED</para>
        /// </summary>
        [NameInMap("StackDriftStatus")]
        [Validation(Required=false)]
        public string StackDriftStatus { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
