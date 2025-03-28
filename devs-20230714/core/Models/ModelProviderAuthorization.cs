// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ModelProviderAuthorization : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> AuthConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>apiKey</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
