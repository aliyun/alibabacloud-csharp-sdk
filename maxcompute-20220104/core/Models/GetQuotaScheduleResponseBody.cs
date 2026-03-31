// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetQuotaScheduleResponseBodyData> Data { get; set; }
        public class GetQuotaScheduleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The condition value.</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public GetQuotaScheduleResponseBodyDataCondition Condition { get; set; }
            public class GetQuotaScheduleResponseBodyDataCondition : TeaModel {
                /// <summary>
                /// <para>The start time when the quota plan takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-25T04:23:04Z</para>
                /// </summary>
                [NameInMap("after")]
                [Validation(Required=false)]
                public string After { get; set; }

                /// <summary>
                /// <para>The time when the quota plan takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0900</para>
                /// </summary>
                [NameInMap("at")]
                [Validation(Required=false)]
                public string At { get; set; }

            }

            /// <summary>
            /// <para>The ID of the quota plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userA</para>
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

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
            /// <para>The time zone.</para>
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
            /// <para>once</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value of success was false, an error code was returned.</description></item>
        /// <item><description>If the value of success was true, a null value was returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>errorMsg</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc059b716696296266308790e0d3e</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
