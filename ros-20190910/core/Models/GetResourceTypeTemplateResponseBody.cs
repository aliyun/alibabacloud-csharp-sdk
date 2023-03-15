// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeTemplateResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The structure that contains the template body.
        /// 
        /// The template body must be 1 to 51,200 bytes in length.
        /// 
        /// For more information, see [Template syntax](~~28857~~).
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateBody { get; set; }

    }

}
