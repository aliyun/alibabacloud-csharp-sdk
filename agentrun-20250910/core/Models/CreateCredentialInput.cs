// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateCredentialInput : TeaModel {
        /// <summary>
        /// <para>凭证的配置参数，以键值对形式存储</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_endpoint=<a href="https://api.example.com,timeout=30">https://api.example.com,timeout=30</a></para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
