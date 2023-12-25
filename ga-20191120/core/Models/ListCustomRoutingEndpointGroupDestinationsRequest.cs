// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingEndpointGroupDestinationsRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The ID of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The start port of the backend service port range of the endpoint group.
        /// 
        /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
        /// </summary>
        [NameInMap("FromPort")]
        [Validation(Required=false)]
        public int? FromPort { get; set; }

        /// <summary>
        /// The ID of the listener.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The backend service protocols of the endpoint group. Valid values:
        /// 
        /// - **TCP**: TCP.
        /// - **UDP**: UDP.
        /// - **TCP,UDP**: TCP and UDP.
        /// 
        /// If this parameter is empty, all types of protocols are queried.
        /// 
        /// You can specify up to 10 protocols.
        /// </summary>
        [NameInMap("Protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The end port of the backend service port range of the endpoint group.
        /// 
        /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
        /// </summary>
        [NameInMap("ToPort")]
        [Validation(Required=false)]
        public int? ToPort { get; set; }

    }

}
