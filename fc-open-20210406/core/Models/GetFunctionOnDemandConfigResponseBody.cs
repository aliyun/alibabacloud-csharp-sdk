// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetFunctionOnDemandConfigResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of instances.
        /// </summary>
        [NameInMap("maximumInstanceCount")]
        [Validation(Required=false)]
        public long? MaximumInstanceCount { get; set; }

        /// <summary>
        /// The description of the resource.
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

    }

}
