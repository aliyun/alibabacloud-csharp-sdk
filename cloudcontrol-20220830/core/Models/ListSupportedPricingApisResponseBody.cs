// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class ListSupportedPricingApisResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of OpenAPI triplets that support price inquiry. The triplets are sorted in alphabetical order by popCode, popVersion, and apiName.</para>
        /// </summary>
        [NameInMap("supportedApis")]
        [Validation(Required=false)]
        public List<ListSupportedPricingApisResponseBodySupportedApis> SupportedApis { get; set; }
        public class ListSupportedPricingApisResponseBodySupportedApis : TeaModel {
            /// <summary>
            /// <para>The OpenAPI name in PascalCase, such as RunInstances.</para>
            /// </summary>
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The POP product code, such as Ecs, Rds, or Alb. This value corresponds to the popCode field used in price inquiry requests.</para>
            /// </summary>
            [NameInMap("popCode")]
            [Validation(Required=false)]
            public string PopCode { get; set; }

            /// <summary>
            /// <para>The OpenAPI version number, such as 2014-05-26.</para>
            /// </summary>
            [NameInMap("popVersion")]
            [Validation(Required=false)]
            public string PopVersion { get; set; }

        }

    }

}
