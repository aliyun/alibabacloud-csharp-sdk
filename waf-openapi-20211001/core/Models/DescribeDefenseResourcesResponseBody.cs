// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourcesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The protected objects.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeDefenseResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeDefenseResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// The status of the tracking cookie.
            /// 
            /// *   **0:** disabled.
            /// *   **1:** enabled.
            /// </summary>
            [NameInMap("AcwCookieStatus")]
            [Validation(Required=false)]
            public int? AcwCookieStatus { get; set; }

            /// <summary>
            /// The status of the secure attribute of the tracking cookie.
            /// 
            /// *   **0:** disabled.
            /// *   **1:** enabled.
            /// </summary>
            [NameInMap("AcwSecureStatus")]
            [Validation(Required=false)]
            public int? AcwSecureStatus { get; set; }

            /// <summary>
            /// The status of the secure attribute of the slider verification cookie.
            /// 
            /// *   **0:** disabled.
            /// *   **1:** enabled.
            /// </summary>
            [NameInMap("AcwV3SecureStatus")]
            [Validation(Required=false)]
            public int? AcwV3SecureStatus { get; set; }

            /// <summary>
            /// The custom XFF headers that are used to identify the originating IP addresses of clients. If the value of XffStatus is 1 and CustomHeaders is left empty, the first IP address in the XFF header is the originating IP address of the client.
            /// </summary>
            [NameInMap("CustomHeaders")]
            [Validation(Required=false)]
            public List<string> CustomHeaders { get; set; }

            /// <summary>
            /// The description of the protected object.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The details of the protected object. Different key-value pairs in a map indicate different properties of the protected object.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public Dictionary<string, object> Detail { get; set; }

            /// <summary>
            /// The creation time of the protected object. Unit: seconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The most recent modification time of the protected object. Unit: seconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The protection pattern.
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// The name of the cloud service.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The name of the protected object.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// The name of the protected object group to which the protected object belongs.
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// The origin of the protected object.
            /// </summary>
            [NameInMap("ResourceOrigin")]
            [Validation(Required=false)]
            public string ResourceOrigin { get; set; }

            /// <summary>
            /// Indicates whether the X-Forwarded-For (XFF) header is used.
            /// </summary>
            [NameInMap("XffStatus")]
            [Validation(Required=false)]
            public int? XffStatus { get; set; }

        }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
