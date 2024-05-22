// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleApplicationRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can query the application ID by calling the ListApplications operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The level of resource scaling. The value must be of the enumerated data type. Valid values:
        /// 
        /// *   AreaIspCode (default): scales resources based on the Internet service provider (ISP).
        /// *   RegionId: scales resources based on the edge node.
        /// *   InstanceId: scales resources based on the instance ID. Resource scale-out specifies resource hosting and scale-in specifies resource release.
        /// </summary>
        [NameInMap("RescaleLevel")]
        [Validation(Required=false)]
        public string RescaleLevel { get; set; }

        /// <summary>
        /// The scaling operation. The value must be of the enumerated data type. Valid values:
        /// 
        /// *   Add: adds new resources.
        /// *   Del: releases resources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RescaleType")]
        [Validation(Required=false)]
        public string RescaleType { get; set; }

        /// <summary>
        /// The required resources. The value must be a JSON string.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceSelector")]
        [Validation(Required=false)]
        public string ResourceSelector { get; set; }

        /// <summary>
        /// The timeout period for asynchronous scaling. Unit: seconds. Default value: 300.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// The version number of the application deployment package. By default, the stable version number is used. This parameter takes effect only when you perform resource scale-out.
        /// </summary>
        [NameInMap("ToAppVersion")]
        [Validation(Required=false)]
        public string ToAppVersion { get; set; }

    }

}
