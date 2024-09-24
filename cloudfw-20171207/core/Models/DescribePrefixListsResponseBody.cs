// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrefixListsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the prefix lists.</para>
        /// </summary>
        [NameInMap("PrefixList")]
        [Validation(Required=false)]
        public List<DescribePrefixListsResponseBodyPrefixList> PrefixList { get; set; }
        public class DescribePrefixListsResponseBodyPrefixList : TeaModel {
            /// <summary>
            /// <para>The IP address family of the prefix list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IPv4</description></item>
            /// <item><description>IPv6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// <para>The number of associated resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssociationCount")]
            [Validation(Required=false)]
            public int? AssociationCount { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T08:31:06Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP_14900-14911</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maximum number of entries in the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxEntries")]
            [Validation(Required=false)]
            public int? MaxEntries { get; set; }

            /// <summary>
            /// <para>The ID of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-uf64nco3ujjqchx6aaji</para>
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            /// <summary>
            /// <para>The name of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>participant-name</para>
            /// </summary>
            [NameInMap("PrefixListName")]
            [Validation(Required=false)]
            public string PrefixListName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67FD76C2-C493-5815-8107-643FD7AB77C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
