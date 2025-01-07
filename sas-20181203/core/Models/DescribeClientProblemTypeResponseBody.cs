// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientProblemTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
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
        /// <para>The number of entries per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The issue types.</para>
        /// </summary>
        [NameInMap("ProblemTypes")]
        [Validation(Required=false)]
        public List<DescribeClientProblemTypeResponseBodyProblemTypes> ProblemTypes { get; set; }
        public class DescribeClientProblemTypeResponseBodyProblemTypes : TeaModel {
            /// <summary>
            /// <para>The description of the issue type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>other</para>
            /// </summary>
            [NameInMap("problemDetail")]
            [Validation(Required=false)]
            public string ProblemDetail { get; set; }

            /// <summary>
            /// <para>The ID of the issue type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("problemId")]
            [Validation(Required=false)]
            public string ProblemId { get; set; }

            /// <summary>
            /// <para>The name of the issue type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high_cpu</para>
            /// </summary>
            [NameInMap("problemType")]
            [Validation(Required=false)]
            public string ProblemType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53CXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
