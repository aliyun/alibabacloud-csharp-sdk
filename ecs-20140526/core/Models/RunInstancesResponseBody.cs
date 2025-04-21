// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance IDs (<c>InstanceIdSet</c>).</para>
        /// </summary>
        [NameInMap("InstanceIdSets")]
        [Validation(Required=false)]
        public RunInstancesResponseBodyInstanceIdSets InstanceIdSets { get; set; }
        public class RunInstancesResponseBodyInstanceIdSets : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<string> InstanceIdSet { get; set; }

        }

        /// <summary>
        /// <para>The ID of the order. This parameter is returned only when <c>InstanceChargeType</c> is set to PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The transaction price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.165</para>
        /// </summary>
        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
