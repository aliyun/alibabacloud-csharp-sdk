// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMultipartFileUploadInfosShrinkRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string OptionShrink { get; set; }

        [NameInMap("PartNumbers")]
        [Validation(Required=false)]
        public string PartNumbersShrink { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hwHPAAAAAipHxxxxx</para>
        /// </summary>
        [NameInMap("UploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

    }

}
