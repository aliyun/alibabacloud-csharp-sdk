// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackTemplateByResourcesResponseBody : TeaModel {
        /// <summary>
        /// The template content after correction.
        /// </summary>
        [NameInMap("NewTemplateBody")]
        [Validation(Required=false)]
        public string NewTemplateBody { get; set; }

        /// <summary>
        /// The template content before correction.
        /// </summary>
        [NameInMap("OldTemplateBody")]
        [Validation(Required=false)]
        public string OldTemplateBody { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
