// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateModelLimitsRequest : TeaModel {
        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-ac3ef438bec22dc5</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The throttling values for the workspace.</para>
        /// </summary>
        [NameInMap("workspaceLimits")]
        [Validation(Required=false)]
        public List<UpdateModelLimitsRequestWorkspaceLimits> WorkspaceLimits { get; set; }
        public class UpdateModelLimitsRequestWorkspaceLimits : TeaModel {
            /// <summary>
            /// <para>The model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The throttling operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OVERLAY</b>: Sets or overwrites the throttling configuration.</description></item>
            /// <item><description><b>DELETE</b>: Deletes the throttling configuration (restores to no throttling).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OVERLAY</para>
            /// </summary>
            [NameInMap("operationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The request throttling value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("requestLimit")]
            [Validation(Required=false)]
            public long? RequestLimit { get; set; }

            /// <summary>
            /// <para>The time period for request throttling. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("requestLimitPeriod")]
            [Validation(Required=false)]
            public long? RequestLimitPeriod { get; set; }

            /// <summary>
            /// <para>The usage throttling value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("usageLimit")]
            [Validation(Required=false)]
            public long? UsageLimit { get; set; }

            /// <summary>
            /// <para>The time period for usage throttling. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("usageLimitPeriod")]
            [Validation(Required=false)]
            public long? UsageLimitPeriod { get; set; }

        }

    }

}
