// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleDeviceServiceRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of the network. The value must be of the enumerated data type. Valid values:
        /// 
        /// *   **1** (default): Internet
        /// *   **2**: internal network
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public int? IpType { get; set; }

        /// <summary>
        /// The region level of the scale-out. Set the value to RegionId. RegionId specifies that resource scale-out is performed based on the ID of the edge node.
        /// </summary>
        [NameInMap("RescaleLevel")]
        [Validation(Required=false)]
        public string RescaleLevel { get; set; }

        /// <summary>
        /// The scaling operation. Set the value to Add to add new resources.
        /// </summary>
        [NameInMap("RescaleType")]
        [Validation(Required=false)]
        public string RescaleType { get; set; }

        /// <summary>
        /// The information about the resource specification template. The value must be a JSON string.
        /// </summary>
        [NameInMap("ResourceInfo")]
        [Validation(Required=false)]
        public string ResourceInfo { get; set; }

        /// <summary>
        /// The required resources. The value must be a JSON string.
        /// </summary>
        [NameInMap("ResourceSelector")]
        [Validation(Required=false)]
        public string ResourceSelector { get; set; }

        /// <summary>
        /// The resource specification.
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public string ResourceSpec { get; set; }

        /// <summary>
        /// The ID of the service.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The timeout period for asynchronous scale-out. Unit: seconds. Default value: 300.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
