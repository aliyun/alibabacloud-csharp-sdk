// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientProblemTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The current page number displayed in the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of diagnostic types.</para>
        /// </summary>
        [NameInMap("ProblemTypes")]
        [Validation(Required=false)]
        public List<DescribeClientProblemTypeResponseBodyProblemTypes> ProblemTypes { get; set; }
        public class DescribeClientProblemTypeResponseBodyProblemTypes : TeaModel {
            /// <summary>
            /// <para>The description of the diagnostic issue category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Server Guard Agent Offline</para>
            /// </summary>
            [NameInMap("problemDetail")]
            [Validation(Required=false)]
            public string ProblemDetail { get; set; }

            /// <summary>
            /// <para>The ID of the diagnostic issue category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("problemId")]
            [Validation(Required=false)]
            public string ProblemId { get; set; }

            /// <summary>
            /// <para>The name of the diagnostic issue category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high_cpu</para>
            /// </summary>
            [NameInMap("problemType")]
            [Validation(Required=false)]
            public string ProblemType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53CXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the client issue list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
