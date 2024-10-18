// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class InitMultipartFileUploadShrinkRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string OptionShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dentryUuid</para>
        /// </summary>
        [NameInMap("ParentDentryUuid")]
        [Validation(Required=false)]
        public string ParentDentryUuid { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
