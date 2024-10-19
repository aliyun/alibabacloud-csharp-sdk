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

        /// <summary>
        /// <para>The returned signature information. It is an array consisting of SignatureInfo data.</para>
        /// </summary>
        [NameInMap("SignatureInfos")]
        [Validation(Required=false)]
        public DescribeSignaturesResponseBodySignatureInfos SignatureInfos { get; set; }
        public class DescribeSignaturesResponseBodySignatureInfos : TeaModel {
            [NameInMap("SignatureInfo")]
            [Validation(Required=false)]
            public List<DescribeSignaturesResponseBodySignatureInfosSignatureInfo> SignatureInfo { get; set; }
            public class DescribeSignaturesResponseBodySignatureInfosSignatureInfo : TeaModel {
                /// <summary>
                /// <para>The creation time of the key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-23T08:28:48Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The last modification time of the key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-24T08:28:48Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The region where the key is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
                /// <para>The Key value of the backend signature key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwertyuiop</para>
                /// </summary>
                [NameInMap("SignatureKey")]
                [Validation(Required=false)]
                public string SignatureKey { get; set; }

                /// <summary>
                /// <para>The name of the backend signature key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>backendsignature</para>
                /// </summary>
                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

                /// <summary>
                /// <para>The Secret value of the backend signature key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asdfghjkl</para>
                /// </summary>
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
