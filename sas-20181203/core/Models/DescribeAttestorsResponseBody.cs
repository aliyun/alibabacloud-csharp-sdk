// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAttestorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The witnesses.</para>
        /// </summary>
        [NameInMap("Attestors")]
        [Validation(Required=false)]
        public List<DescribeAttestorsResponseBodyAttestors> Attestors { get; set; }
        public class DescribeAttestorsResponseBodyAttestors : TeaModel {
            /// <summary>
            /// <para>The ID of the KMS key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2e81355b-f8e7-4090-8082-a8f8124a****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The region ID of the KMS key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("KeyRegionId")]
            [Validation(Required=false)]
            public string KeyRegionId { get; set; }

            /// <summary>
            /// <para>The version ID of the Key Management Service (KMS) key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8d7c9c91-57ce-4cf4-a959-1e700e13****</para>
            /// </summary>
            [NameInMap("KeyVersionId")]
            [Validation(Required=false)]
            public string KeyVersionId { get; set; }

            /// <summary>
            /// <para>The name of the witness.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attestor-123</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attestor</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeAttestorsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeAttestorsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
