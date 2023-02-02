// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeCharsetResponseBody : TeaModel {
        /// <summary>
        /// The list of character sets.
        /// </summary>
        [NameInMap("Charset")]
        [Validation(Required=false)]
        public List<DescribeCharsetResponseBodyCharset> Charset { get; set; }
        public class DescribeCharsetResponseBodyCharset : TeaModel {
            /// <summary>
            /// The character set name.
            /// </summary>
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            /// <summary>
            /// The collation set.
            /// </summary>
            [NameInMap("Collations")]
            [Validation(Required=false)]
            public List<string> Collations { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
