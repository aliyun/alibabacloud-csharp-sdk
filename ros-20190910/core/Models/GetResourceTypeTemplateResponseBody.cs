// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeTemplateResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The structure that contains the template body. The template body must be 1 to 51,200 bytes in length. For more information, see [Template syntax](https://help.aliyun.com/document_detail/28857.html).
        /// 
        /// > We recommend that use TemplateContent instead of TemplateBody.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateBody { get; set; }

        /// <summary>
        /// The JSON-formatted structure of the template body. For more information, see [Template syntax](https://help.aliyun.com/document_detail/28857.html).
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

    }

}
