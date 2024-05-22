// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// The edge application template. The value must be a JSON string that contains the following information:
        /// 
        /// *   Basic information such as the name of the application
        /// *   Information such as resource specifications and network security configurations
        /// *   Service specifications
        /// *   Required resources
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// The timeout period for asynchronous processing. Unit: seconds. Default value: 1800.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
