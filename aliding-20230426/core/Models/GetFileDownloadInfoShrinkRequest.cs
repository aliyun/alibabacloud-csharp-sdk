// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFileDownloadInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>798xxxxx</para>
        /// </summary>
        [NameInMap("DentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public string OptionShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>854xxxx</para>
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
