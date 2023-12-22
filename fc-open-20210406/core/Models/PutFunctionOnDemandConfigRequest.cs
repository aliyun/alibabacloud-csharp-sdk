// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutFunctionOnDemandConfigRequest : TeaModel {
        /// <summary>
        /// The maximum number of on-demand instances. For more information, see [Configure provisioned instances and auto scaling rules](~~185038~~).
        /// </summary>
        [NameInMap("maximumInstanceCount")]
        [Validation(Required=false)]
        public long? MaximumInstanceCount { get; set; }

        /// <summary>
        /// The service alias or latest version. Other versions are not supported.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
