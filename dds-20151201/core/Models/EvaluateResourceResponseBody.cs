// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class EvaluateResourceResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the resources are sufficient in the region. Valid values:
        /// 
        /// *   **1**: The resources are sufficient.
        /// *   **0**: The resources are insufficient.
        /// </summary>
        [NameInMap("DBInstanceAvailable")]
        [Validation(Required=false)]
        public string DBInstanceAvailable { get; set; }

        /// <summary>
        /// The database engine of the instance. Only MongoDB is returned.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
