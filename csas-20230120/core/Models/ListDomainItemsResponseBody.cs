// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDomainItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain name entries.</para>
        /// </summary>
        [NameInMap("DomainItems")]
        [Validation(Required=false)]
        public List<ListDomainItemsResponseBodyDomainItems> DomainItems { get; set; }
        public class ListDomainItemsResponseBodyDomainItems : TeaModel {
            /// <summary>
            /// <para>The time when the entry was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-01 10:20:30</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the entry was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-01 10:20:30</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>499</para>
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            /// <summary>
            /// <para>The domain name. Wildcard domain names are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("ItemValue")]
            [Validation(Required=false)]
            public string ItemValue { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F68B5-2D0D-5399-9BB2-D81C13C2C05D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the specified conditions. This is an optional parameter and may not be returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
