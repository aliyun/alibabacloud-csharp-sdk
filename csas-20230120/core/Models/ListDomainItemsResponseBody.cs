// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDomainItemsResponseBody : TeaModel {
        [NameInMap("DomainItems")]
        [Validation(Required=false)]
        public List<ListDomainItemsResponseBodyDomainItems> DomainItems { get; set; }
        public class ListDomainItemsResponseBodyDomainItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-01 10:20:30</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("ItemValue")]
            [Validation(Required=false)]
            public string ItemValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>019F68B5-2D0D-5399-9BB2-D81C13C2C05D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
