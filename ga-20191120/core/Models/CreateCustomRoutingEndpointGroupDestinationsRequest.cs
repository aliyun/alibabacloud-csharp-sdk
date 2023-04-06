// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointGroupDestinationsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request is different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The mapping configurations of the endpoint group.
        /// 
        /// You need to specify the backend service ports and protocols for the endpoint group. The ports are mapped to listener ports.
        /// 
        /// You can specify up to 20 mapping configurations in each call.
        /// </summary>
        [NameInMap("DestinationConfigurations")]
        [Validation(Required=false)]
        public List<CreateCustomRoutingEndpointGroupDestinationsRequestDestinationConfigurations> DestinationConfigurations { get; set; }
        public class CreateCustomRoutingEndpointGroupDestinationsRequestDestinationConfigurations : TeaModel {
            /// <summary>
            /// The first port of the backend service port range.
            /// 
            /// Valid values: **1** to **65499**. The value of **FromPort** must be equal to or smaller than the value of **ToPort**.
            /// 
            /// You can specify up to 20 first ports in each request.
            /// 
            /// > This parameter is required.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The backend service protocol of the endpoint group. Valid values:
            /// 
            /// *   **TCP**: TCP
            /// *   **UDP**: UDP
            /// *   **TCP,UDP**: TCP and UDP
            /// 
            /// You can specify up to four protocols for each mapping configuration.
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// The last port of the backend service port range.
            /// 
            /// Valid values: **1** to **65499**. The value of **FromPort** must be equal to or smaller than the value of **ToPort**.
            /// 
            /// You can specify up to 20 last ports in each request.
            /// 
            /// > This parameter is required.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
