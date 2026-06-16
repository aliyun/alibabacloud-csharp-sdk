// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class PublishRuntimeVersionInput : TeaModel {
        /// <summary>
        /// <para>Description of this version</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Identity of the user or system that publishes this version</para>
        /// 
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("publisher")]
        [Validation(Required=false)]
        public string Publisher { get; set; }

    }

}
