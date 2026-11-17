// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGrantRulesToEcrResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of queried results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The cross-account authorization list of the Express Connect Router (ECR).</para>
        /// </summary>
        [NameInMap("EcrGrantRules")]
        [Validation(Required=false)]
        public List<DescribeGrantRulesToEcrResponseBodyEcrGrantRules> EcrGrantRules { get; set; }
        public class DescribeGrantRulesToEcrResponseBodyEcrGrantRules : TeaModel {
            /// <summary>
            /// <para>The time when the authorization was granted. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-15T14:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The instance ID of the Express Connect Router (ECR) for which cross-account authorization is granted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-xxxxxx</para>
            /// </summary>
            [NameInMap("EcrInstanceId")]
            [Validation(Required=false)]
            public string EcrInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the authorized user for the Express Connect Router (ECR) cross-account authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111111111</para>
            /// </summary>
            [NameInMap("EcrUid")]
            [Validation(Required=false)]
            public long? EcrUid { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page during paging in a paged query. Maximum value: 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1CCAB91-6AE6-50E3-AAA3-D0E5A2BC6ADE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
