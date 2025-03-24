// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mhub20170825.Models
{
    public class QueryProductInfoResponseBody : TeaModel {
        [NameInMap("ProductInfo")]
        [Validation(Required=false)]
        public QueryProductInfoResponseBodyProductInfo ProductInfo { get; set; }
        public class QueryProductInfoResponseBodyProductInfo : TeaModel {
            [NameInMap("EncodedIcon")]
            [Validation(Required=false)]
            public string EncodedIcon { get; set; }

            [NameInMap("IconName")]
            [Validation(Required=false)]
            public string IconName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IndustryId")]
            [Validation(Required=false)]
            public int? IndustryId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>126D4DDD-05A5-49B1-B18C-39C4A929BFB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
