// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RunRCInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance IDs (InstanceIdSet).</para>
        /// </summary>
        [NameInMap("InstanceIdSets")]
        [Validation(Required=false)]
        public RunRCInstancesResponseBodyInstanceIdSets InstanceIdSets { get; set; }
        public class RunRCInstancesResponseBodyInstanceIdSets : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<string> InstanceIdSet { get; set; }

        }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>237850846720798</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>535BD857-E88F-5B4F-A18C-FAF59A74741F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
