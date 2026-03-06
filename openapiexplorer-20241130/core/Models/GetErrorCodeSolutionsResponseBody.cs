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
            /// 
            /// <b>Example:</b>
            /// <para>Unsupported transit router status\n====\n\nCause\n----\n\nThe transit router is in an unstable state.\n\n* * *\n\nSolution\n----\n\nTry again after the transit router enters a stable state. You can check whether the transit router is in a stable state based on the following information.\n\nExample\n------\n\nBefore you proceed, make sure that the transit route is in a stable state.\n\n1. Go to the console. If the status of the transit router in the Transit Router list is Available, the transit router is in a stable state.\n\n2. Call the ListTransitRouters operation. If Active is returned for Status, the transit router is in a stable state.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IncorrectStatus.TransitRouter</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service</para>
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
