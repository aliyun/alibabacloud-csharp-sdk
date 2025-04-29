// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePortRangeListEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>Port list entries.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public List<DescribePortRangeListEntriesResponseBodyEntries> Entries { get; set; }
        public class DescribePortRangeListEntriesResponseBodyEntries : TeaModel {
            /// <summary>
            /// <para>The description of the port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description information of PortRangeList</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>882304EC-5CE2-5860-98ED-3FA1D8D74A0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
