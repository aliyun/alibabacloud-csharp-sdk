// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetErrorCodeSolutionsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("solutions")]
        [Validation(Required=false)]
        public List<GetErrorCodeSolutionsResponseBodySolutions> Solutions { get; set; }
        public class GetErrorCodeSolutionsResponseBodySolutions : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0017-00000502</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0017-00000502</para>
            /// </summary>
            [NameInMap("solutionId")]
            [Validation(Required=false)]
            public string SolutionId { get; set; }

        }

    }

}
