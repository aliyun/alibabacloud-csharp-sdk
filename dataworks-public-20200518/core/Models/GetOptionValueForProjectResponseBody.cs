// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOptionValueForProjectResponseBody : TeaModel {
        /// <summary>
        /// The option settings. In the example, cuNumber is a custom key.
        /// </summary>
        [NameInMap("OptionValue")]
        [Validation(Required=false)]
        public string OptionValue { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
