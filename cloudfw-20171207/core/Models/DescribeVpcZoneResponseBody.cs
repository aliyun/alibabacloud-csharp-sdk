// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcZoneResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>694DFBF3-C060-529F-92D0-7FC7E0DA1E21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The zones.</para>
        /// </summary>
        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<DescribeVpcZoneResponseBodyZoneList> ZoneList { get; set; }
        public class DescribeVpcZoneResponseBodyZoneList : TeaModel {
            /// <summary>
            /// <para>The name of the zone.</para>
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
            /// <para>The zone type. Default value: AvailabilityZone. This value indicates Alibaba Cloud zones.</para>
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
