// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class FlinkApiProxyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("flinkApiPath")]
        [Validation(Required=false)]
        public string FlinkApiPath { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
