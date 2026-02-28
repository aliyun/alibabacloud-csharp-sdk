// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSnatTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D7E89B1-1C5B-412B-8585-4908E222EED5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnatTableEntries")]
        [Validation(Required=false)]
        public DescribeSnatTableEntriesResponseBodySnatTableEntries SnatTableEntries { get; set; }
        public class DescribeSnatTableEntriesResponseBodySnatTableEntries : TeaModel {
            [NameInMap("SnatTableEntry")]
            [Validation(Required=false)]
            public List<DescribeSnatTableEntriesResponseBodySnatTableEntriesSnatTableEntry> SnatTableEntry { get; set; }
            public class DescribeSnatTableEntriesResponseBodySnatTableEntriesSnatTableEntry : TeaModel {
                [NameInMap("EipAffinity")]
                [Validation(Required=false)]
                public string EipAffinity { get; set; }

                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                [NameInMap("SnatEntryId")]
                [Validation(Required=false)]
                public string SnatEntryId { get; set; }

                [NameInMap("SnatEntryName")]
                [Validation(Required=false)]
                public string SnatEntryName { get; set; }

                [NameInMap("SnatIp")]
                [Validation(Required=false)]
                public string SnatIp { get; set; }

                [NameInMap("SnatTableId")]
                [Validation(Required=false)]
                public string SnatTableId { get; set; }

                [NameInMap("SourceCIDR")]
                [Validation(Required=false)]
                public string SourceCIDR { get; set; }

                [NameInMap("SourceVSwitchId")]
                [Validation(Required=false)]
                public string SourceVSwitchId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
