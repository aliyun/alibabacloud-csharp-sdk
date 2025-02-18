// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetComputeQuotaScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetComputeQuotaScheduleResponseBodyData> Data { get; set; }
        public class GetComputeQuotaScheduleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The value of effective condition.</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public GetComputeQuotaScheduleResponseBodyDataCondition Condition { get; set; }
            public class GetComputeQuotaScheduleResponseBodyDataCondition : TeaModel {
                /// <summary>
                /// <para>The start time when the quota plan takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09:00</para>
                /// </summary>
                [NameInMap("at")]
                [Validation(Required=false)]
                public string At { get; set; }

            }

            /// <summary>
            /// <para>The ID of the quota plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89b54db44d384f26964951ea457f64a5</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the quota plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>planA</para>
            /// </summary>
            [NameInMap("plan")]
            [Validation(Required=false)]
            public string Plan { get; set; }

            /// <summary>
            /// <para>The time zone property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UTC+8</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The type of the quota plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>daily</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QUOTA_UNKNOWN_NICKNAME</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cannot found quota **</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: informational response. The request is received and is being processed.</description></item>
        /// <item><description>2xx: success. The request is successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: redirection. The request is redirected, and further actions are required to complete the request.</description></item>
        /// <item><description>4xx: client error. The request contains invalid request parameters or syntaxes, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: server error. The server cannot meet requirements due to other reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B42CA730-8187-50F1-9FE0-6733297036DB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
