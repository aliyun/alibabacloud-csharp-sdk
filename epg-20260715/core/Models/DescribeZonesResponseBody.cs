// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A05AB8-CA45-55FC-A2DE-041975EE9AF2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of zones.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<DescribeZonesResponseBodyZones> Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// <para>The zone name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou Zone G</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
