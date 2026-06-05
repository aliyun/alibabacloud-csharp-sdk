// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppSupabaseAuthConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ALL_AUTH_FLAG</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WS20250801152639000005</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

    }

}
