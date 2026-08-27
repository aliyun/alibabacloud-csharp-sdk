// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class QueryFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The queried feature information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFeaturesResponseBodyData Data { get; set; }
        public class QueryFeaturesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of features.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<QueryFeaturesResponseBodyDataFeatures> Features { get; set; }
            public class QueryFeaturesResponseBodyDataFeatures : TeaModel {
                /// <summary>
                /// <para>The feature description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Supports mounting an OSS bucket to an Agent container.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The feature display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS Mount.</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The feature code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS_MOUNT</para>
                /// </summary>
                [NameInMap("FeatureCode")]
                [Validation(Required=false)]
                public string FeatureCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the feature is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Supported")]
                [Validation(Required=false)]
                public bool? Supported { get; set; }

                /// <summary>
                /// <para>The detailed reason why the feature is not supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The current base version does not support this feature.</para>
                /// </summary>
                [NameInMap("UnsupportedReason")]
                [Validation(Required=false)]
                public string UnsupportedReason { get; set; }

                /// <summary>
                /// <para>The reason code for why the feature is not supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BASE_VERSION_UNSUPPORTED: The base version does not support this feature.</description></item>
                /// <item><description>WORKER_VERSION_UNSUPPORTED: The worker version does not support this feature.</description></item>
                /// <item><description>FEATURE_DISABLED: The feature is disabled.</description></item>
                /// <item><description>FEATURE_DEPRECATED: The feature is deprecated.</description></item>
                /// <item><description>OVERRIDDEN_DENY: The feature is denied by an override.</description></item>
                /// <item><description>CUSTOM_RULE_UNSUPPORTED: A custom rule does not support this feature.</description></item>
                /// <item><description>VERSION_METADATA_MISSING: The version metadata is missing.</description></item>
                /// <item><description>RULE_NOT_MATCHED: No rule is matched.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BASE_VERSION_UNSUPPORTED</para>
                /// </summary>
                [NameInMap("UnsupportedReasonCode")]
                [Validation(Required=false)]
                public string UnsupportedReasonCode { get; set; }

            }

            /// <summary>
            /// <para>The AgentTeams instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>at-xxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The target resource name. Required for <c>WORKER</c>, <c>TEAM</c>, and <c>HUMAN</c>. Not required for <c>INSTANCE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The query target type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INSTANCE: instance level</description></item>
            /// <item><description>WORKER: worker level</description></item>
            /// <item><description>TEAM: team level</description></item>
            /// <item><description>HUMAN: human level</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("TargetScope")]
            [Validation(Required=false)]
            public string TargetScope { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
