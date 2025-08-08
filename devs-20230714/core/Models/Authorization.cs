// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class Authorization : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public AuthorizationParameters Parameters { get; set; }
        public class AuthorizationParameters : TeaModel {
            [NameInMap("apiKeyParameter")]
            [Validation(Required=false)]
            public APIKeyAuthParameter ApiKeyParameter { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APIKey</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
