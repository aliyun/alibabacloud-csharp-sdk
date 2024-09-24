// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientProblemTypeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProblemTypes")]
        [Validation(Required=false)]
        public List<DescribeClientProblemTypeResponseBodyProblemTypes> ProblemTypes { get; set; }
        public class DescribeClientProblemTypeResponseBodyProblemTypes : TeaModel {
            [NameInMap("problemDetail")]
            [Validation(Required=false)]
            public string ProblemDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("problemId")]
            [Validation(Required=false)]
            public string ProblemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high_cpu</para>
            /// </summary>
            [NameInMap("problemType")]
            [Validation(Required=false)]
            public string ProblemType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53CXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
