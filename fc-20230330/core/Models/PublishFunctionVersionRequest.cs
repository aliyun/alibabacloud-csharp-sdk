// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PublishFunctionVersionRequest : TeaModel {
        /// <summary>
        /// The information about the function version.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public PublishVersionInput Body { get; set; }

    }

}
