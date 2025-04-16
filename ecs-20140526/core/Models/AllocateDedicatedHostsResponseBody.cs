// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AllocateDedicatedHostsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of dedicated host IDs.</para>
        /// </summary>
        [NameInMap("DedicatedHostIdSets")]
        [Validation(Required=false)]
        public AllocateDedicatedHostsResponseBodyDedicatedHostIdSets DedicatedHostIdSets { get; set; }
        public class AllocateDedicatedHostsResponseBodyDedicatedHostIdSets : TeaModel {
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public List<string> DedicatedHostId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the order.</para>
        /// <remarks>
        /// <para> This parameter has a return value only when the dedicated host is a subscription one (request parameter <b>ChargeType set to PrePaid</b>).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23841229****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2A664A6-2933-4C64-88AE-5033D003****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
