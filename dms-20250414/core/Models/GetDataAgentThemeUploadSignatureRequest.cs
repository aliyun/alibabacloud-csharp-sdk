// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetDataAgentThemeUploadSignatureRequest : TeaModel {
        /// <summary>
        /// <para>The theme UUID. By default, you do not need to specify this parameter because the backend automatically generates and returns a UUID. Specify this parameter to regenerate a signature only when the previous signature has expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0f8b2c1d-<b><b>-</b></b>-****-9a3e5f7b1c2d</para>
        /// </summary>
        [NameInMap("ThemeId")]
        [Validation(Required=false)]
        public string ThemeId { get; set; }

    }

}
