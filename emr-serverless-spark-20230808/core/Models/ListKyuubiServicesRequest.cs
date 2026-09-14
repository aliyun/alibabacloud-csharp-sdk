// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListKyuubiServicesRequest : TeaModel {
        /// <summary>
        /// <para>The token of the Kyuubi Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6w3s2e7y7t9fxnvtai9sv1uebw8b7bvc</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
