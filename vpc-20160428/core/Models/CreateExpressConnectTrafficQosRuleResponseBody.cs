// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressConnectTrafficQosRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-2giu0a6vd5x0mv4700</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The ID of the QoS queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-9nyx2u7n71s2rcy4n5</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>606998F0-B94D-48FE-8316-ACA81BB230DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the QoS rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-rule-iugg0l9x27f2nocouj</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
