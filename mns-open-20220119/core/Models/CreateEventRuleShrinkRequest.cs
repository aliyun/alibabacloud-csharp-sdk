// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class CreateEventRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request.</para>
        /// <para>Generate a unique value for this parameter from your client for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
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
        public string EndpointShrink { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. Use Endpoint instead.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public string EndpointsShrink { get; set; }

        /// <summary>
        /// <para>A list of event types.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public string EventTypesShrink { get; set; }

        /// <summary>
        /// <para>A list of matching rules. The logical relationship between the rules is OR.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MatchRules")]
        [Validation(Required=false)]
        public string MatchRulesShrink { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud product for which you want to receive event notifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The name of the event rule.</para>
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
