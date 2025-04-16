// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class DeleteDentryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9XJlZ44W3NeDGyA</para>
        /// </summary>
        [NameInMap("DentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nb9XJx4EPx16QGyA</para>
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("ToRecycleBin")]
        [Validation(Required=false)]
        public bool? ToRecycleBin { get; set; }

    }

}
