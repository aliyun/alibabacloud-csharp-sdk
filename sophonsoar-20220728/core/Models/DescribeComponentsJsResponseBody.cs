// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentsJsResponseBody : TeaModel {
        /// <summary>
        /// The configuration of the JavaScript file for the component.
        /// </summary>
        [NameInMap("ComponentsJs")]
        [Validation(Required=false)]
        public string ComponentsJs { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
