// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateAnnotationLabelRequest : TeaModel {
        /// <summary>
        /// The data structure of the request.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public MLLabelParam Body { get; set; }

    }

}
