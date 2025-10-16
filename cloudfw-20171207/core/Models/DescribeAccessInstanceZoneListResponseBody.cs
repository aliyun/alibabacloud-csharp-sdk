// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAccessInstanceZoneListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>31306819-C4BC-56F3-BBE6-*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<string> ZoneList { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<DescribeAccessInstanceZoneListResponseBodyZones> Zones { get; set; }
        public class DescribeAccessInstanceZoneListResponseBodyZones : TeaModel {
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
