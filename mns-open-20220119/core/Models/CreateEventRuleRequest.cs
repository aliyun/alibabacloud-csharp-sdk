// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class CreateEventRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate a value for this parameter on the client side and ensure that the value is unique across different requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This field is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--</para>
        /// </summary>
        [NameInMap("DeliveryMode")]
        [Validation(Required=false)]
        public string DeliveryMode { get; set; }

        /// <summary>
        /// <para>The endpoint that receives messages for this subscription.</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public CreateEventRuleRequestEndpoint Endpoint { get; set; }
        public class CreateEventRuleRequestEndpoint : TeaModel {
            /// <summary>
            /// <para>The ARN of the role for cross-account delivery. This parameter is required when EndpointType is set to queue and EndpointValue is set to the ARN of a cross-account queue, which means the account that owns the queue is different from the current account. Format: acs:ram::<UID of the account that owns the queue>:role/<Role name>. The role must be created by the account that owns the queue. The trust policy must allow the delivery account to assume the role, and the role must be granted permissions to send messages to the destination queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram:1234567890:role/CrossAccountQueueRole</para>
            /// </summary>
            [NameInMap("EndpointRoleName")]
            [Validation(Required=false)]
            public string EndpointRoleName { get; set; }

            /// <summary>
            /// <para>The endpoint type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>topic</b>: Topic type. Topics support delivery to multiple subscription endpoints. You can add or remove subscription endpoints later.</description></item>
            /// <item><description><b>queue</b>: Queue type. Messages are delivered directly to the queue. This reduces the routing path, but you cannot add new subscription endpoints later.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>topic</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The actual value of the endpoint. If EndpointType is set to topic, this parameter specifies the topic name. If EndpointType is set to queue, this parameter specifies the queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-topic</para>
            /// </summary>
            [NameInMap("EndpointValue")]
            [Validation(Required=false)]
            public string EndpointValue { get; set; }

        }

        /// <summary>
        /// <para><b>[Deprecated]</b> This field is deprecated. Use the Endpoint parameter instead.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateEventRuleRequestEndpoints> Endpoints { get; set; }
        public class CreateEventRuleRequestEndpoints : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated. Use Endpoint.EndpointType instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated. Use Endpoint.EndpointValue instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-xxx-queue</para>
            /// </summary>
            [NameInMap("EndpointValue")]
            [Validation(Required=false)]
            public string EndpointValue { get; set; }

        }

        /// <summary>
        /// <para>The list of event types. Valid values depend on the selected cloud service. For example, if OSS is selected, common values include ObjectCreated:PutObject and ObjectRemoved:DeleteObject. For more information, see the event notification documentation for each cloud service.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// <para>The list of matching rules. A maximum of 10 rules can be specified at the outer level. The rules are connected by the OR operator.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MatchRules")]
        [Validation(Required=false)]
        public List<List<EventMatchRule>> MatchRules { get; set; }

        /// <summary>
        /// <para>The name of the cloud service for event notification. Currently, only OSS is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The name of the event notification rule. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-xsXDW</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
