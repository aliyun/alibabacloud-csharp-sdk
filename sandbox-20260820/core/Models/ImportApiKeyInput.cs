// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class ImportApiKeyInput : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>migrated-key</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e2b_****</para>
        /// </summary>
        [NameInMap("apiKeyValue")]
        [Validation(Required=false)]
        public string ApiKeyValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2099-12-31T23:59:59Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5f4a2c18-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
