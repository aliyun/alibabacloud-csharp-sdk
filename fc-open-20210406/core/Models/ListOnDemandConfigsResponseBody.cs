// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListOnDemandConfigsResponseBody : TeaModel {
        /// <summary>
        /// The information about the provisioned configuration.
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<OnDemandConfig> Configs { get; set; }

        /// <summary>
        /// The token used to obtain more results. If this parameter is left empty, all the results are returned.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
