// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CopyAppPluginConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>31104757</para>
        /// </summary>
        [NameInMap("SourceBizId")]
        [Validation(Required=false)]
        public string SourceBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31104758</para>
        /// </summary>
        [NameInMap("TargetBizId")]
        [Validation(Required=false)]
        public string TargetBizId { get; set; }

    }

}
