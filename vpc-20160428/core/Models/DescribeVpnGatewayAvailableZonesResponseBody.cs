// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewayAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The zones.</para>
        /// </summary>
        [NameInMap("AvailableZoneIdList")]
        [Validation(Required=false)]
        public List<DescribeVpnGatewayAvailableZonesResponseBodyAvailableZoneIdList> AvailableZoneIdList { get; set; }
        public class DescribeVpnGatewayAvailableZonesResponseBodyAvailableZoneIdList : TeaModel {
            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The zone name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29784052-931F-543D-A612-36B3838163FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
