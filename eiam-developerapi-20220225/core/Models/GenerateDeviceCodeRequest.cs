// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateDeviceCodeRequest : TeaModel {
        /// <summary>
        /// 客户端ID
        /// </summary>
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// scope范围
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
