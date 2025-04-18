// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The sharing token information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WUzWCMr325LV0bH2JH4C4HoDaKIU6C4S</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
