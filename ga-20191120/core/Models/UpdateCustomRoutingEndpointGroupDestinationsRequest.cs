// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateCustomRoutingEndpointGroupDestinationsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The mapping configurations of endpoint group.
        /// 
        /// You must specify the backend service port range and protocol of the endpoint group. The specified information is used to map the port range of the associated listener.
        /// 
        /// You can specify at most 20 mapping configurations, which include port ranges and protocol types.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointGroupDestinationsRequestDestinationConfigurations> DestinationConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointGroupDestinationsRequestDestinationConfigurations : TeaModel {
            /// <summary>
            /// The ID of the mapping configuration of the endpoint group.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// The start port of the backend service port range of the endpoint group.
            /// 
            /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
            /// 
            /// You can specify up to 20 start ports in each request.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The backend service protocol of the endpoint group. Valid values:
            /// 
            /// *   **tcp**: TCP
            /// *   **udp**: UDP
            /// *   **tcp,udp**: TCP and UDP
            /// 
            /// You can specify up to four backend service protocols in each configuration.
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// The end port of the backend service port range of the endpoint group.
            /// 
            /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
            /// 
            /// You can specify up to 20 end ports in each request.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**: performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the endpoint group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
