// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateForwardStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The traffic forwarding rule.</para>
        /// </summary>
        [NameInMap("ForwardStrategy")]
        [Validation(Required=false)]
        public CreateForwardStrategyResponseBodyForwardStrategy ForwardStrategy { get; set; }
        public class CreateForwardStrategyResponseBodyForwardStrategy : TeaModel {
            /// <summary>
            /// <para>The description of the traffic forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The target instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-af9b4ee6fd15d82d</para>
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// <para>The destination type. Valid values:</para>
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
            /// <para>The ID of the traffic forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fs-345d6ab82b5a43a3</para>
            /// </summary>
            [NameInMap("ForwardId")]
            [Validation(Required=false)]
            public string ForwardId { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xftp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The policy priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The status of the internal-facing access application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: enabled.</description></item>
            /// <item><description><b>Disabled</b>: disabled.</description></item>
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
        /// <para>60D4601C-B693-51A8-BB30-0944CE500B75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
