// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListForwardStrategiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of forwarding rules.</para>
        /// </summary>
        [NameInMap("ForwardStrategies")]
        [Validation(Required=false)]
        public List<ListForwardStrategiesResponseBodyForwardStrategies> ForwardStrategies { get; set; }
        public class ListForwardStrategiesResponseBodyForwardStrategies : TeaModel {
            /// <summary>
            /// <para>The description of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdasdasd</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-4178bc59bec56df1</para>
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// <para>The type of the access destination. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Connector</b>: connector.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connector</para>
            /// </summary>
            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            /// <summary>
            /// <para>The ID of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fs-8b299ac5a93a0a3a</para>
            /// </summary>
            [NameInMap("ForwardId")]
            [Validation(Required=false)]
            public string ForwardId { get; set; }

            /// <summary>
            /// <para>The name of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>白名单加速</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The policy priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E850D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
