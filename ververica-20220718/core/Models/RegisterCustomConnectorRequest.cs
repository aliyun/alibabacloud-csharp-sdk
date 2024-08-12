// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class RegisterCustomConnectorRequest : TeaModel {
        /// <summary>
        /// The URL in which the JAR package of the custom connector is stored. The URL must be connected to the platform.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("jarUrl")]
        [Validation(Required=false)]
        public string JarUrl { get; set; }

    }

}
