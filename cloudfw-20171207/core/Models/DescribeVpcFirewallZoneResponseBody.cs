// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallZoneResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>337A4DBA-8A01-5E9C-99CA-84293E13****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<List<DescribeVpcFirewallZoneResponseBodyZoneList>> ZoneList { get; set; }
        public class DescribeVpcFirewallZoneResponseBodyZoneList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-c</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

        }

    }

}
