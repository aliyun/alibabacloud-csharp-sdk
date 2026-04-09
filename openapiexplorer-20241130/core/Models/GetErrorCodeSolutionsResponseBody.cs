// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetErrorCodeSolutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A707AFA8-1A4C-5B2A-A165-8436C1EA38DB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The solutions. Not all error codes have corresponding solutions. You can submit a ticket or use OpenAPI Explorer to contact technical support if necessary.</para>
        /// </summary>
        [NameInMap("solutions")]
        [Validation(Required=false)]
        public List<GetErrorCodeSolutionsResponseBodySolutions> Solutions { get; set; }
        public class GetErrorCodeSolutionsResponseBodySolutions : TeaModel {
            /// <summary>
            /// <para>The content of the solution, which is in the markdown format.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0017-00000502</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The resource is not in a valid state for the operation.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The code of the product to which the solution belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The name of the product to which the solution belongs.</para>
            /// </summary>
            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The solution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0017-00000502</para>
            /// </summary>
            [NameInMap("solutionId")]
            [Validation(Required=false)]
            public string SolutionId { get; set; }

        }

    }

}
