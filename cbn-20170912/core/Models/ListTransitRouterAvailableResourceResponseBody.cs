// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// ListTransitRouterAvailableResource
        /// </summary>
        [NameInMap("MasterZones")]
        [Validation(Required=false)]
        public List<string> MasterZones { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ListTransitRouterAvailableResource**.
        /// </summary>
        [NameInMap("SlaveZones")]
        [Validation(Required=false)]
        public List<string> SlaveZones { get; set; }

        /// <summary>
        /// 是否为支持组播功能的可用区信息。
        /// </summary>
        [NameInMap("SupportMulticast")]
        [Validation(Required=false)]
        public bool? SupportMulticast { get; set; }

    }

}
