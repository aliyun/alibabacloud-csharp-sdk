// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetFunctionOnDemandConfigRequest : TeaModel {
        /// <summary>
        /// Service alias or LATEST. Other versions are not supported.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
