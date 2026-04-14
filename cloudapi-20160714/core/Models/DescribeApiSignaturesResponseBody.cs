// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiSignaturesResponseBody : TeaModel {
        [NameInMap("ApiSignatures")]
        [Validation(Required=false)]
        public DescribeApiSignaturesResponseBodyApiSignatures ApiSignatures { get; set; }
        public class DescribeApiSignaturesResponseBodyApiSignatures : TeaModel {
            [NameInMap("ApiSignatureItem")]
            [Validation(Required=false)]
            public List<DescribeApiSignaturesResponseBodyApiSignaturesApiSignatureItem> ApiSignatureItem { get; set; }
            public class DescribeApiSignaturesResponseBodyApiSignaturesApiSignatureItem : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                [NameInMap("SignatureId")]
                [Validation(Required=false)]
                public string SignatureId { get; set; }

                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
