// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FEA0CF3-D3B9-43E5-A304-D217037876A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The zone list.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                /// <summary>
                /// <para>The zone name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou Zone B</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The zone type. Default value: <b>AvailabilityZone</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AvailabilityZone</para>
                /// </summary>
                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
