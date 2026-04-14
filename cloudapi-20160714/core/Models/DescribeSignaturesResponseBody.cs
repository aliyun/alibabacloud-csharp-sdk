// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSignaturesResponseBody : TeaModel {
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

        [NameInMap("SignatureInfos")]
        [Validation(Required=false)]
        public DescribeSignaturesResponseBodySignatureInfos SignatureInfos { get; set; }
        public class DescribeSignaturesResponseBodySignatureInfos : TeaModel {
            [NameInMap("SignatureInfo")]
            [Validation(Required=false)]
            public List<DescribeSignaturesResponseBodySignatureInfosSignatureInfo> SignatureInfo { get; set; }
            public class DescribeSignaturesResponseBodySignatureInfosSignatureInfo : TeaModel {
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SignatureId")]
                [Validation(Required=false)]
                public string SignatureId { get; set; }

                [NameInMap("SignatureKey")]
                [Validation(Required=false)]
                public string SignatureKey { get; set; }

                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

                [NameInMap("SignatureSecret")]
                [Validation(Required=false)]
                public string SignatureSecret { get; set; }

            }

        }

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
