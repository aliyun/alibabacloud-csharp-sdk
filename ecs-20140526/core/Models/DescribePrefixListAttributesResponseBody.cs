// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the prefix list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressFamily")]
        [Validation(Required=false)]
        public string AddressFamily { get; set; }

        /// <summary>
        /// <para>The maximum number of entries that the prefix list can contain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-20T07:11Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The IP address family of the prefix list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPv4</description></item>
        /// <item><description>IPv6</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The description of the entry in the prefix list.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public DescribePrefixListAttributesResponseBodyEntries Entries { get; set; }
        public class DescribePrefixListAttributesResponseBodyEntries : TeaModel {
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public List<DescribePrefixListAttributesResponseBodyEntriesEntry> Entry { get; set; }
            public class DescribePrefixListAttributesResponseBodyEntriesEntry : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.1.0/24</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The CIDR block in the entry in the prefix list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description Sample 01</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxEntries")]
        [Validation(Required=false)]
        public int? MaxEntries { get; set; }

        /// <summary>
        /// <para>Details about the entries in the prefix list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// <para>The ID of the prefix list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrefixListNameSample</para>
        /// </summary>
        [NameInMap("PrefixListName")]
        [Validation(Required=false)]
        public string PrefixListName { get; set; }

        /// <summary>
        /// <para>The description of the prefix list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38793DB8-A4B2-4AEC-BFD3-111234E9188D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
