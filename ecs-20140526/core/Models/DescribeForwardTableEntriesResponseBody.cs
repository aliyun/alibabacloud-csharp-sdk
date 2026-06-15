// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeForwardTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of DNAT entries.</para>
        /// </summary>
        [NameInMap("ForwardTableEntries")]
        [Validation(Required=false)]
        public DescribeForwardTableEntriesResponseBodyForwardTableEntries ForwardTableEntries { get; set; }
        public class DescribeForwardTableEntriesResponseBodyForwardTableEntries : TeaModel {
            [NameInMap("ForwardTableEntry")]
            [Validation(Required=false)]
            public List<DescribeForwardTableEntriesResponseBodyForwardTableEntriesForwardTableEntry> ForwardTableEntry { get; set; }
            public class DescribeForwardTableEntriesResponseBodyForwardTableEntriesForwardTableEntry : TeaModel {
                [NameInMap("ExternalIp")]
                [Validation(Required=false)]
                public string ExternalIp { get; set; }

                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                [NameInMap("ForwardEntryId")]
                [Validation(Required=false)]
                public string ForwardEntryId { get; set; }

                [NameInMap("ForwardTableId")]
                [Validation(Required=false)]
                public string ForwardTableId { get; set; }

                [NameInMap("InternalIp")]
                [Validation(Required=false)]
                public string InternalIp { get; set; }

                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
