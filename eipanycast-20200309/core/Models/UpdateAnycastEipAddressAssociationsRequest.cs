// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class UpdateAnycastEipAddressAssociationsRequest : TeaModel {
        /// <summary>
        /// The ID of the Anycast EIP.
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// The association mode. Valid values:
        /// 
        /// *   **Default**: the default mode. In this mode, cloud resources to be associated are set as default origin servers.
        /// *   **Normal**: the standard mode. In this mode, cloud resources to be associated are set as standard origin servers.
        /// </summary>
        [NameInMap("AssociationMode")]
        [Validation(Required=false)]
        public string AssociationMode { get; set; }

        /// <summary>
        /// The ID of the cloud resource with which you want to associate the Anycast EIP.
        /// </summary>
        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// >  If you do not set this parameter, the system automatically uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to only precheck the request. Valid values:
        /// 
        /// *   **true**: prechecks the request without updating the association information. The system checks the required parameters, request syntax, and limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the API request. If the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The access areas and access points to be added.
        /// </summary>
        [NameInMap("PopLocationAddList")]
        [Validation(Required=false)]
        public List<UpdateAnycastEipAddressAssociationsRequestPopLocationAddList> PopLocationAddList { get; set; }
        public class UpdateAnycastEipAddressAssociationsRequestPopLocationAddList : TeaModel {
            /// <summary>
            /// The access points in the access areas to be added.
            /// 
            /// You can call the [DescribeAnycastPopLocations](~~171938~~) operation to query the access points in supported access areas.
            /// </summary>
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

        /// <summary>
        /// The access areas and access points to be deleted.
        /// </summary>
        [NameInMap("PopLocationDeleteList")]
        [Validation(Required=false)]
        public List<UpdateAnycastEipAddressAssociationsRequestPopLocationDeleteList> PopLocationDeleteList { get; set; }
        public class UpdateAnycastEipAddressAssociationsRequestPopLocationDeleteList : TeaModel {
            /// <summary>
            /// The access points in the access areas to be deleted.
            /// 
            /// >  If the access point in the access area is associated with a default origin server, you cannot delete the access point in the access area.
            /// </summary>
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

    }

}
