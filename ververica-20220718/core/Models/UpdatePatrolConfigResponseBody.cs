// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdatePatrolConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The inspection configuration response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdatePatrolConfigResponseBodyData Data { get; set; }
        public class UpdatePatrolConfigResponseBodyData : TeaModel {
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
            /// <para>Specifies whether to enable the inspection.</para>
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
            public UpdatePatrolConfigResponseBodyDataScopeConfig ScopeConfig { get; set; }
            public class UpdatePatrolConfigResponseBodyDataScopeConfig : TeaModel {
                /// <summary>
                /// <para>The list of deployment IDs. This parameter is valid only when scopeType is set to DEPLOYMENTS.</para>
                /// </summary>
                [NameInMap("deploymentIds")]
                [Validation(Required=false)]
                public List<string> DeploymentIds { get; set; }

                /// <summary>
                /// <para>The tag mapping. This parameter is valid only when scopeType is set to TAGS. The key is the tag name, and the value is a list of tag values.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public Dictionary<string, List<string>> Tags { get; set; }

            }

            /// <summary>
            /// <para>The inspection scope type.</para>
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
            /// <para>a14bda1c4a****</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is not empty when success is false. This parameter is empty when success is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is not empty when success is false. This parameter is empty when success is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code, which is always 200. Use the success parameter to determine whether the request was successful.</para>
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
