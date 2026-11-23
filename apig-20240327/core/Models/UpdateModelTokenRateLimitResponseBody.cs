// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateModelTokenRateLimitResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code of the request. The value is Ok if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The saved limits, version, and rule IDs for the current model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;gatewayId&quot;:&quot;gw-example01&quot;,&quot;modelId&quot;:&quot;msc-example01&quot;,&quot;revision&quot;:1,&quot;appliedRevision&quot;:1,&quot;globalTpm&quot;:1800,&quot;consumers&quot;:[{&quot;consumerId&quot;:&quot;cs-example01&quot;,&quot;tpm&quot;:300}],&quot;globalRuleId&quot;:&quot;model-tpm/gw-example01/msc-example01/global&quot;,&quot;consumerRuleIds&quot;:{&quot;cs-example01&quot;:&quot;model-tpm/gw-example01/msc-example01/consumer/cs-example01&quot;}}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateModelTokenRateLimitResponseBodyData Data { get; set; }
        public class UpdateModelTokenRateLimitResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration version that was last successfully delivered to the control plane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("appliedRevision")]
            [Validation(Required=false)]
            public long? AppliedRevision { get; set; }

            /// <summary>
            /// <para>The mapping of consumer IDs to model throttling rule IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cs-example01&quot;:&quot;model-tpm/gw-example01/msc-example01/consumer/cs-example01&quot;}</para>
            /// </summary>
            [NameInMap("consumerRuleIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> ConsumerRuleIds { get; set; }

            /// <summary>
            /// <para>The list of configured consumer limits for the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;consumerId&quot;:&quot;cs-example01&quot;,&quot;tpm&quot;:300}]</para>
            /// </summary>
            [NameInMap("consumers")]
            [Validation(Required=false)]
            public List<UpdateModelTokenRateLimitResponseBodyDataConsumers> Consumers { get; set; }
            public class UpdateModelTokenRateLimitResponseBodyDataConsumers : TeaModel {
                /// <summary>
                /// <para>The ID of the consumer.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs-example01</para>
                /// </summary>
                [NameInMap("consumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// <para>The tokens per minute (TPM) limit for the consumer using this model.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("tpm")]
                [Validation(Required=false)]
                public long? Tpm { get; set; }

            }

            /// <summary>
            /// <para>The instance ID of the dedicated AI gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-example01</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The rule ID for the global model limit, which can be matched with the rule hits in the gateway throttling logs. This parameter is returned only when the global limit is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-tpm/gw-example01/msc-example01/global</para>
            /// </summary>
            [NameInMap("globalRuleId")]
            [Validation(Required=false)]
            public string GlobalRuleId { get; set; }

            /// <summary>
            /// <para>The global tokens per minute (TPM) limit shared by all consumers for the model within the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("globalTpm")]
            [Validation(Required=false)]
            public long? GlobalTpm { get; set; }

            /// <summary>
            /// <para>The actual model card ID that starts with msc- or the logical model ID that starts with vm-.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msc-example01</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <para>The saved version of the model throttling configuration. Pass this value as expectedRevision for subsequent modifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

        }

        /// <summary>
        /// <para>The cause of the error. This parameter is omitted if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified gateway does not exist.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A35E9B2-4C16-4E90-8A71-24F3BB508C01</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
