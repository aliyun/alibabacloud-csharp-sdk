// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DeleteFlowRequest : TeaModel {
        /// <summary>
        /// The name of the flow. The name can contain only letters, digits, underscores (\_), and hyphens (-). It cannot start with a digit or a hyphen (-). It must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
