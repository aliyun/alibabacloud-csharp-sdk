// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverVersionRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Pages start from Page 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the driver. To obtain the driver ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Drivers** page, move the pointer over the name of the driver whose versions you want to query and obtain the driver ID.
        /// 
        /// You can also call the [QueryEdgeDriver](~~155776~~) operation to query the driver ID.
        /// </summary>
        [NameInMap("DriverId")]
        [Validation(Required=false)]
        public string DriverId { get; set; }

        /// <summary>
        /// The version number of the driver. To query information about a specific driver version, set this parameter to the specific version number.
        /// </summary>
        [NameInMap("DriverVersion")]
        [Validation(Required=false)]
        public string DriverVersion { get; set; }

        /// <summary>
        /// The ID of the Internet of Things (IoT) service instance. This parameter is not required for the public instance but required for Enterprise Edition instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 30. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The status of the driver version. Valid values:
        /// 
        /// *   0: The driver version to be queried is not published.
        /// *   1: The driver version to be queried is published.
        /// </summary>
        [NameInMap("VersionState")]
        [Validation(Required=false)]
        public int? VersionState { get; set; }

    }

}
