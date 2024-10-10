// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleActionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The actions of the lifecycle hook.</para>
        /// </summary>
        [NameInMap("LifecycleActions")]
        [Validation(Required=false)]
        public List<DescribeLifecycleActionsResponseBodyLifecycleActions> LifecycleActions { get; set; }
        public class DescribeLifecycleActionsResponseBodyLifecycleActions : TeaModel {
            /// <summary>
            /// <para>The IDs of the ECS instances on which the lifecycle hook takes effect</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The subsequent action that Auto Scaling performs after the lifecycle hook times out. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONTINUE: Auto Scaling continues to respond to a scale-in or scale-out request.</description></item>
            /// <item><description>ABANDON: Auto Scaling releases ECS instances that are created during scale-out events, or removes ECS instances from the scaling group during scale-in events.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CONTINUE</para>
            /// </summary>
            [NameInMap("LifecycleActionResult")]
            [Validation(Required=false)]
            public string LifecycleActionResult { get; set; }

            /// <summary>
            /// <para>The status of the lifecycle hook action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("LifecycleActionStatus")]
            [Validation(Required=false)]
            public string LifecycleActionStatus { get; set; }

            /// <summary>
            /// <para>The token of the lifecycle hook action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9C2E9DA7-F794-449A-ACF6-CEE24444F7BB</para>
            /// </summary>
            [NameInMap("LifecycleActionToken")]
            [Validation(Required=false)]
            public string LifecycleActionToken { get; set; }

            /// <summary>
            /// <para>The ID of the lifecycle hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ash-bp18uoft0deax0f7****</para>
            /// </summary>
            [NameInMap("LifecycleHookId")]
            [Validation(Required=false)]
            public string LifecycleHookId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAcSz4VTb1Nq****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42A742EB-FCF3-459E-9C62-E107048C17E3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the queried lifecycle actions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
