// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointGroupDestinationsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The mapping configuration of the endpoint group.
        /// 
        /// You need to specify the backend service ports and protocols for the endpoint group. The ports are mapped to listener ports.
        /// 
        /// You can specify up to 20 mappings in each call.
        /// </summary>
        [NameInMap("DestinationConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointGroupDestinationsRequestDestinationConfigurations> DestinationConfigurations { get; set; }
        public class CreateCustomRoutingEndpointGroupDestinationsRequestDestinationConfigurations : TeaModel {
            /// <summary>
            /// The last port of the backend service port range.
            /// 
            /// Valid values: **1** to **65499**. The value of **FromPort** must be equal to or smaller than the value of **ToPort**.
            /// 
            /// You can specify up to 20 last ports in each call.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The backend service protocol of the endpoint group. Valid values:
            /// 
            /// *   **TCP**
            /// *   **UDP**
            /// *   **TCP+UDP: the TCP and UDP protocols.**
            /// 
            /// You can specify up to four backend service protocols for each endpoint group mapping.
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// The response parameters.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// The endpoint group ID.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The mappings of the endpoint group.
        /// 
        /// You need to specify the backend service ports and protocols for the endpoint group. The ports are mapped to listener ports.
        /// 
        /// You can specify up to 20 mappings in each call.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
