// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdatePermissionShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>kDnRL6jAJMLgNkw7tBnw5aY4VyMoPYe1</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public string MembersShrink { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public string OptionShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>READER</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
