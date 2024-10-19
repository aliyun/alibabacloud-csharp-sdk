// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSignaturesByApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ004</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned signature key information. It is an array consisting of SignatureItem data.</para>
        /// </summary>
        [NameInMap("Signatures")]
        [Validation(Required=false)]
        public DescribeSignaturesByApiResponseBodySignatures Signatures { get; set; }
        public class DescribeSignaturesByApiResponseBodySignatures : TeaModel {
            [NameInMap("SignatureItem")]
            [Validation(Required=false)]
            public List<DescribeSignaturesByApiResponseBodySignaturesSignatureItem> SignatureItem { get; set; }
            public class DescribeSignaturesByApiResponseBodySignaturesSignatureItem : TeaModel {
                /// <summary>
                /// <para>The time when the key was bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-23T08:28:48Z</para>
                /// </summary>
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                /// <summary>
                /// <para>The ID of the backend signature key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dd05f1c54d6749eda95f9fa6d491449a</para>
                /// </summary>
                [NameInMap("SignatureId")]
                [Validation(Required=false)]
                public string SignatureId { get; set; }

                /// <summary>
                /// <para>The name of the backend signature key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysecret</para>
                /// </summary>
                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

            }

        }

    }

}
