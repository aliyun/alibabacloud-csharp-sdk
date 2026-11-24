// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetForwardStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The forwarding rule.</para>
        /// </summary>
        [NameInMap("ForwardStrategy")]
        [Validation(Required=false)]
        public GetForwardStrategyResponseBodyForwardStrategy ForwardStrategy { get; set; }
        public class GetForwardStrategyResponseBodyForwardStrategy : TeaModel {
            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>solemn_index</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The target instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-bb95f515b6818623</para>
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// <para>The destination type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Connector</b>: Connector.</description></item>
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
            /// <para>fs-b87a2f8e863bf02c</para>
            /// </summary>
            [NameInMap("ForwardId")]
            [Validation(Required=false)]
            public string ForwardId { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dynamic_route_name_eb55d3a3</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The policy priority. A value of 1 indicates the highest priority, and a value of 100 indicates the lowest priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

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
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
