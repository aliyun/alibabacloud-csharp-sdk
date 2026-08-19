// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ModifyForwardStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The forwarding rule.</para>
        /// </summary>
        [NameInMap("ForwardStrategy")]
        [Validation(Required=false)]
        public ModifyForwardStrategyResponseBodyForwardStrategy ForwardStrategy { get; set; }
        public class ModifyForwardStrategyResponseBodyForwardStrategy : TeaModel {
            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>material_versions_rec</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The target instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-f0b9195a6f2597fa</para>
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
            /// <para>The forwarding rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fs-037cee3b6ebaa919</para>
            /// </summary>
            [NameInMap("ForwardId")]
            [Validation(Required=false)]
            public string ForwardId { get; set; }

            /// <summary>
            /// <para>The name of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SaseSSO</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The policy status. Valid values:</para>
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
        /// <para>2EBEEB93-E7AF-5667-B492-FA95C70821A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
