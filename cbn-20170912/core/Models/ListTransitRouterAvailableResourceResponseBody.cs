// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// A list of zone IDs.
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// A list of primary zones.
        /// </summary>
        [NameInMap("MasterZones")]
        [Validation(Required=false)]
        public List<string> MasterZones { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of secondary zone IDs.
        /// </summary>
        [NameInMap("SlaveZones")]
        [Validation(Required=false)]
        public List<string> SlaveZones { get; set; }

        /// <summary>
        /// Indicates whether the zone supports the multicast feature.
        /// </summary>
        [NameInMap("SupportMulticast")]
        [Validation(Required=false)]
        public bool? SupportMulticast { get; set; }

    }

}
