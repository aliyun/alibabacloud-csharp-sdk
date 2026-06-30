// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CopyDentryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TargetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CopyDentryRequestTenantContext TenantContext { get; set; }
        public class CopyDentryRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("ToNextDentryId")]
        [Validation(Required=false)]
        public string ToNextDentryId { get; set; }

        [NameInMap("ToParentDentryId")]
        [Validation(Required=false)]
        public string ToParentDentryId { get; set; }

        [NameInMap("ToPrevDentryId")]
        [Validation(Required=false)]
        public string ToPrevDentryId { get; set; }

    }

}
