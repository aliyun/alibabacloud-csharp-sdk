// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateComputeQuotaScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateComputeQuotaScheduleRequestBody> Body { get; set; }
        public class UpdateComputeQuotaScheduleRequestBody : TeaModel {
            /// <summary>
            /// <para>The value of effective condition.</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public UpdateComputeQuotaScheduleRequestBodyCondition Condition { get; set; }
            public class UpdateComputeQuotaScheduleRequestBodyCondition : TeaModel {
                /// <summary>
                /// <para>The start time when the quota plan takes effect.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10:00</para>
                /// </summary>
                [NameInMap("at")]
                [Validation(Required=false)]
                public string At { get; set; }

            }

            /// <summary>
            /// <para>The name of the quota plan.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>planA</para>
            /// </summary>
            [NameInMap("plan")]
            [Validation(Required=false)]
            public string Plan { get; set; }

            /// <summary>
            /// <para>The type of the quota plan.</para>
            /// <remarks>
            /// <para>Notice: Currently, only daily is supported.</notice></para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>daily</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("scheduleTimezone")]
        [Validation(Required=false)]
        public string ScheduleTimezone { get; set; }

    }

}
