// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListBusinessAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// The list of access points.
        /// </summary>
        [NameInMap("BusinessAccessPoints")]
        [Validation(Required=false)]
        public List<ListBusinessAccessPointsResponseBodyBusinessAccessPoints> BusinessAccessPoints { get; set; }
        public class ListBusinessAccessPointsResponseBodyBusinessAccessPoints : TeaModel {
            /// <summary>
            /// The ID of the access point.
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// The name of the access point.
            /// </summary>
            [NameInMap("AccessPointName")]
            [Validation(Required=false)]
            public string AccessPointName { get; set; }

            /// <summary>
            /// The ID of the cloud box.
            /// 
            /// >  This parameter is available if the Express Connect circuit supports cloud boxes and the access point supports cloud boxes.
            /// </summary>
            [NameInMap("CloudBoxInstanceIds")]
            [Validation(Required=false)]
            public string CloudBoxInstanceIds { get; set; }

            /// <summary>
            /// The latitude of the access point.
            /// </summary>
            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public double? Latitude { get; set; }

            /// <summary>
            /// The longitude of the access point.
            /// </summary>
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public double? Longitude { get; set; }

            /// <summary>
            /// The connectivity provider of the Express Connect circuit. Valid values:
            /// 
            /// *   **CT**: China Telecom
            /// *   **CU**: China Unicom
            /// *   **CM**: China Mobile
            /// *   **CO**: other connectivity providers in the Chinese mainland
            /// *   **Equinix**: Equinix
            /// *   **Other**: other connectivity providers outside the Chinese mainland
            /// </summary>
            [NameInMap("SupportLineOperator")]
            [Validation(Required=false)]
            public string SupportLineOperator { get; set; }

            /// <summary>
            /// The port type supported by the access point. Valid values:
            /// 
            /// *   **100Base-T**: 100 Mbit/s copper Ethernet port
            /// *   **1000Base-T**: 1,000 Mbit/s copper Ethernet port
            /// *   **1000Base-LX**: 1,000 Mbit/s single-mode optical port (10 km)
            /// *   **10GBase-T**: 10,000 Mbit/s copper Ethernet port
            /// *   **10GBase-LR**: 10,000 Mbit/s single-mode optical port (10 kilometers)
            /// *   **40GBase-LR**: 40,000 Mbit/s single-mode optical port
            /// *   **100GBase-LR**: 100,000 Mbit/s single-mode optical port
            /// 
            /// >  If you want to use the 40GBase-LR or 100GBase-LR port for an Express Connect circuit, you must first contact your account manager to obtain information about resource supplies.
            /// </summary>
            [NameInMap("SupportPortTypes")]
            [Validation(Required=false)]
            public string SupportPortTypes { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
