// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetSecureTokenResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message returned for the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned security token.
        /// </summary>
        [NameInMap("SecureToken")]
        [Validation(Required=false)]
        public GetSecureTokenResponseBodySecureToken SecureToken { get; set; }
        public class GetSecureTokenResponseBodySecureToken : TeaModel {
            /// <summary>
            /// The AccessKey ID used in the namespace.
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// The address of Address Server associated with the namespace.
            /// </summary>
            [NameInMap("AddressServerHost")]
            [Validation(Required=false)]
            public string AddressServerHost { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("BelongRegion")]
            [Validation(Required=false)]
            public string BelongRegion { get; set; }

            /// <summary>
            /// The description of the namespace.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that activated Enterprise Distributed Application Service (EDAS).
            /// </summary>
            [NameInMap("EdasId")]
            [Validation(Required=false)]
            public string EdasId { get; set; }

            /// <summary>
            /// The ID of the security token.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The ID of the MSE instance.
            /// </summary>
            [NameInMap("MseInstanceId")]
            [Validation(Required=false)]
            public string MseInstanceId { get; set; }

            /// <summary>
            /// The public endpoint of the MSE registry.
            /// </summary>
            [NameInMap("MseInternetAddress")]
            [Validation(Required=false)]
            public string MseInternetAddress { get; set; }

            /// <summary>
            /// The private endpoint of the MSE registry.
            /// </summary>
            [NameInMap("MseIntranetAddress")]
            [Validation(Required=false)]
            public string MseIntranetAddress { get; set; }

            /// <summary>
            /// The type of the Microservices Engine (MSE) registry.
            /// 
            /// *   default: the shared registry of EDAS
            /// *   exclusive_mse: MSE Nacos registry
            /// </summary>
            [NameInMap("MseRegistryType")]
            [Validation(Required=false)]
            public string MseRegistryType { get; set; }

            /// <summary>
            /// The ID of the region where the namespace resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the region where the namespace resides.
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// The AccessKey secret used in the namespace.
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// The tenant ID of the namespace.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
