// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasResponsePluginFieldDataDTO : TeaModel {
        /// <summary>
        /// ContentResponse
        /// </summary>
        [NameInMap("ContentResponse")]
        [Validation(Required=false)]
        public PaasResponseNodeContentDTO ContentResponse { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
