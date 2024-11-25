// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried zones.</para>
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeResolverAvailableZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeResolverAvailableZonesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou-a</para>
            /// </summary>
            [NameInMap("AzId")]
            [Validation(Required=false)]
            public string AzId { get; set; }

            /// <summary>
            /// <para>The state of resources in the zone. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: The resources are in the normal state.</description></item>
            /// <item><description>SOLD_OUT: The resources are sold out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23268E49-0C3E-4A2C-AB70-B4C7D092470B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
