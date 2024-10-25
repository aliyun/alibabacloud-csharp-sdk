// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetAutoScalingActivityResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the scaling activity.</para>
        /// </summary>
        [NameInMap("ScalingActivity")]
        [Validation(Required=false)]
        public GetAutoScalingActivityResponseBodyScalingActivity ScalingActivity { get; set; }
        public class GetAutoScalingActivityResponseBodyScalingActivity : TeaModel {
            /// <summary>
            /// <para>The ID of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asa-36373b084d6b4b13aa50f4129a9e****</para>
            /// </summary>
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// <para>The instances that correspond to the scaling activity.</para>
            /// </summary>
            [NameInMap("ActivityResults")]
            [Validation(Required=false)]
            public List<ScalingActivityResult> ActivityResults { get; set; }

            /// <summary>
            /// <para>The status of the scaling activity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>REJECTED</description></item>
            /// <item><description>SUCCESSFUL</description></item>
            /// <item><description>FAILED</description></item>
            /// <item><description>IN_PROGRESS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN_PROGRESS</para>
            /// </summary>
            [NameInMap("ActivityState")]
            [Validation(Required=false)]
            public string ActivityState { get; set; }

            /// <summary>
            /// <para>The type of the scaling activity. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>SCALE_OUT</description></item>
            /// <item><description>SCALE_IN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SCALE_OUT</para>
            /// </summary>
            [NameInMap("ActivityType")]
            [Validation(Required=false)]
            public string ActivityType { get; set; }

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
            /// <para>The description of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clusterId not exist</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when scaling ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639715634819</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of added or removed instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ExpectNum")]
            [Validation(Required=false)]
            public int? ExpectNum { get; set; }

            /// <summary>
            /// <para>The ID of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-869471354ecd****</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The name of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-01</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>The operation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>op-13c37a77c505****</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The description of the scaling rule.</para>
            /// </summary>
            [NameInMap("RuleDetail")]
            [Validation(Required=false)]
            public ScalingRule RuleDetail { get; set; }

            /// <summary>
            /// <para>The name of the scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scaling-out-memory</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The time when scaling started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639714634819</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
