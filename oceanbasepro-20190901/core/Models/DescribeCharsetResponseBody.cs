// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeCharsetResponseBody : TeaModel {
        /// <summary>
        /// <pre><c>http(s)://[Endpoint]/?Action=DescribeCharset
        /// &amp;TenantMode=Oracle
        /// &amp;Common request parameters
        /// </c></pre>
        /// </summary>
        [NameInMap("Charset")]
        [Validation(Required=false)]
        public List<DescribeCharsetResponseBodyCharset> Charset { get; set; }
        public class DescribeCharsetResponseBodyCharset : TeaModel {
            /// <summary>
            /// <para>DescribeCharset</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8</para>
            /// </summary>
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            [NameInMap("Collations")]
            [Validation(Required=false)]
            public List<string> Collations { get; set; }

        }

        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>DescribeCharset</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
