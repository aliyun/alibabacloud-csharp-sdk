// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallZoneResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>337A4DBA-8A01-5E9C-99CA-84293E13****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of zones.</para>
        /// </summary>
        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<List<DescribeVpcFirewallZoneResponseBodyZoneList>> ZoneList { get; set; }
        public class DescribeVpcFirewallZoneResponseBodyZoneList : TeaModel {
            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-c</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The name of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou Zone C</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

        }

    }

}
