// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentModelAccessConfig : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("consumerIds")]
        [Validation(Required=false)]
        public List<string> ConsumerIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("modelApiId")]
        [Validation(Required=false)]
        public string ModelApiId { get; set; }

    }

}
