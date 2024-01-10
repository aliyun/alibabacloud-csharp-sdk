// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateDiagnosticRequest : TeaModel {
        /// <summary>
        /// The keyword in the diagnosis.
        /// </summary>
        [NameInMap("DiagnosticKey")]
        [Validation(Required=false)]
        public string DiagnosticKey { get; set; }

        /// <summary>
        /// The type of the item that is diagnosed. Set the value to Stack, which specifies that the stack is diagnosed.
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        /// <summary>
        /// The name of the product that is diagonosed.
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
