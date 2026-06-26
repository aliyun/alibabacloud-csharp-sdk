// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class DestinationConfig : TeaModel {
        /// <summary>
        /// <para>Structure that defines the destination for failed invocations.</para>
        /// </summary>
        [NameInMap("onFailure")]
        [Validation(Required=false)]
        public Destination OnFailure { get; set; }

        /// <summary>
        /// <para>Structure that defines the destination for successful invocations.</para>
        /// </summary>
        [NameInMap("onSuccess")]
        [Validation(Required=false)]
        public Destination OnSuccess { get; set; }

    }

}
