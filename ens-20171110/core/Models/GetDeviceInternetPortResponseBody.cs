// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetDeviceInternetPortResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance. The value is the ID of the server or container.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The network mapping information about the instance.
        /// </summary>
        [NameInMap("NetworkInfo")]
        [Validation(Required=false)]
        public List<GetDeviceInternetPortResponseBodyNetworkInfo> NetworkInfo { get; set; }
        public class GetDeviceInternetPortResponseBodyNetworkInfo : TeaModel {
            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("ExternalIp")]
            [Validation(Required=false)]
            public string ExternalIp { get; set; }

            /// <summary>
            /// The external port number.
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// The Internet service provider (ISP).
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// The internal IP address.
            /// </summary>
            [NameInMap("InternalIp")]
            [Validation(Required=false)]
            public string InternalIp { get; set; }

            /// <summary>
            /// The internal port number.
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

            /// <summary>
            /// The status of the external port.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
