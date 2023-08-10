// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies the richness of returned information. Valid values:
        /// 
        /// *   simple: displays only the basic information.
        /// *   normal: displays information such as createParameters and cron. This is the default value.
        /// *   detail: returns the details of the training task.
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

    }

}
