// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeCharsetResponseBody : TeaModel {
        /// <summary>
        /// ```
        /// http(s)://[Endpoint]/?Action=DescribeCharset
        /// &TenantMode=Oracle
        /// &Common request parameters
        /// ```
        /// </summary>
        [NameInMap("Charset")]
        [Validation(Required=false)]
        public List<DescribeCharsetResponseBodyCharset> Charset { get; set; }
        public class DescribeCharsetResponseBodyCharset : TeaModel {
            /// <summary>
            /// DescribeCharset
            /// </summary>
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            [NameInMap("Collations")]
            [Validation(Required=false)]
            public List<string> Collations { get; set; }

        }

        /// <summary>
        /// The operation that you want to perform.   
        /// Set the value to **DescribeCharset**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
