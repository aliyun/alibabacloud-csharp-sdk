// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgPlatformQueryProjectsAndSchemaFromMetaRequest : TeaModel {
        /// <summary>
        /// The type of the compute engine. Valid values:
        /// 
        /// *   ODPS.ODPS
        /// *   EMR
        /// *   HOLO.POSTGRES
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineName")]
        [Validation(Required=false)]
        public string EngineName { get; set; }

    }

}
