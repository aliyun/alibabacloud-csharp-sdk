// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class DeleteAppSupabaseSecretsRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>JSON list of keys to be deleted</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;key&quot;}</para>
        /// </summary>
        [NameInMap("KeysJson")]
        [Validation(Required=false)]
        public string KeysJson { get; set; }

    }

}
