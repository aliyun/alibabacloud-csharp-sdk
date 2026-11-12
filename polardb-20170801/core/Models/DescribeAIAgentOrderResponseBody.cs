// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIAgentOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The AI assistant version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The capacity package specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>small</para>
        /// </summary>
        [NameInMap("CapacityPack")]
        [Validation(Required=false)]
        public string CapacityPack { get; set; }

        /// <summary>
        /// <para>The expiration time of the order in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the current account has an AI assistant order.</para>
        /// </summary>
        [NameInMap("HasOrder")]
        [Validation(Required=false)]
        public bool? HasOrder { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-001</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The order name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-copilot-001</para>
        /// </summary>
        [NameInMap("OrderName")]
        [Validation(Required=false)]
        public string OrderName { get; set; }

        /// <summary>
        /// <para>The order number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ord-001</para>
        /// </summary>
        [NameInMap("OrderNum")]
        [Validation(Required=false)]
        public string OrderNum { get; set; }

        /// <summary>
        /// <para>The order status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
