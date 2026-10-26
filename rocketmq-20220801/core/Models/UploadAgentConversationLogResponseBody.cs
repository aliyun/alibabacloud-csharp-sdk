// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UploadAgentConversationLogResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>client.log</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0198c8a91f4d7f01a3c21e99</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>client-logs/0198c8a91f4d7f01a3c21e99/client.log</para>
        /// </summary>
        [NameInMap("sandboxPath")]
        [Validation(Required=false)]
        public string SandboxPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>114</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
