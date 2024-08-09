// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class FlinkApiProxyRequest : TeaModel {
        /// <summary>
        /// The path of the Flink UI.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("flinkApiPath")]
        [Validation(Required=false)]
        public string FlinkApiPath { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The resource ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   jobs
        /// *   sessionclusters
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
