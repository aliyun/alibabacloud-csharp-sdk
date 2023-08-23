// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateInstanceEndpointStatusRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the instance endpoint. Valid values:
        /// 
        /// *   `true`: enables the instance endpoint.
        /// *   `false`: disables the instance endpoint
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The type of the endpoint. Set the value to Internet.
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the module that you want to access. Valid values:
        /// 
        /// *   `Registry`: the image repository.
        /// *   `Chart`: a Helm chart.
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

    }

}
