// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class ImportApiKeyInput : TeaModel {
        /// <summary>
        /// <para>The name of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The value of the API key to import.</para>
        /// </summary>
        [NameInMap("apiKeyValue")]
        [Validation(Required=false)]
        public string ApiKeyValue { get; set; }

        /// <summary>
        /// <para>The expiration time of the API key.</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team to which the API key belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70d1c834-0383-58d8-97ac-5336eb91abcd</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
