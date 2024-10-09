// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancesTrafficPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data transfers that exceed the quota of the data transfer plan in the current month. Unit: bytes.</para>
        /// </summary>
        [NameInMap("InstanceTrafficPackageUsages")]
        [Validation(Required=false)]
        public List<ListInstancesTrafficPackagesResponseBodyInstanceTrafficPackageUsages> InstanceTrafficPackageUsages { get; set; }
        public class ListInstancesTrafficPackagesResponseBodyInstanceTrafficPackageUsages : TeaModel {
            /// <summary>
            /// <para>The ID of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccscqwqwqqqw****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The data transfers that exceeds the quota of the data transfer plan in the current month. Unit: Byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TrafficOverflow")]
            [Validation(Required=false)]
            public long? TrafficOverflow { get; set; }

            /// <summary>
            /// <para>The unused quota of the data transfer plan in the current month. Unit: Byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("TrafficPackageRemaining")]
            [Validation(Required=false)]
            public long? TrafficPackageRemaining { get; set; }

            /// <summary>
            /// <para>The quota of the data transfer plan in the current month. Unit: Byte.</para>
            /// <remarks>
            /// <para> TrafficPackageTotal = TrafficUsed + TrafficPackageRemaining</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("TrafficPackageTotal")]
            [Validation(Required=false)]
            public long? TrafficPackageTotal { get; set; }

            /// <summary>
            /// <para>The used quota of the data transfer plan in the current month. Unit: Byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("TrafficUsed")]
            [Validation(Required=false)]
            public long? TrafficUsed { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
