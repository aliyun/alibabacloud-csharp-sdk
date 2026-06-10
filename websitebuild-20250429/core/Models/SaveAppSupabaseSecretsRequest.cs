// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SaveAppSupabaseSecretsRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Key list JSON</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;abc&quot;}</para>
        /// </summary>
        [NameInMap("SecretsJson")]
        [Validation(Required=false)]
        public string SecretsJson { get; set; }

    }

}
