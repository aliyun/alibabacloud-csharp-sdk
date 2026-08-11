// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListModelLimitsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The model throttling information.</para>
        /// </summary>
        [NameInMap("limits")]
        [Validation(Required=false)]
        public List<ListModelLimitsResponseBodyLimits> Limits { get; set; }
        public class ListModelLimitsResponseBodyLimits : TeaModel {
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
            /// <para>The model throttling configuration for the current user account.</para>
            /// </summary>
            [NameInMap("modelLimit")]
            [Validation(Required=false)]
            public ListModelLimitsResponseBodyLimitsModelLimit ModelLimit { get; set; }
            public class ListModelLimitsResponseBodyLimitsModelLimit : TeaModel {
                /// <summary>
                /// <para>The maximum concurrency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("asyncUserConcurrencyLimit")]
                [Validation(Required=false)]
                public long? AsyncUserConcurrencyLimit { get; set; }

                /// <summary>
                /// <para>The queue size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("asyncUserQueueLimit")]
                [Validation(Required=false)]
                public long? AsyncUserQueueLimit { get; set; }

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
                /// <para>The time period for request throttling, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("requestLimitPeriod")]
                [Validation(Required=false)]
                public int? RequestLimitPeriod { get; set; }

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
                /// <para>The usage throttling unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("usageLimitField")]
                [Validation(Required=false)]
                public string UsageLimitField { get; set; }

                /// <summary>
                /// <para>The time period for usage throttling, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("usageLimitPeriod")]
                [Validation(Required=false)]
                public int? UsageLimitPeriod { get; set; }

            }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The custom model throttling configuration for the current workspace.</para>
            /// </summary>
            [NameInMap("workspaceLimit")]
            [Validation(Required=false)]
            public ListModelLimitsResponseBodyLimitsWorkspaceLimit WorkspaceLimit { get; set; }
            public class ListModelLimitsResponseBodyLimitsWorkspaceLimit : TeaModel {
                /// <summary>
                /// <para>The maximum concurrency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("asyncUserConcurrencyLimit")]
                [Validation(Required=false)]
                public long? AsyncUserConcurrencyLimit { get; set; }

                /// <summary>
                /// <para>The queue size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("asyncUserQueueLimit")]
                [Validation(Required=false)]
                public long? AsyncUserQueueLimit { get; set; }

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
                /// <para>The time period for request throttling, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("requestLimitPeriod")]
                [Validation(Required=false)]
                public int? RequestLimitPeriod { get; set; }

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
                /// <para>The usage throttling unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>token</para>
                /// </summary>
                [NameInMap("usageLimitField")]
                [Validation(Required=false)]
                public string UsageLimitField { get; set; }

                /// <summary>
                /// <para>The time period for usage throttling, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("usageLimitPeriod")]
                [Validation(Required=false)]
                public int? UsageLimitPeriod { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of records returned in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lwytFRtLdNk=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>36045E0A-551D-592D-B1BC-4C56596CE59E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
