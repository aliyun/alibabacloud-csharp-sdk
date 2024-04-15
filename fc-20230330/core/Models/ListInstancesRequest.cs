// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// The function version or alias.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// Specifies whether to list all instances. Valid values: true and false.
        /// </summary>
        [NameInMap("withAllActive")]
        [Validation(Required=false)]
        public bool? WithAllActive { get; set; }

    }

}
