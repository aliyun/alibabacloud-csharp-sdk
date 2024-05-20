// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeAppServiceDetailRequest : TeaModel {
        /// <summary>
        /// 6dcc8c9e-d3da-478a-a066-86dcf820\\*\\*\\*\\*
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("NacosInstanceId")]
        [Validation(Required=false)]
        public string NacosInstanceId { get; set; }

        [NameInMap("NacosNamespaceId")]
        [Validation(Required=false)]
        public string NacosNamespaceId { get; set; }

        /// <summary>
        /// springCloud
        /// </summary>
        [NameInMap("ServiceGroup")]
        [Validation(Required=false)]
        public string ServiceGroup { get; set; }

        /// <summary>
        /// edas.service.provider
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// springCloud
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 1.0.0
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

    }

}
