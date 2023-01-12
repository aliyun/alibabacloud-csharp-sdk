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
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DestinationConfigurations")]
        [Validation(Required=false)]
        public List<UpdateCustomRoutingEndpointGroupDestinationsRequestDestinationConfigurations> DestinationConfigurations { get; set; }
        public class UpdateCustomRoutingEndpointGroupDestinationsRequestDestinationConfigurations : TeaModel {
            /// <summary>
            /// The ID of the mapping configuration of the endpoint group.
            /// </summary>
            [NameInMap("DestinationId")]
            [Validation(Required=false)]
            public string DestinationId { get; set; }

            /// <summary>
            /// The start port of the backend service port range of the endpoint group.
            /// 
            /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
            /// 
            /// You can specify up to 20 start ports of backend service port ranges in each request.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// The end port of the backend service port range of the endpoint group.
            /// 
            /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
            /// 
            /// You can specify up to 20 end ports of backend service port ranges in each request.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// Specifies whether to only precheck the request. Default value: false. Valid values:
        /// 
        /// *   **true**: prechecks the request without performing the operation. The system checks the required parameters, request syntax, and limits. If the request fails the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. If the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.
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
