// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Agent : TeaModel {
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8vHW4mDRxxxxx</para>
        /// </summary>
        [NameInMap("McpServerId")]
        [Validation(Required=false)]
        public string McpServerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>data-analyze-agent</para>
        /// </summary>
        [NameInMap("McpServerName")]
        [Validation(Required=false)]
        public string McpServerName { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Metadata Metadata { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
