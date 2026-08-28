// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetPatrolConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The inspection configuration response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPatrolConfigResponseBodyData Data { get; set; }
        public class GetPatrolConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration creation time, in milliseconds (UNIX timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1756200000000</para>
            /// </summary>
            [NameInMap("configCreatedAt")]
            [Validation(Required=false)]
            public long? ConfigCreatedAt { get; set; }

            /// <summary>
            /// <para>The configuration update time, in milliseconds (UNIX timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1756250000000</para>
            /// </summary>
            [NameInMap("configUpdatedAt")]
            [Validation(Required=false)]
            public long? ConfigUpdatedAt { get; set; }

            /// <summary>
            /// <para>The cron expression that defines the inspection scheduling time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 2 * * *</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>Indicates whether inspection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-namespace</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The next inspection time, in milliseconds (UNIX timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1756260000000</para>
            /// </summary>
            [NameInMap("nextPatrolAt")]
            [Validation(Required=false)]
            public long? NextPatrolAt { get; set; }

            /// <summary>
            /// <para>The inspection scope configuration.</para>
            /// </summary>
            [NameInMap("scopeConfig")]
            [Validation(Required=false)]
            public GetPatrolConfigResponseBodyDataScopeConfig ScopeConfig { get; set; }
            public class GetPatrolConfigResponseBodyDataScopeConfig : TeaModel {
                /// <summary>
                /// <para>The list of deployment IDs. This field is valid only when scopeType is set to DEPLOYMENTS.</para>
                /// </summary>
                [NameInMap("deploymentIds")]
                [Validation(Required=false)]
                public List<string> DeploymentIds { get; set; }

                /// <summary>
                /// <para>The tag mapping. This field is valid only when scopeType is set to TAGS. The key is the tag name, and the value is the list of tag values.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public Dictionary<string, List<string>> Tags { get; set; }

            }

            /// <summary>
            /// <para>The inspection scope type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL: inspects all deployments.</description></item>
            /// <item><description>TAGS: filters deployments by tag.</description></item>
            /// <item><description>DEPLOYMENTS: inspects specified deployments.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edcef******b4f</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The error code. This field is not empty when success is false. This field is empty when success is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message. This field is not empty when success is false. This field is empty when success is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is always 200. Use the success field to determine whether the request was successful.</para>
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
        /// <para>CBC799F0-AS7S-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
