// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDomainMetasResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain name lists.</para>
        /// </summary>
        [NameInMap("DomainMetas")]
        [Validation(Required=false)]
        public List<ListDomainMetasResponseBodyDomainMetas> DomainMetas { get; set; }
        public class ListDomainMetasResponseBodyDomainMetas : TeaModel {
            /// <summary>
            /// <para>The time when the list was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-01 10:20:30</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the list was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-02 15:00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The number of domain name entries in the list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("ItemCount")]
            [Validation(Required=false)]
            public long? ItemCount { get; set; }

            /// <summary>
            /// <para>The list ID, which is a unique business identifier used for policy references and CRUD operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ladl-8acxxxa0f2a7daf9</para>
            /// </summary>
            [NameInMap("ListId")]
            [Validation(Required=false)]
            public string ListId { get; set; }

            /// <summary>
            /// <para>The list type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>la_domain_white_list</para>
            /// </summary>
            [NameInMap("ListType")]
            [Validation(Required=false)]
            public string ListType { get; set; }

            /// <summary>
            /// <para>The list name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OfficeDomainWhitelist</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RS_ladl-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D2788E14-8C9F-5FE8-B72F-5ABD033AA27E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of lists that match the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
