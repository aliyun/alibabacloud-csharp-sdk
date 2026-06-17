// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2FDB684-751D-424D-98B9-704BEA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of zones.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<DescribeZonesResponseBodyZones> Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// <para>The enumeration of statuses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>UnSet</b>: The zone is not open for use.</para>
            /// </description></item>
            /// <item><description><para><b>SoldOut</b>: The resources in the zone are sold out.</para>
            /// </description></item>
            /// <item><description><para><b>WithStock</b>: The zone has available resources.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UnSet</para>
            /// </summary>
            [NameInMap("ModeCode")]
            [Validation(Required=false)]
            public string ModeCode { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The status of the zone. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ON</b>: The zone is available.</para>
            /// </description></item>
            /// <item><description><para><b>OFF</b>: The zone is unavailable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
